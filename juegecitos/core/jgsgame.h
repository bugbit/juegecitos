#ifndef JGSGAME_H

#define JGSGAME_H

#include "jgsinterface.h"
#include "jgsscene.h"
#include "jgsgameassets.h"

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

class jgsScene;

class jgsGame //: public jgsInitialize
{
public:
    inline jgsGame(int argc, char **argv) : m_Wnd(NULL), m_Render(NULL)
    {
        m_Argc = argc;
        m_Argv = argv;
    }

    int Run();
    inline void SetSceneAct(jgsScene *scene) { m_Loop = (jgsLoop *)scene; }
    inline int SDL_RenderClear() { return ::SDL_RenderClear(m_Render); }
    inline int SDL_SetRenderDrawColor(Uint8 r, Uint8 g, Uint8 b, Uint8 a)
    {
        return ::SDL_SetRenderDrawColor(m_Render, r, g, b, a);
    }
    inline int SDL_RenderFillRect(const SDL_Rect *rect) { return ::SDL_RenderFillRect(m_Render, rect); }
    inline void SDL_RenderPresent() { ::SDL_RenderPresent(m_Render); }

protected:
    std::string m_Error;
    int m_Argc;
    char **m_Argv;
    SDL_Window *m_Wnd;
    SDL_Renderer *m_Render;
    jgsGameAssets m_Assets;
    void *m_AssetsData;

    virtual bool Initialize();
    virtual bool InitializeParams(jgsParams &params);
    inline virtual void *PrepareLoadAssets() { return NULL; }
    bool LoadAssets();
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

    int GameError();
    static void GameLoop();
};

#endif
