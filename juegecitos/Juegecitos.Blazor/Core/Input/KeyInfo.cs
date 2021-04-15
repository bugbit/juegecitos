using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public struct KeyInfo
    {
        public static readonly KeyInfo None = new KeyInfo();

        /// <summary>
        ///     The key value of the key represented by the event. If the value has a printed
        ///     representation, this attribute's value is the same as the char attribute. Otherwise,
        ///     it's one of the key value strings specified in 'Key values'. If the key can't
        ///     be identified, this is the string "Unidentified"
        /// </summary>
        public string Key;

        /// <summary>
        /// Resumen:
        ///     Holds a string that identifies the physical key being pressed. The value is not
        ///     affected by the current keyboard layout or modifier state, so a particular key
        ///     will always return the same value.
        /// </summary>
        public string Code;
        /// <summary>
        /// None, Up, Down
        /// </summary>
        public EButtonState State;
    }
}
