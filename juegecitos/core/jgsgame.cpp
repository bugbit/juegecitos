#include "stdafx.h"
#include "jgsgame.h"

jgsLoop *jgsGame::m_Loop = new jgsLoop();
jgsGameTime jgsGame::m_Time;
bool jgsGame::m_Quit = false;

static SDL_Renderer *render;

bool jgsGame::Initialize()
{
    jgsParams params;

    if (!InitializeParams(params))
        return false;

    if (SDL_Init(params.SDLflags))
    {
        m_Error = "Unable to initialize SDL: " + std::string(SDL_GetError());

        return false;
    }

    if ((m_Wnd = SDL_CreateWindow(params.title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, params.w, params.h, params.wndFlags)) == NULL)
    {
        m_Error = "Could not create window: " + std::string(SDL_GetError());

        return false;
    }

    switch (params.renderType)
    {
    case Surface:
        if ((render = m_Render = SDL_CreateRenderer(m_Wnd, params.render2DIdx, params.Render2DFlags)) == NULL)
        {
            if (!params.Render2DFlags || ((render = m_Render = SDL_CreateRenderer(m_Wnd, params.render2DIdx, params.Render2DFlags2)) == NULL))
            {
                m_Error = "Render creation for surface fail : " + std::string(SDL_GetError());

                return false;
            }
        }
        break;
    }

    return true;
}

bool jgsGame::InitializeParams(jgsParams &params)
{
    params.SDLflags = SDL_INIT_VIDEO;
    params.wndFlags = 0;
    params.title = "Game";
    params.w = 716;
    params.h = 570;
    params.renderType = Surface;
    params.render2DIdx = -1;
    params.Render2DFlags = SDL_RENDERER_ACCELERATED;
    params.Render2DFlags2 = SDL_RENDERER_SOFTWARE;

    return true;
}

int jgsGame::Run()
{
    if (!Initialize())
    {
        SDL_LogError(SDL_LOG_CATEGORY_APPLICATION, m_Error.c_str());
        SDL_ShowSimpleMessageBox(SDL_MESSAGEBOX_ERROR, "Error", m_Error.c_str(), NULL);

        return EXIT_FAILURE;
    }
    m_Time.timeStamp = SDL_GetTicks();
#ifdef __EMSCRIPTEN__
    emscripten_set_main_loop(GameLoop, 60, 1);
#else
    while (!m_Quit)
        GameLoop();
    Destroy();
#endif

    return EXIT_SUCCESS;
}

void jgsGame::GameLoop()
{
    SDL_Event e;
    Uint32 timeStamp = SDL_GetTicks();

    if (SDL_PollEvent(&e))
        if (e.type == SDL_QUIT)
        {
            m_Quit = true;

            return;
        }

    m_Time.elapsedGameTime = timeStamp - m_Time.timeStamp;
    m_Time.timeStamp = timeStamp;

    SDL_RenderClear(render);

    // SDL_Rect rect;
    // rect.x = 250;
    // rect.y = 150;
    // rect.w = 200;
    // rect.h = 200;

    // SDL_SetRenderDrawColor(render, 0, 255, 0, 255);
    // SDL_RenderFillRect(render, &rect);

    // SDL_SetRenderDrawColor(render, 0, 0, 0, 255);

    // SDL_RenderPresent(render);

    m_Loop->Loop(e, m_Time);
}