#ifndef	JPGAME_H

#define	JPGAME_H

#include "jgsgame.h"

class jpGame : public jgsGame
{
public:
	jpGame(int argc, char** argv);
protected:
	bool InitializeParams(jgsParams &params);
};

#endif
