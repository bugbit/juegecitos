#ifndef	JPGAME_H

#define	JPGAME_H

#include "jplevelscene.h"

class jpGame : public jgsGame
{
public:
	jpGame(int argc, char** argv);
protected:
	jpLevelScene *m_LevelScene;
	bool Initialize();
	bool InitializeParams(jgsParams &params);
	void Destroy();
};

#endif
