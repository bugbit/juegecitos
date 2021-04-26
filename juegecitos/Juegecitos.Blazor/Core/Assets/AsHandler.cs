using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Assets
{
    public class AsHandler
    {
        public int Handle { get; set; } = Constants.NullAsset;

        public static implicit operator int (AsHandler h)=>h.Handle;

        //public static explicit operator AsHandler(int h) => new AsHandler { Handle = h };
        //public static implicit operator AsHandler(int h) => new AsHandler { Handle = h };
    }
}
