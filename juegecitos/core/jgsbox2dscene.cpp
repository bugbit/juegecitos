#include "stdafx.h"
#include "jgsbox2dscene.h"

void jgsBox2dScene::Update(SDL_Event& e, jgsGameTime& time)
{
	jgsScene::Update(e,time);
	UpdateBeforeStep(e,time);
	UpdateStep(e,time);
	UpdateAfterStep(e,time);
}

void jgsBox2dScene::UpdateStep(SDL_Event& e, jgsGameTime& time)
    {
	// Prepare for simulation. Typically we use a time step of 1/60 of a
	// second (60Hz) and 10 iterations. This provides a high quality simulation
	// in most game scenarios.
	m_World->Step(m_TimeStep, m_VelocityIterations, m_PositionIterations);
    }