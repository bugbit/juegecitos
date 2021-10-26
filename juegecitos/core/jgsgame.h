#ifndef JGSGAME_H

#define JGSGAME_H

#include "jgsinterface.h"
#include "jgsscene.h"

enum ERenderType
{
    Surface
};

typedef struct
{
    Uint32 SDLflags, wndFlags;
    const char *title;
    int w, h;
    ERenderType renderType;
    int render2DIdx, Render2DFlags, Render2DFlags2;
} jgsParams;

class jgsGame;

class jgsGame //: public jgsInitialize
{
public:
    inline jgsGame(int argc, char **argv) : m_Wnd(NULL), m_Render(NULL)
    {
        m_Argc = argc;
        m_Argv = argv;
    }

    int Run();
    inline void SetSceneAct(jgsScene *scene) { m_Loop = scene; }

protected:
    std::string m_Error;
    int m_Argc;
    char **m_Argv;
    SDL_Window *m_Wnd;
    SDL_Renderer *m_Render;

    virtual bool Initialize();
    virtual bool InitializeParams(jgsParams &params);
    inline virtual void Destroy()
    {
        if (m_Render != NULL)
        {
            SDL_DestroyRenderer(m_Render);
            m_Render = NULL;
        }
        if (m_Wnd != NULL)
        {
            SDL_DestroyWindow(m_Wnd);
            m_Wnd = NULL;
        }
    }

private:
    static jgsLoop *m_Loop;
    static jgsGameTime m_Time;
    static bool m_Quit;

    static void GameLoop();
};

#endif
