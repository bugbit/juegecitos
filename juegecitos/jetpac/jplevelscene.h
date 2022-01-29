#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

#include "jpjetman.h"
#include "jpplatform.h"

// This class captures the closest hit shape.
class MyRayCastCallback : public b2RayCastCallback
{
public:
    MyRayCastCallback()
    {
	m_fixture = NULL;
    }

    float ReportFixture(b2Fixture* fixture, const b2Vec2& point, const b2Vec2& normal, float fraction)
    {
	jgsGameObjB2Body* x = reinterpret_cast<jgsGameObjB2Body*>(fixture->GetBody()->GetUserData().pointer);
	m_fixture = fixture;
	m_point = point;
	m_normal = normal;
	m_fraction = fraction;
	return fraction;
    }

    b2Fixture* m_fixture;
    b2Vec2 m_point;
    b2Vec2 m_normal;
    float m_fraction;
};

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
    jpJetMan* m_Player;

    virtual void InitializeInternal();
    virtual void Destroy();

    inline virtual void UpdateBeforeStep(SDL_Event& e, jgsGameTime& time)
    {
	jgsBox2dScene::UpdateBeforeStep(e, time);
	m_Player->FixedUpdate(e, time);
    }

    inline virtual void UpdateAfterStep(SDL_Event& e, jgsGameTime& time)
    {
	jgsBox2dScene::UpdateAfterStep(e, time);

	// Para saber si el jetman pisa el suelo
	MyRayCastCallback callback;
	b2Vec2 pi = m_Player->GetBody()->GetPosition();
	b2Vec2 pf = b2Vec2(pi.x, pi.y + PixelToMeter(m_Player->GetRect().h));

	m_World->RayCast(&callback, pi, pf);
	m_Player->Update(e, time);
    }
};

#endif
