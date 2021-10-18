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
}