#ifndef JPGAME_H

#define JPGAME_H

#define idx0_texJetman_land 0
#define idx0_texJetman_air 1
#define idx1_texJetman_left 0
#define idx1_texJetman_right 1

// 0 => land, 1=> air; 0=> left, 1=> right
typedef SDL_Texture* texJetmanData[2][2][3];

typedef struct {
    SDL_Texture *texBase, *texPlaform, *texPlaform2;
    texJetmanData texJetman;
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
