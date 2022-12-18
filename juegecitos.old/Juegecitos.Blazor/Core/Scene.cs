using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Scene : IInitialize, ILoad, ILoop, IUpdateRender
    {
        public Game Game { get; private set; }
        public bool IsLoaded { get; private set; }

        public void Load()
        {
            Initialize();
            Game.LoadedScene(this);
            IsLoaded = true;
        }
        public void UnLoad()
        {
            Game.UnLoadedScene(this);
            IsLoaded = false;
        }

        public Scene(Game argGame)
        {
            Game = argGame;
        }

        public virtual void Initialize() { }

        public virtual void Render(GameTime argTime) { }
        public virtual void Update(GameTime argTime) { }

        //internal void AsignGame(Game argGame) => Game = argGame;

        void ILoop.Loop(GameTime argTime)
        {
            Update(argTime);
            Render(argTime);
        }
    }
}
