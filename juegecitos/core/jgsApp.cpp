#include "jgsgame.h"
#include "jgsapp.h"

jgsLoop *jgsApp::m_Loop=new jgsLoop();
jgsGameTime jgsApp::m_Time;
jgsGame *jgsApp::m_GameAct=NULL;

void jgsApp::ChangeGame(jgsGame *game)
{
//if (!game->	
}

void jgsApp::SetMainGame(jgsGame *game)
{
	
}

void jgsApp::Run()
{
	#ifdef __EMSCRIPTEN__
	emscripten_set_main_loop(GameLoop, 60, 1);
#else
	#endif
}

void jgsApp::GameLoop()
{
	SDL_Event e;
	
	SDL_PollEvent(&e);
	m_Loop->Loop(e,m_Time);
}