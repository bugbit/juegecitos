using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Scene : IInitialize, ILoop, IUpdateRender
    {
        public Game Game { get; private set; }

        //public Scene(Game argGame)
        //{
        //    Game = argGame;
        //}

        public virtual void Initialize() { }

        public virtual void Render(GameTime argTime) { }
        public virtual void Update(GameTime argTime) { }

        internal void AsignGame(Game argGame) => Game = argGame;

        void ILoop.Loop(GameTime argTime)
        {
            Update(argTime);
            Render(argTime);
        }
    }
}
