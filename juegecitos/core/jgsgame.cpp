#include "jgsgame.h"

jgsLoop* jgsGame::m_Loop = new jgsLoop();
jgsGameTime jgsGame::m_Time;
bool jgsGame::m_Quit=false;

void jgsGame::Initialize()
{
    jgsParams params;

    InitializeParams(params);

    SDL_Init(params.SDLflags);
    m_Wnd = SDL_CreateWindow(
        params.title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, params.w, params.h, params.wndFlags);
    InitializeRender();
}

void jgsGame::InitializeParams(jgsParams& params)
{
    params.SDLflags = SDL_INIT_VIDEO;
	params.wndFlags=0;
	params.title="Game";
	params.w=716;
	params.h=570;
}

void jgsGame::Run()
{
    Initialize();
#ifdef __EMSCRIPTEN__
    emscripten_set_main_loop(GameLoop, 60, 1);
#else
    while(!m_Quit)
		GameLoop();
#endif
}

void jgsGame::GameLoop()
{
    SDL_Event e;

    if (SDL_PollEvent(&e))
		if (e.type == SDL_QUIT)
		{
			m_Quit=true;
			
			return;
		}
    m_Loop->Loop(e, m_Time);
}