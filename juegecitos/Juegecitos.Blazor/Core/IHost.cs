using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public interface IHost
    {
        int Width { get; }
        int Height { get; }

        void SetLoop(ILoop argLoop);
        void ChangeGame(Game argGame, bool argUnLoadGameAct = true);
        void SetActiveScene(Core.Scene argScene);
        void SetContext(string type);
        //void changedGame();
        void clearRect(int x, int y, int width, int height);
        void setfillStyle(string style);
        void fillRect(int x, int y, int width, int height);
        void setfont(string font);
        void strokeText(string text, int x, int y);
        void fillText(string text, int x, int y);
        void setTransform(float a, float b, float c, float d, float e, float f);
    }
}
