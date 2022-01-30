#include "jgsgame.h"
#include "stdafx.h"

jgsLoop* jgsGame::m_Loop = new jgsLoop();
jgsGameTime jgsGame::m_Time;
bool jgsGame::m_Quit = false;

static SDL_Renderer* render;

bool jgsGame::Initialize()
{
    jgsParams params;

    if(!InitializeParams(params))
	return false;

    if(SDL_Init(params.SDLflags)) {
	m_Error = "Unable to initialize SDL: " + std::string(SDL_GetError());

	return false;
    }

    if((m_Wnd = SDL_CreateWindow(params.title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, params.w, params.h,
            params.wndFlags)) == NULL) {
	m_Error = "Could not create window: " + std::string(SDL_GetError());

	return false;
    }

    switch(params.renderType) {
    case Surface:
	if((render = m_Render = SDL_CreateRenderer(m_Wnd, params.render2DIdx, params.Render2DFlags)) == NULL) {
	    if(!params.Render2DFlags ||
	        ((render = m_Render = SDL_CreateRenderer(m_Wnd, params.render2DIdx, params.Render2DFlags2)) == NULL)) {
		m_Error = "Render creation for surface fail : " + std::string(SDL_GetError());

		return false;
	    }
	}
	break;
    }

    return true;
}

bool jgsGame::InitializeParams(jgsParams& params)
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

bool jgsGame::LoadAssets()
{
    return m_Assets.LoadDatas(*this);
}

int jgsGame::GameError()
{
    Destroy();

    SDL_LogError(SDL_LOG_CATEGORY_APPLICATION, m_Error.c_str());
    SDL_ShowSimpleMessageBox(SDL_MESSAGEBOX_ERROR, "Error", m_Error.c_str(), NULL);

    return EXIT_FAILURE;
}

void jgsGame::SetSceneAct(jgsScene* scene)
{
    scene->Initialize();
    m_CurrentScene = scene;
    m_Loop = (jgsLoop*)scene;
}

int jgsGame::Run()
{
    if(!Initialize())
	return GameError();

    m_AssetsData = PrepareLoadAssets();
    m_Time.timeStamp = SDL_GetTicks();
    if(!LoadAssets())
	return GameError();
    SetSceneAct(m_MainScene);
#ifdef __EMSCRIPTEN__
    emscripten_set_main_loop(GameLoop, 0, 1);
#else
    // simulamos 60 fps por segundo como en el wasm
    uint32 timeFrame = SDL_GetTicks() + 16;

    while(!m_Quit)
	if(SDL_GetTicks() >= timeFrame) {
	    timeFrame = SDL_GetTicks() + 16;
	    GameLoop();
	}
    Destroy();
#endif

    return EXIT_SUCCESS;
}

void jgsGame::GameLoop()
{
    jgsEvents e;
    SDL_Event* eptr;
    Uint32 timeStamp = SDL_GetTicks();

    e.numEvents = 0;
    eptr = e.events;
    while(SDL_PollEvent(eptr)) {
	if(eptr->type == SDL_QUIT) {
	    m_Quit = true;

	    return;
	}
	eptr++;
	e.numEvents++;
    }

    m_Time.elapsedGameTime = timeStamp - m_Time.timeStamp;
    m_Time.timeStamp = timeStamp;

    m_Loop->Loop(e, m_Time);
}