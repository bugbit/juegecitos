#include "jpgame.h"

/*static JGS_Params params=
{
	SDL_INIT_VIDEO, 0, "Jetpac", 716, 570
};*/

jpGame::jpGame(int argc,char **argv):jgsGame(argc,argv)
{
	
}

extern "C" int main(int argc, char** argv)
{
	jpGame game(argc,argv);
	
	game.Run();
	
	return EXIT_SUCCESS;
}