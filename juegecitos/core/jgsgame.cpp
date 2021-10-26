#include "stdafx.h"
#include "jgsgame.h"

jgsLoop *jgsGame::m_Loop = new jgsLoop();
jgsGameTime jgsGame::m_Time;
bool jgsGame::m_Quit = false;

static SDL_Renderer *render;

void jgsGame::Initialize()
{
    jgsParams params;

    InitializeParams(params);

    SDL_Init(params.SDLflags);
    m_Wnd = SDL_CreateWindow(
        params.title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, params.w, params.h, params.wndFlags);
    switch (params.renderType)
    {
    case Surface:
        render=m_Render = SDL_CreateRenderer(m_Wnd, params.render2DIdx, params.Render2DFlags);
        break;
    }
}

void jgsGame::InitializeParams(jgsParams &params)
{
    params.SDLflags = SDL_INIT_VIDEO;
    params.wndFlags = 0;
    params.title = "Game";
    params.w = 716;
    params.h = 570;
    params.renderType = Surface;
    params.render2DIdx = -1;
    params.Render2DFlags = SDL_RENDERER_ACCELERATED;
}

void jgsGame::Run()
{
    Initialize();
#ifdef __EMSCRIPTEN__
    emscripten_set_main_loop(GameLoop, 60, 1);
#else
    while (!m_Quit)
        GameLoop();
    Destroy();
#endif
}

void jgsGame::GameLoop()
{
    SDL_Event e;

    if (SDL_PollEvent(&e))
        if (e.type == SDL_QUIT)
        {
            m_Quit = true;

            return;
        }

    SDL_RenderClear(render);

    SDL_Rect rect;
    rect.x = 250;
    rect.y = 150;
    rect.w = 200;
    rect.h = 200;

    SDL_SetRenderDrawColor(render, 0, 255, 0, 255);
    SDL_RenderFillRect(render, &rect);

    SDL_SetRenderDrawColor(render, 0, 0, 0, 255);

    SDL_RenderPresent(render);

    m_Loop->Loop(e, m_Time);
}