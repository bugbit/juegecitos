#include "stdafx.h"
#include "jpgame.h"
#include "jplevelscene.h"

jpGame::jpGame(int argc, char** argv)
    : jgsGame(argc, argv)
{
}

bool jpGame::Initialize()
{
    if(!jgsGame::Initialize())
	return false;

    if((m_LevelScene = new jpLevelScene(*this)) == NULL) {
	m_Error = "not enough memory";

	return false;
    }

    m_MainScene = m_LevelScene;

    return true;
}

void* jpGame::PrepareLoadAssets()
{
    jpAssetsData* assetsData = new jpAssetsData();

    m_Assets.Add("scenery/base.png", &assetsData->texBase);
    m_Assets.Add("scenery/platform.png", &assetsData->texPlaform);
    m_Assets.Add("scenery/platform2.png", &assetsData->texPlaform2);
    memset(assetsData->texJetman, 0, sizeof(assetsData->texJetman));
    m_Assets.Add("jetman/jetman_0_left_0.png", &assetsData->texJetman[idx0_texJetman_land][idx1_texJetman_left][0]);
	m_Assets.Add("jetman/jetman_0_left_1.png", &assetsData->texJetman[idx0_texJetman_land][idx1_texJetman_left][1]);
	m_Assets.Add("jetman/jetman_0_left_2.png", &assetsData->texJetman[idx0_texJetman_land][idx1_texJetman_left][2]);
    m_Assets.Add("jetman/jetman_0_right_0.png", &assetsData->texJetman[idx0_texJetman_land][idx1_texJetman_right][0]);
	m_Assets.Add("jetman/jetman_0_right_1.png", &assetsData->texJetman[idx0_texJetman_land][idx1_texJetman_right][1]);
	m_Assets.Add("jetman/jetman_0_right_2.png", &assetsData->texJetman[idx0_texJetman_land][idx1_texJetman_right][2]);
	m_Assets.Add("jetman/jetman_1_left_0.png", &assetsData->texJetman[idx0_texJetman_air][idx1_texJetman_left][0]);
	m_Assets.Add("jetman/jetman_1_left_1.png", &assetsData->texJetman[idx0_texJetman_air][idx1_texJetman_left][1]);
    m_Assets.Add("jetman/jetman_1_right_0.png", &assetsData->texJetman[idx0_texJetman_air][idx1_texJetman_right][0]);
	m_Assets.Add("jetman/jetman_1_right_1.png", &assetsData->texJetman[idx0_texJetman_air][idx1_texJetman_right][1]);

    return assetsData;
}

void jpGame::Destroy()
{
}

bool jpGame::InitializeParams(jgsParams& params)
{
    jgsGame::InitializeParams(params);
    params.title = "Jetpac";
    params.w = 716;
    params.h = 570;

    return true;
}

int main(int argc, char** argv)
{
    jpGame game(argc, argv);

    return game.Run();
}
