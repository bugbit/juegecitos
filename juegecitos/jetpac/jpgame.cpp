#include "stdafx.h"
#include "jpgame.h"

/*static JGS_Params params=
{
	SDL_INIT_VIDEO, 0, "Jetpac", 716, 570
};*/

jpGame::jpGame(int argc,char **argv):jgsGame(argc,argv)
{	
}

bool jpGame::InitializeParams(jgsParams &params)
{
	jgsGame::InitializeParams(params);
	params.title="Jetpac";
	params.w=716;
	params.h=570;

	return true;
}

int main(int argc, char** argv)
{
	jpGame game(argc,argv);
	
	return game.Run();
}
