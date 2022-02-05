#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

#include "jpjetman.h"
#include "jpplatform.h"
#include "jpitem.h"

class jpLevelScene : public jgsBox2dScene
{
public:
	// 86 = sqrt(48²+72²) = dimensiones sprite jetman
	inline jpLevelScene(jgsGame& game)
		: jgsBox2dScene(game, 86)
		, m_PlaformBase(NULL)
		, m_PlaformCenter(NULL)
		, m_PlaformRight(NULL)
		, m_Items()
	{
	}
	void Render(jgsGameTime& time);

protected:
	jpPlaform *m_PlaformBase, *m_PlaformLeft, *m_PlaformCenter, *m_PlaformRight;
	jpPlaformNoRender* m_PlaformTop;
	jpPlaformTransport *m_PlaformTranspL, *m_PlaformTranspR;
	jpJetMan* m_Player;
	std::vector<jpItemBase *> m_Items;

	virtual void InitializeInternal();
	virtual void Destroy();

	inline virtual void UpdateBeforeStep(jgsEvents& e, jgsGameTime& time)
	{
		jgsBox2dScene::UpdateBeforeStep(e, time);
		m_Player->FixedUpdate(e, time);
	}

	inline virtual void UpdateAfterStep(jgsEvents& e, jgsGameTime& time)
	{

		jgsBox2dScene::UpdateAfterStep(e, time);
		
		m_Player->Update(e, time);
		for(auto item = m_Items.begin(); item != m_Items.end(); item++) {
		(*item)->Update(e, time);
	}
	}
};

#endif
