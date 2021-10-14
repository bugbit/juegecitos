using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.Jetpac
{
    public class JetpacGame : Game
    {
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.Width=716;
            PresentationParameters.Height=570;
            PresentationParameters.MainScene=new JPLevelScene(this);
        }
    }
}