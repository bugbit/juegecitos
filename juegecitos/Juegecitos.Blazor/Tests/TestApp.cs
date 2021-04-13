#if DEBUG

using Juegecitos.Blazor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Tests
{
    public class TestApp : Core.App
    {
        public override Game Main()
            => new Test1Game();
            //=> new Games.PingPong.PingPongGame();
    }
}

#endif