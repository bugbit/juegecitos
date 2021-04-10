using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class Game : IDisposable, IInitialize, ILoop, IUpdate, IRender
    {
        private bool disposedValue;

        protected IHost mHost;

        public PresentationParameters PresentationParameters { get; } = new PresentationParameters();

        public void AsignHost(IHost argHost) => mHost = argHost;

        public virtual void Initialize() { }

        public void Loop(GameTime argTime)
        {
            Update(argTime);
            Render(argTime);
        }

        public virtual void Update(GameTime argTime) { }
        public virtual void Render(GameTime argTime) { }

        protected virtual void DisposeInternal(bool disposing)
        {
            if (disposing)
            {
                // TODO: eliminar el estado administrado (objetos administrados)
            }

            // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
            // TODO: establecer los campos grandes como NULL
        }

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                DisposeInternal(disposing);
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~Game()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
