using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juegecitos.Blazor.Core;
using Juegecitos.Blazor.Core.Input;

namespace Juegecitos.Blazor.Games.PingPong
{
    public class PingPongGame : Game
    {
        public override void Initialize()
        {
            base.Initialize();
            PresentationParameters.BackColor = "white";
            PresentationParameters.Width = 600;
            PresentationParameters.Height = 400;
            PresentationParameters.MainScene = new PingPongScene(this);

            Actions.Add("Vertical1", new Core.Input.Action(
                    new ActionUpdateKeyAxis { KeyCode = KeyCodes.Up, Axis = new System.Numerics.Vector2(0, -1) },
                    new ActionUpdateKeyAxis { KeyCode = KeyCodes.Down, Axis = new System.Numerics.Vector2(0, 1) }
                ));
            Actions.Add("Vertical2", new Core.Input.Action(
                   new ActionUpdateKeyAxis { KeyCode = KeyCodes.UpNumPad, Axis = new System.Numerics.Vector2(0, -1) },
                   new ActionUpdateKeyAxis { KeyCode = KeyCodes.DownNumPad, Axis = new System.Numerics.Vector2(0, 1) }
               ));
        }
    }
}
