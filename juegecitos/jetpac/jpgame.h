#ifndef JPGAME_H

#define JPGAME_H

#define idx0_texJetman_land 0
#define idx0_texJetman_air 1
#define idx1_texJetman_left 0
#define idx1_texJetman_right 1

#define idx_textRocket_stage_one	0
#define idx_textRocket_stage_two	1
#define idx_textRocket_stage_three	2
#define idx_textRocket_rocket		3
#define idx_textRocket_filledfirst	4
#define idx_textRocket_filledend	idx_textRocket_filledfirst+5

// 0 => land, 1=> air; 0=> left, 1=> right
typedef SDL_Texture* texJetmanData[2][2][3];

typedef SDL_Texture* texRocketData[idx_textRocket_filledend+1];

typedef struct {
	SDL_Texture *texBase, *texPlaform, *texPlaform2;
	texJetmanData texJetman;
	texRocketData texRocket;
} jpAssetsData;

class jpLevelScene;

class jpGame : public jgsGame
{
public:
	jpGame(int argc, char** argv);

protected:
	jpLevelScene* m_LevelScene;
	bool Initialize();
	bool InitializeParams(jgsParams& params);
	void* PrepareLoadAssets();
	void Destroy();
};

#endif
