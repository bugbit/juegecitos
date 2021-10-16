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

        public override void LoadAssets()
        {
            var pHost = Host;
            var pAssets = new JPAssets();

            mAssets = pAssets;

            base.LoadAssets();

            pHost.LoadImage(pAssets.baseImg, "jetpac/base.png");
            pHost.LoadImage(pAssets.platformImg, "jetpac/platform.png");
            pHost.LoadImage(pAssets.platform2Img, "jetpac/platform_two.png");
        }
    }
}