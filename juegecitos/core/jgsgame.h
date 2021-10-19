#ifndef JGSGAME_H

#define	JGSGAME_H

#include "jgsinterface.h"

typedef struct
{
	Uint32 SDLflags,wndFlags;
	char *title;
	int w,h;
} jgsParams;

class jgsGame : public jgsInitialize
{
public:
	inline jgsGame(int argc, char** argv)
	{
		m_Argc=argc;
		m_Argv=argv;
	}
	
protected:
	int m_Argc;
	char **m_Argv;
	SDL_Window *m_Wnd;
	
	virtual void Initialize();
	virtual void InitializeParams(jgsParams &params);
	inline virtual void InitializeRender(){}
};

#endif