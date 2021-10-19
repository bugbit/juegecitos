#include "jgsgame.h"

jgsLoop *jgsGame::m_MainLoop=new jgsLoop();
jgsGameTime jgsGame::m_MainTime;

void jgsGame::Initialize(){}

void jgsGame::InitializeParams(jgsParams &params)
{
	params.SDLflags=SDL_INIT_VIDEO;
}

void jgsGame::Run()
{
	jgsParams params;
	
	InitializeParams(params);
	Initialize();
	
	SDL_Init(params.SDLflags);
	m_Wnd=SDL_CreateWindow(params.title,SDL_WINDOWPOS_CENTERED,SDL_WINDOWPOS_CENTERED,params.w,params.h,params.wndFlags);
	InitializeRender();
}

void jgsGame::GameLoop()
{
	SDL_Event e;
	
	SDL_PollEvent(&e);
	m_MainLoop->Loop(e,m_MainTime);
}