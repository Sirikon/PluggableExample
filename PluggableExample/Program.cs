using PluggableExample.Plugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PluggableExample
{
    class Program
    {
        private static IEnumerable<string> GetPluginsPaths()
        {
            return Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "Plugins/"));
        }

        private static bool CheckArgs(string[] args)
        {
            if (args.Length > 0)
            {
                return true;
            }
            Console.WriteLine("Expected any argument");
            return false;
        }

        static void Main(string[] args)
        {
            if (!CheckArgs(args)) return;

            var message = args[0];

            var pluginsPaths = GetPluginsPaths();
            foreach(var pluginPath in pluginsPaths)
            {
                var dll = Assembly.LoadFile(pluginPath);
                var exportedTypes = dll.GetExportedTypes();
                foreach(var type in exportedTypes)
                {
                    if (type.GetInterface(typeof(IPlugin).FullName) != null)
                    {
                        IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                        message = plugin.Format(message);
                    }
                }
            }

            Console.WriteLine(message);
        }
    }
}
