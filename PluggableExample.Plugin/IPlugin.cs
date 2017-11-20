using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableExample.Plugin
{
    public interface IPlugin
    {
        string Format(string text);
    }
}
