#ifndef JGSBOX2DSCENE_H

#define JGSBOX2DSCENE_H

#include "jgsscene.h"

class jgsBox2dScene : public jgsScene
{
public:
    // Prepare for simulation. Typically we use a time step of 1/60 of a
    // second (60Hz) and 10 iterations. This provides a high quality simulation
    // in most game scenarios.
    inline jgsBox2dScene(jgsGame& game,
        float timeStep = 1.0f / 60.0f,
        int32 velocityIterations = 6,
        int32 positionIterations = 2)
        : jgsScene(game)
        , m_World(NULL)
        , m_PixelsPerMeter(1)
        , m_TimeStep(timeStep)
        , m_VelocityIterations(velocityIterations)
        , m_PositionIterations(positionIterations)
    {
    }

    inline virtual void Destroy()
    {
	jgsScene::Destroy();
	if(m_World != NULL)
	    delete m_World;
    }

    virtual void Update(SDL_Event& e, jgsGameTime& time);

    inline virtual void Render(jgsGameTime& time)
    {
	jgsScene::Render(time);
    }

protected:
    b2World* m_World;
    float m_PixelsPerMeter, m_TimeStep;
    int32 m_VelocityIterations, m_PositionIterations;

    inline virtual b2World* InitializeWorld()
    {
	return NULL;
    }

    inline virtual void UpdateBeforeStep(SDL_Event& e, jgsGameTime& time)
    {
    }
    virtual void UpdateStep(SDL_Event& e, jgsGameTime& time);
    inline virtual void UpdateAfterStep(SDL_Event& e, jgsGameTime& time)
    {
    }
};

#endif