#include "JGS_params.h"
#include "JGS_game.h"

static char error[256];

int JGS_InitGame(JGS_Game *game,JGS_Params *params)
{
	int ret=SDL_Init(params->SDLflags);
	
	if (ret)
	{
		sprintf(error,"SDL_Init failed: %s\n", SDL_GetError());
		
		return ret;
	}
		
	
	return ret;
}