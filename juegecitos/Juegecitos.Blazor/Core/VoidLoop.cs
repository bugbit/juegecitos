using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class VoidLoop : ILoop
    {
        private static readonly Lazy<ILoop> mInstance = new Lazy<ILoop>(() => new VoidLoop());

        private VoidLoop() { }

        public static ILoop Instance => mInstance.Value;

        void ILoop.Loop(GameTime argTime)
        {
        }
    }
}
