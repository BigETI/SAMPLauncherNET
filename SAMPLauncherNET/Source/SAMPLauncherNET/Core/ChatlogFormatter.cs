using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Chatlog formatter
    /// </summary>
    public static class ChatlogFormatter
    {
        /// <summary>
        /// Format chatlog string
        /// </summary>
        /// <param name="text">Text</param>
        /// <param name="formatType">Chatlog format type</param>
        /// <param name="showColorCodes">Show color codes</param>
        /// <param name="showColored">Show colored text</param>
        /// <param name="showTimestamp">Show timestamp</param>
        /// <returns>Formatted string</returns>
        public static string Format(string text, EChatlogFormatType formatType, bool showColorCodes, bool showColored, bool showTimestamp)
        {
            StringBuilder ret = new StringBuilder();
            Regex regex = null;
            try
            {
                switch (formatType)
                {
                    case EChatlogFormatType.Plain:
                        string plain_text = ((text == null) ? "" : text);
                        if (!showColorCodes)
                        {
                            regex = new Regex(@"\{([0-9a-f]{6})\}", RegexOptions.IgnoreCase);
                            plain_text = regex.Replace(plain_text, "");
                        }
                        if (!showTimestamp)
                        {
                            regex = new Regex(@"\[[0-9]{2}:[0-9]{2}:[0-9]{2}\][^\S\n]*");
                            plain_text = regex.Replace(plain_text, "");
                        }
                        ret.Append(plain_text);
                        break;

                    case EChatlogFormatType.RTF:
                        string rtf_escaped_text = ((text == null) ? "" : text.Replace("\\", "\\\\").Replace("{", "\\{").Replace("}", "\\}"));
                        int rtf_color_index = 2;
                        Dictionary<int, Tuple<Color, int>> color_table = new Dictionary<int, Tuple<Color, int>>
                        {
                            {
                                0xFFFFFF,
                                new Tuple<Color, int>(Color.FromArgb(255, 255, 255), 1)
                            },
                            {
                                0x333333,
                                new Tuple<Color, int>(Color.FromArgb(51, 51, 51), 2)
                            }
                        };
                        MatchCollection matches = null;
                        regex = new Regex(@"\\\{([0-9a-f]{6})\\\}", RegexOptions.IgnoreCase);
                        matches = regex.Matches(rtf_escaped_text);
                        ret.Append(@"{\rtf1{\colortbl ;\red255\green255\blue255;\red51\green51\blue51;");
                        foreach (Match match in matches)
                        {
                            if (match.Groups.Count > 1)
                            {
                                try
                                {
                                    int color_code = Convert.ToInt32(match.Groups[1].Value, 16);
                                    Color color = Color.FromArgb((color_code >> 16) & 0xFF, (color_code >> 8) & 0xFF, color_code & 0xFF);
                                    if (!(color_table.ContainsKey(color_code)))
                                    {
                                        color_table.Add(color_code, new Tuple<Color, int>(color, ++rtf_color_index));
                                        if (showColored)
                                        {
                                            ret.Append(@"\red" + ((int)(color.R)) + @"\green" + ((int)(color.G)) + @"\blue" + ((int)(color.B)) + ";");
                                        }
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.Error.WriteLine(e);
                                }
                            }
                            string upper_match = match.Value.ToUpper();
                            if (match.Value != upper_match)
                            {
                                rtf_escaped_text = rtf_escaped_text.Replace(match.Value, upper_match);
                            }
                        }
                        if (!showTimestamp)
                        {
                            try
                            {
                                regex = new Regex(@"\[[0-9]{2}:[0-9]{2}:[0-9]{2}\][^\S\n]*");
                                rtf_escaped_text = regex.Replace(rtf_escaped_text, "");
                            }
                            catch (Exception e)
                            {
                                Console.Error.WriteLine(e);
                            }
                        }
                        ret.Append(@"}\highlight2");
                        string[] rtf_lines = rtf_escaped_text.Replace("\r", "").Split('\n');
                        if (rtf_lines != null)
                        {
                            foreach (string line in rtf_lines)
                            {
                                string new_line = line;
                                ret.AppendLine(@"\cf1");
                                foreach (KeyValuePair<int, Tuple<Color, int>> pair in color_table)
                                {
                                    new_line = new_line.Replace(@"\{" + string.Format("{0:X6}", pair.Key) + @"\}", (showColored ? (Environment.NewLine + @"\cf" + pair.Value.Item2 + Environment.NewLine) : "") + (showColorCodes ? (@"\{" + string.Format("{0:X}", pair.Key) + @"\}") : ""));
                                }
                                ret.AppendLine(new_line);
                                ret.AppendLine(@"\par");
                            }
                        }
                        ret.Append(Environment.NewLine);
                        ret.Append("}");
                        break;

                    case EChatlogFormatType.HTMLSnippet:
                    case EChatlogFormatType.HTML:
                        if (formatType == EChatlogFormatType.HTML)
                        {
                            ret.Append("<!DOCTYPE html><head><title>San Andreas Multiplayer last chatlog</title><body style=\"background-color: #333333; color: #ffffff;\">");
                        }
                        try
                        {
                            regex = new Regex(@"\{([0-9a-f]{6})\}", RegexOptions.IgnoreCase);
                            if (regex != null)
                            {
                                string html_encoded_text = ((text == null) ? "" : HttpUtility.HtmlEncode(text).Replace("\r", ""));
                                string[] html_lines = html_encoded_text.Split('\n');
                                if (html_lines != null)
                                {
                                    foreach (string line in html_lines)
                                    {
                                        string new_line = line;
                                        matches = regex.Matches(line);
                                        if (matches != null)
                                        {
                                            foreach (Match match in matches)
                                            {
                                                if (match.Groups.Count > 1)
                                                {
                                                    new_line = new_line.Replace(match.Value, (showColored ? ("<span style=\"color: #" + match.Groups[1].Value.ToLower() + ";\">") : "") + (showColorCodes ? (match.Value) : ""));
                                                }
                                            }
                                            ret.Append(new_line);
                                            for (int i = 0; i < matches.Count; i++)
                                            {
                                                ret.Append("</span>");
                                            }
                                        }
                                        else
                                        {
                                            ret.Append(new_line);
                                        }
                                        ret.Append("<br />");
                                    }
                                }
                                if (!showTimestamp)
                                {
                                    try
                                    {
                                        regex = new Regex(@"\[[0-9]{2}:[0-9]{2}:[0-9]{2}\][^\S\n]*");
                                        html_encoded_text = ret.ToString();
                                        ret.Clear();
                                        ret.Append(regex.Replace(html_encoded_text, ""));
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Error.WriteLine(e);
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e);
                        }
                        if (formatType == EChatlogFormatType.HTML)
                        {
                            ret.Append("</body></html>");
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                ret.Clear();
                Console.Error.WriteLine(e);
            }
            return ret.ToString();
        }
    }
}
