using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public interface IHost
    {
        void SetLoop(ILoop argLoop);
        void ChangeGame(Game argGame, bool argUnLoadGameAct = true);
        void SetContext(string type);
        void clearRect(int x, int y, int width, int height);
        void setfillStyle(string style);
        void fillRect(int x, int y, int width, int height);
        void setfont(string font);
        void strokeText(string text, int x, int y);
        void fillText(string text, int x, int y);
    }
}
