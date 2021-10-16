using Box2DX.Collision;
using Box2DX.Common;
using Box2DX.Dynamics;
using Juegecitos.Blazor.Core;

namespace Juegecitos.Blazor.Games.Jetpac
{
    public class JPLevelScene : Scene
    {
        public JPLevelScene(Game argGame) : base(argGame)
        {
        }

        // public override void Initialize()
        // {
        //     base.Initialize();

        //      AABB worldAABB = new AABB();
        //     worldAABB.LowerBound.Set(-100.0f);
        //     worldAABB.UpperBound.Set(100.0f);

        //     // Define the gravity vector.
        //     Vec2 gravity = new Vec2(0.0f, -10.0f);

        //     // Do we want to let bodies sleep?
        //     const bool DoSleep = true;

        //     // Construct a world object, which will hold and simulate the rigid bodies.
        //     World world = new World(worldAABB, gravity, DoSleep);
        // }

        public override void Render(GameTime argTime)
        {
            var pHost = Game.Host;
            var pAssets = Game.GetAssets<JPAssets>();

            base.Render(argTime);
            pHost.setfillStyle("#000"); /* whatever comes below this acquires black color (#000). */
            // draws the black board
            pHost.fillRect(0, 0, Game.Width, Game.Height);
            pHost.drawImage(pAssets.baseImg,20,20);
        }
    }
}