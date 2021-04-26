using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public interface IHost
    {
        Input.InputSystem Input { get; }

        void SetLoop(ILoop argLoop);
        void ChangeGame(Game argGame, bool argUnLoadGameAct = true);
        void SetActiveScene(Core.Scene argScene);
        // assets

        //low
        int loadSound(string url);
        bool unloadSound(int i);
        bool playSound(int i);

        //high
        void LoadSound(Assets.AsHandler h, string url);
        bool UnLoadSound(Assets.AsHandler h);
        // 2d
        void clearRect(int x, int y, int width, int height);
        void setfillStyle(string style);
        void fillRect(int x, int y, int width, int height);
        void setfont(string font);
        void strokeText(string text, int x, int y);
        void fillText(string text, int x, int y);
        void setTransform(double a, double b, double c, double d, double e, double f);
        void beginPath();
        void closePath();
        void arc(int x, int y, double radius, double startAngle, double endAngle, bool counterclockwise);
        void fill();
    }
}
