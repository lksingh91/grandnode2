﻿using System.Reflection;

namespace Grand.Infrastructure.Plugins
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class PluginInfoAttribute : Attribute
    {
        public PluginInfoAttribute()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version fullVersion = assembly.GetName().Version;
            SupportedVersion = $"{fullVersion?.Minor}.{fullVersion?.Major}";
            
        }
        public string Group { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string SystemName { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public string SupportedVersion { get; set; }

        public string Version { get; set; }
    }
}