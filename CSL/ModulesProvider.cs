using CSLPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Windows;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Module provider
    /// </summary>
    internal static class ModulesProvider
    {
        /// <summary>
        /// Serializer
        /// </summary>
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ModulesDataContract[]));

        /// <summary>
        /// Get instance
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="type">Type to instantiate</param>
        /// <param name="instance">Current instance</param>
        /// <returns>Instance if successful, otherwise "null"</returns>
        private static T GetInstance<T>(Type type, ref object instance) where T : class
        {
            if (instance == null)
            {
                instance = Activator.CreateInstance(type);
            }
            return instance as T;
        }

        /// <summary>
        /// Load all Community San Andreas Multiplayer Launcher modules
        /// </summary>
        /// <param name="modulesDirectory">Community San Andreas Multiplayer Launcher modules directory</param>
        /// <returns>Community San Andreas Multiplayer Launcher modules</returns>
        public static ModulesData[] LoadAll(string modulesDirectory)
        {
            ModulesData[] ret;
            List<ModulesData> modules_data = new List<ModulesData>();
            try
            {
                if (modulesDirectory != null)
                {
                    if (Directory.Exists(modulesDirectory))
                    {
                        ModulesDataContract[] load_modules = null;
                        string modules_json_path = Path.Combine(modulesDirectory, "modules.json");
                        try
                        {
                            if (File.Exists(modules_json_path))
                            {
                                using (FileStream stream = File.Open(modules_json_path, FileMode.Open, FileAccess.Read))
                                {
                                    load_modules = serializer.ReadObject(stream) as ModulesDataContract[];
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e);
                        }
                        if (load_modules == null)
                        {
                            load_modules = new ModulesDataContract[0];
                        }
                        foreach (ModulesDataContract load_module in load_modules)
                        {
                            if (load_module != null)
                            {
                                string modules_path = (load_module.Name.ToLower().EndsWith(".dll") ? load_module.Name : (load_module.Name + ".dll"));
                                string modules_full_path = Path.GetFullPath(Path.Combine(modulesDirectory, modules_path));
                                try
                                {
                                    Assembly assembly = Assembly.LoadFile(modules_full_path);
                                    if (assembly != null)
                                    {
                                        List<ICSLModule> modules = new List<ICSLModule>();
                                        List<ICSLPage> pages = new List<ICSLPage>();
                                        Type[] types = assembly.GetExportedTypes();
                                        if (types != null)
                                        {
                                            foreach (Type type in types)
                                            {
                                                if (type != null)
                                                {
                                                    if (type.IsClass)
                                                    {
                                                        object instance = null;
                                                        if (typeof(ICSLModule).IsAssignableFrom(type))
                                                        {
                                                            ICSLModule module = GetInstance<ICSLModule>(type, ref instance);
                                                            if (module != null)
                                                            {
                                                                modules.Add(module);
                                                            }
                                                        }
                                                        if (typeof(ICSLPage).IsAssignableFrom(type) && typeof(UIElement).IsAssignableFrom(type))
                                                        {
                                                            ICSLPage page = GetInstance<ICSLPage>(type, ref instance);
                                                            if (page != null)
                                                            {
                                                                pages.Add(page);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        modules_data.Add(new ModulesData(Path.GetFileNameWithoutExtension(modules_path), modules.ToArray(), pages.ToArray()));
                                        modules.Clear();
                                        pages.Clear();
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Error.WriteLine(e);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            ret = modules_data.ToArray();
            modules_data.Clear();
            return ret;
        }

        /// <summary>
        /// Load Community San Andreas Multiplayer Launcher module
        /// </summary>
        /// <param name="modulePath">Community San Andreas Multiplayer Launcher module path</param>
        /// <returns>Community San Andreas Multiplayer Launcher module if successful, otherwwise "null"</returns>
        public static ICSLModule LoadModule(string modulePath)
        {
            ICSLModule ret = null;
            try
            {
                if (modulePath != null)
                {
                    if (File.Exists(modulePath))
                    {
                        Assembly assembly = Assembly.LoadFile(modulePath);
                        if (assembly != null)
                        {
                            Type[] types = assembly.GetExportedTypes();
                            if (types != null)
                            {
                                foreach (Type type in types)
                                {
                                    if (type != null)
                                    {
                                        if (type.IsClass && typeof(ICSLModule).IsAssignableFrom(type))
                                        {
                                            ret = Activator.CreateInstance(type) as ICSLModule;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            return ret;
        }
    }
}
