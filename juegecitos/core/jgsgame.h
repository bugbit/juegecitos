#ifndef __JGSGAME__H

#define	__JGSGAME__H

#include "jgsparams.h"
#include "jgsinterface.h"

class jgsGame : public jgsInitialize
{
public:
	inline jgsGame(int argc, char** argv):m_Params()
	{
		m_Argc=argc;
		m_Argv=argv;
	}
	void Run();
protected:
	int m_Argc;
	char **m_Argv;
	jgsParams m_Params;
	SDL_Window *m_Wnd;
	
	virtual void Initialize();
	virtual void InitializeParams();
	inline virtual void InitializeRender(){}
};

#endif