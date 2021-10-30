#ifndef JGSGAME_H

#define JGSGAME_H

#include "jgsgameassets.h"
#include "jgsinterface.h"
#include "jgsscene.h"

enum ERenderType { Surface };

typedef struct {
    Uint32 SDLflags, wndFlags;
    const char* title;
    int w, h;
    ERenderType renderType;
    int render2DIdx, Render2DFlags, Render2DFlags2;
} jgsParams;

class jgsScene;

class jgsGame //: public jgsInitialize
{
public:
    inline jgsGame(int argc, char** argv)
        : m_Wnd(NULL)
        , m_Render(NULL)
        , m_MainScene(NULL)
        , m_CurrentScene(NULL)
        , m_AssetsData(NULL)
    {
	m_Argc = argc;
	m_Argv = argv;
    }
    inline bool SetError(std::string err)
    {
	m_Error = err;

	return false;
    }

    int Run();
    void SetSceneAct(jgsScene* scene);
    inline void SDL_GetWindowSize(int* w, int* h)
    {
	::SDL_GetWindowSize(m_Wnd, w, h);
    }
    inline SDL_Renderer* GetRender2D() const
    {
	return m_Render;
    }
    inline int SDL_RenderClear()
    {
	return ::SDL_RenderClear(m_Render);
    }
    inline int SDL_SetRenderDrawColor(Uint8 r, Uint8 g, Uint8 b, Uint8 a)
    {
	return ::SDL_SetRenderDrawColor(m_Render, r, g, b, a);
    }
    inline int SDL_RenderFillRect(const SDL_Rect* rect)
    {
	return ::SDL_RenderFillRect(m_Render, rect);
    }
    inline int SDL_RenderCopy(SDL_Texture* texture, const SDL_Rect* srcrect, const SDL_Rect* dstrect)
    {
	return ::SDL_RenderCopy(m_Render, texture, srcrect, dstrect);
    }
    inline void SDL_RenderPresent()
    {
	::SDL_RenderPresent(m_Render);
    }
    inline void* GetAssetsData() const
    {
	return m_AssetsData;
    }

protected:
    int m_Argc;
    char** m_Argv;
    SDL_Window* m_Wnd;
    SDL_Renderer* m_Render;
    jgsScene *m_MainScene, *m_CurrentScene;
    std::string m_Error;
    void* m_AssetsData;
    jgsGameAssets m_Assets;

    virtual bool Initialize();
    virtual bool InitializeParams(jgsParams& params);
    inline virtual void* PrepareLoadAssets()
    {
	return NULL;
    }
    bool LoadAssets();
    inline virtual void Destroy()
    {
	if(m_Render != NULL) {
	    SDL_DestroyRenderer(m_Render);
	    m_Render = NULL;
	}
	if(m_Wnd != NULL) {
	    SDL_DestroyWindow(m_Wnd);
	    m_Wnd = NULL;
	}
    }

private:
    static jgsLoop* m_Loop;
    static jgsGameTime m_Time;
    static bool m_Quit;

    int GameError();
    static void GameLoop();
};

#endif
