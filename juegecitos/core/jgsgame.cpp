#include "jgsgame.h"

void jgsGame::Initialize()
{
	jgsParams params;
	
	InitializeParams(params);
	
	SDL_Init(params.SDLflags);
	m_Wnd=SDL_CreateWindow(params.title,SDL_WINDOWPOS_CENTERED,SDL_WINDOWPOS_CENTERED,params.w,params.h,params.wndFlags);
	InitializeRender();
}

void jgsGame::InitializeParams(jgsParams &params)
{
	params.SDLflags=SDL_INIT_VIDEO;
}