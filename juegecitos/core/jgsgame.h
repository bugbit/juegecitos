#ifndef JGSGAME_H

#define	JGSGAME_H

#include "jgsinterface.h"

typedef struct
{
	Uint32 SDLflags,wndFlags;
	const char *title;
	int w,h;
} jgsParams;

typedef struct {
    float timeStamp, elapsedGameTime;
} jgsGameTime;

class jgsGame;

class jgsLoop
{
public:
    inline virtual void Loop(SDL_Event& e, jgsGameTime& time)
    {
    }
};

class jgsGame : public jgsInitialize
{
public:
	inline jgsGame(int argc, char** argv)
	{
		m_Argc=argc;
		m_Argv=argv;
	}
	
	void Run();
	
protected:
	int m_Argc;
	char **m_Argv;
	SDL_Window *m_Wnd;
	
	virtual void Initialize();
	virtual void InitializeParams(jgsParams &params);
	inline virtual void InitializeRender(){}
private:	
    static jgsLoop* m_Loop;
    static jgsGameTime m_Time;
	static bool m_Quit;
	
    static void GameLoop();
};

#endif