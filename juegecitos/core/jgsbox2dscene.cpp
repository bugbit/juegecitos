#include "stdafx.h"
#include "jgsbox2dscene.h"

b2Body *jgsBox2dScene::CreateGroundBody(jgsGameObjB2Body *obj,SDL_Rect &r,float density)
{
	b2BodyDef groundBodyDef;
	float x=PixelToMeter(r.x);
	float y=PixelToMeter(r.y);
	float hx=PixelToMeter(r.w/2);
	float hy=PixelToMeter(r.h/2);

	// Define the ground body.
	groundBodyDef.userData.pointer=reinterpret_cast<uintptr_t>(obj);
	groundBodyDef.position.Set(x+hx,y+hy);

	// Define the ground box shape.
	b2PolygonShape groundBox;

	groundBox.SetAsBox(hx,hy);

	// Call the body factory which allocates memory for the ground body
	// from a pool and creates the ground box shape (also from a pool).
	// The body is also added to the world.
	b2Body *groundBody = m_World->CreateBody(&groundBodyDef);

	// Add the ground fixture to the ground body.
	groundBody->CreateFixture(&groundBox, density);

	return groundBody;
}

b2Body* jgsBox2dScene::CreateDynamicBody(jgsGameObjB2Body *obj,SDL_Rect& r,b2Vec2 &desp,float density, float friction)
{
	b2BodyDef bodyDef;
	float x=PixelToMeter(r.x);
	float y=PixelToMeter(r.y);
	float hx=PixelToMeter(r.w/2);
	float hy=PixelToMeter(r.h/2);

	// Define the dynamic body. We set its position and call the body factory.
	bodyDef.userData.pointer=reinterpret_cast<uintptr_t>(obj);
	bodyDef.type = b2_dynamicBody;
	//SetPositionCenterBox(bodyDef,r);
	bodyDef.position.Set(x+hx,y+hy);

	// Define the ground box shape.
	b2PolygonShape dynamicBox;

	dynamicBox.SetAsBox(hx,hy);

	// Define the dynamic body fixture.
	b2FixtureDef fixtureDef;
	fixtureDef.shape = &dynamicBox;

	// Set the box density to be non-zero, so it will be dynamic.
	fixtureDef.density = density;

	// Override the default friction.
	fixtureDef.friction = friction;

	// Call the body factory which allocates memory for the ground body
	// from a pool and creates the ground box shape (also from a pool).
	// The body is also added to the world.
	b2Body *body = m_World->CreateBody(&bodyDef);

	// Add the shape to the body.
	body->CreateFixture(&fixtureDef);

	desp=b2Vec2(r.w/2,r.h/2);

	return body;
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
