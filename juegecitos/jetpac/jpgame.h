#ifndef	JPGAME_H

#define	JPGAME_H

#include "jplevelscene.h"

typedef struct {
	SDL_Texture *texBase,*texPlaform,*texPlaform2;
} jpAssetsData;

class jpGame : public jgsGame
{
public:
	jpGame(int argc, char** argv);
protected:
	jpLevelScene *m_LevelScene;
	bool Initialize();
	bool InitializeParams(jgsParams &params);
	void *PrepareLoadAssets();
	void Destroy();
};

#endif
