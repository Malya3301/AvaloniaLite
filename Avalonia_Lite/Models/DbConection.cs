using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia_Lite.Models
{
    internal class DbConection
    {
        public static Test320Context Test320Context { get; private set; } = new Test320Context();
    }
}
