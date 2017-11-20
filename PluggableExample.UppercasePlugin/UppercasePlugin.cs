using PluggableExample.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableExample.UppercasePlugin
{
    public class UppercasePlugin : IPlugin
    {
        public string Format(string text)
        {
            return text.ToUpper();
        }
    }
}
