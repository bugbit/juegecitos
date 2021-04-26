using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Game : IInitialize, ILoad
    {
        private List<Scene> mScenesLoades = new List<Scene>();

        protected object mAssets;

        public float TotalTime { get; internal set; } = 0;
        public IHost Host { get; internal set; }
        public Scene ActiveScene { get; internal set; }
        public bool IsLoaded { get; private set; }
        public string BackColor { get; internal set; }
        public int Width { get; internal set; }
        public int Height { get; internal set; }
        public string CanvasContext { get; internal set; }

        public PresentationParameters PresentationParameters { get; } = new PresentationParameters();
        public Input.ActionCollection Actions { get; } = new Input.ActionCollection();

        public virtual void Initialize() { }
        public virtual void LoadAssets() { }
        public virtual void UnLoadAssets() { }
        public void Load()
        {
            Initialize();
            LoadAssets();
            IsLoaded = true;
        }
        public void UnLoad()
        {
            UnLoadAssets();
            mScenesLoades.ForEach(s => s.UnLoad());
            mScenesLoades.Clear();
            IsLoaded = false;
        }

        public T GetAssets<T>() where T : class => mAssets as T;

        internal void LoadedScene(Scene argScene) => mScenesLoades.Add(argScene);
        internal bool UnLoadedScene(Scene argScene) => mScenesLoades.Remove(argScene);
    }
}
