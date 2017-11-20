using PluggableExample.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableExample.ExclamationsPlugin
{
    public class ExclamationsPlugin : IPlugin
    {
        public string Format(string text)
        {
            return text + "!!!!!!!";
        }
    }
}
