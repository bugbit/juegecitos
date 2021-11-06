#include "stdafx.h"
#include "jpgame.h"

jpGame::jpGame(int argc, char **argv) : jgsGame(argc, argv)
{
}

bool jpGame::Initialize()
{
	if (!jgsGame::Initialize())
		return false;

	if ((m_LevelScene = new jpLevelScene(*this)) == NULL) {
		m_Error = "not enough memory";

		return false;
	}

	m_MainScene = m_LevelScene;

	return true;
}

void *jpGame::PrepareLoadAssets()
{
	jpAssetsData *assetsData = new jpAssetsData();

	m_Assets.Add("scenery/base.png", &assetsData->texBase);
	m_Assets.Add("scenery/platform.png", &assetsData->texPlaform);
	m_Assets.Add("scenery/platform2.png", &assetsData->texPlaform2);
	m_Assets.Add("jetman/jetman_0_left_0.png", &assetsData->texJetman);

	return assetsData;
}

void jpGame::Destroy()
{
}

bool jpGame::InitializeParams(jgsParams &params)
{
	jgsGame::InitializeParams(params);
	params.title = "Jetpac";
	params.w = 716;
	params.h = 570;

	return true;
}

int main(int argc, char **argv)
{
	jpGame game(argc, argv);

	return game.Run();
}
