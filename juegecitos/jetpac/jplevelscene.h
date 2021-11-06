#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

#include "jpplatform.h"
#include "jpjetman.h"

class jpLevelScene : public jgsBox2dScene
{
public:
	// 86 = sqrt(48²+72²) = dimensiones sprite jetman
	inline jpLevelScene(jgsGame& game)
		: jgsBox2dScene(game, 86)
		, m_PlaformBase(NULL)
		, m_PlaformCenter(NULL)
		, m_PlaformRight(NULL)
	{
	}
	void Render(jgsGameTime& time);

protected:
	jpPlaform *m_PlaformBase, *m_PlaformLeft, *m_PlaformCenter, *m_PlaformRight;
	jpJetMan *m_Player;

	virtual void InitializeInternal();
	virtual void Destroy();
	
	inline virtual void UpdateBeforeStep(SDL_Event& e, jgsGameTime& time)
	{
		jgsBox2dScene::UpdateBeforeStep(e,time);
		m_Player->FixedUpdate(e,time);
	}
};

#endif
