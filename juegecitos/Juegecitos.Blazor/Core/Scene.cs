using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Scene : ILoop, IUpdateRender
    {
        public Game Game { get; }
        public GameObjectsCollection Objs { get; }

        public Scene(Game argGame, GameObjectsCollection argObjs)
        {
            Game = argGame;
            Objs = argObjs;
        }

        public Scene(Game argGame) : this(argGame, new GameObjectsCollection()) { }

        public void Render(GameTime argTime)
        {
            foreach (var pObj in Objs.GetObjsVisible())
                pObj.Render(argTime);
        }

        public void Update(GameTime argTime)
        {
            foreach (var pObj in Objs.GetObjsEnableds())
                pObj.Update(argTime);
        }
        void ILoop.Loop(GameTime argTime)
        {
            Update(argTime);
            Render(argTime);
        }
    }
}
