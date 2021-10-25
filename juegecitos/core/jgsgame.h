#ifndef JGSGAME_H

#define JGSGAME_H

#include "jgsinterface.h"

typedef struct
{
    Uint32 SDLflags, wndFlags;
    const char *title;
    int w, h;
} jgsParams;

typedef struct
{
    float timeStamp, elapsedGameTime;
} jgsGameTime;

class jgsGame;

class jgsLoop
{
public:
    inline virtual void Loop(SDL_Event &e, jgsGameTime &time)
    {
    }
};

class jgsGame : public jgsInitialize
{
public:
    inline jgsGame(int argc, char **argv) : m_Wnd(NULL), m_Render(NULL)
    {
        m_Argc = argc;
        m_Argv = argv;
    }

    void Run();

    inline void SDL_CreateRenderer(int index, Uint32 flags)
    {
        m_Render=::SDL_CreateRenderer(m_Wnd,index,flags);
    }

protected:
    int m_Argc;
    char **m_Argv;
    SDL_Window *m_Wnd;
    SDL_Renderer *m_Render;

    virtual void Initialize();
    virtual void InitializeParams(jgsParams &params);
    inline virtual void InitializeRender()
    {
    }
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
