#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

#include "jpjetman.h"
#include "jpplatform.h"

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
    jpPlaformNoRender* m_PlaformTop,  *m_PlaformTranspL,*m_PlaformTranspR;
    jpJetMan* m_Player;

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
	/*
	                // Para saber si el jetman pisa el suelo
	                MyRayCastCallback callback;
	                b2Vec2 pi = m_Player->GetBody()->GetPosition();
	                b2Vec2 pf = b2Vec2(pi.x, pi.y + PixelToMeter(m_Player->GetRect().h));

	                m_World->RayCast(&callback, pi, pf);
	                 */
	m_Player->Update(e, time);
    }
};

#endif
