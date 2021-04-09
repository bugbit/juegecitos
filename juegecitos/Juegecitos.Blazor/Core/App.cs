using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class App
    {
        public virtual Game Main() => null;
        public virtual Task<Game> MainAsync() => Task.FromResult(new Game());

        public static App CreateMainApp()
#if DEBUG
            => new Tests.TestApp();
#else
            => new App();
#endif
    }
}
