using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class KeyInfo
    {
        public static readonly KeyInfo None = new KeyInfo { Event = new KeyboardEventArgs() };

        public KeyInfo KeyInfoOld { get; set; }

        public KeyboardEventArgs Event { get; set; }

        /// <summary>
        /// None, Up, Down
        /// </summary>
        public EButtonState State { get; set; }
    }
}
