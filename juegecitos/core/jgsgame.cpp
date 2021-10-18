#include "jgsgame.h"

void jgsGame::Initialize(){}

void jgsGame::InitializeParams()
{
	m_Params.SDLflags=SDL_INIT_VIDEO;
}

void jgsGame::Run()
{
	InitializeParams();
	Initialize();
	
	SDL_Init(m_Params.SDLflags);
	m_Wnd=SDL_CreateWindow(m_Params.title,SDL_WINDOWPOS_CENTERED,SDL_WINDOWPOS_CENTERED,m_Params.w,m_Params.h,m_Params.WndFlags);
	InitializeRender();
}