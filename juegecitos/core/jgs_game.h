#ifndef __JGS_GAME__H

#define	__JGS_GAME__H

#include <SDL2/SDL.h>

#include "jgs_interface.h"

class jgsGame : public jgsInitialize
{
public:
	inline jgsGame() { m_SDLFlags=SDL_INIT_VIDEO; }
	virtual void Initialize();
protected:
	int m_SDLFlags;
};

#endif