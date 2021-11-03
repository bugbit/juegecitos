#include "stdafx.h"
#include "jgsbox2dscene.h"

b2Body *jgsBox2dScene::CreateGroundBody(SDL_Rect &r)
{
	b2BodyDef groundBodyDef;

	// Define the ground body.
	SetPositionCenterBox(groundBodyDef,r);

	// Define the ground box shape.
	b2PolygonShape groundBox;
	
	groundBox.SetAsBox(PixelToMeter(r.w),PixelToMeter(r.h));

	// Call the body factory which allocates memory for the ground body
	// from a pool and creates the ground box shape (also from a pool).
	// The body is also added to the world.
	b2Body *groundBody = m_World->CreateBody(&groundBodyDef);

	// Add the ground fixture to the ground body.
	groundBody->CreateFixture(&groundBox, 0.0f);

	return groundBody;
}

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
