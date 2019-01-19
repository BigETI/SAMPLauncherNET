using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// Community San Andreas Multiplayer Launcher configuration abstract class
    /// </summary>
    public abstract class ACSLConfiguration
    {
        /// <summary>
        /// Members
        /// </summary>
        private Dictionary<string, MemberInfo> members;

        /// <summary>
        /// Keys
        /// </summary>
        public string[] Keys
        {
            get
            {
                InitMembers();
                string[] ret = new string[members.Keys.Count];
                members.Keys.CopyTo(ret, 0);
                return ret;
            }
        }

        /// <summary>
        /// Load configuration
        /// </summary>
        /// <param name="path">Path</param>
        public abstract void Load(string path);

        /// <summary>
        /// Save configuration
        /// </summary>
        /// <param name="path">Path</param>
        public abstract void Save(string path);

        /// <summary>
        /// Initialize members
        /// </summary>
        private void InitMembers()
        {
            if (members == null)
            {
                members = new Dictionary<string, MemberInfo>();
                try
                {
                    Type type = GetType();
                    FieldInfo[] fields_info = type.GetFields();
                    PropertyInfo[] properties_info = type.GetProperties();
                    if (fields_info != null)
                    {
                        foreach (FieldInfo field_info in fields_info)
                        {
                            if (field_info != null)
                            {
                                string key = field_info.Name;
                                if (!(members.ContainsKey(key)))
                                {
                                    members.Add(key, field_info);
                                }
                            }
                        }
                    }
                    if (properties_info != null)
                    {
                        foreach (PropertyInfo property_info in properties_info)
                        {
                            if (property_info != null)
                            {
                                string key = property_info.Name;
                                if (!(members.ContainsKey(key)))
                                {
                                    members.Add(key, property_info);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Set value
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void SetValue<T>(string key, T value)
        {
            try
            {
                if (key != null)
                {
                    if (members.ContainsKey(key))
                    {
                        MemberInfo member = members[key];
                        if (member is FieldInfo)
                        {
                            ((FieldInfo)member).SetValue(this, value);
                        }
                        else if (member is PropertyInfo)
                        {
                            ((PropertyInfo)member).SetValue(this, value);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Get value
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="key">Key</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Value if successful, otherwise the value of "defaultValue"</returns>
        public T GetValue<T>(string key, T defaultValue)
        {
            T ret = defaultValue;
            if (key != null)
            {
                if (members.ContainsKey(key))
                {
                    MemberInfo member = members[key];
                    if (member is FieldInfo)
                    {
                        ret = (T)(((FieldInfo)member).GetValue(this));
                    }
                    else if (member is PropertyInfo)
                    {
                        ret = (T)(((PropertyInfo)member).GetValue(this));
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Get value
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="key">Key</param>
        /// <returns>Value if successful, otherwise the default value of type</returns>
        public T GetValue<T>(string key)
        {
            return GetValue(key, default(T));
        }
    }
}
