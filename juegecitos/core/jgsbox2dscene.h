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

	inline float PixelToMeter(int p) const
	{
		return p/m_PixelsPerMeter;
	}

	inline float PixelToMeter(float p) const
	{
		return p/m_PixelsPerMeter;
	}

	inline b2Vec2 PixelToMeter(b2Vec2 &pixel) const
	{
		return b2Vec2(PixelToMeter(pixel.x),PixelToMeter(pixel.y));
	}

	inline b2Vec2 MeterToPixel(b2Vec2 &meter) const
	{
		return b2Vec2(meter.x*m_PixelsPerMeter,meter.y*m_PixelsPerMeter);
	}

	inline b2Vec2 CalcPositionCenterBox(SDL_Rect &r) const
	{
		b2Vec2 pos(r.x+r.w/2,r.y+r.h/2);

		return PixelToMeter(pos);
	}

	inline void SetPositionCenterBox(b2BodyDef &body,SDL_Rect &r) const
	{
		b2Vec2 pos=CalcPositionCenterBox(r);

		body.position.Set(pos.x,pos.y);
	}

	b2Body *CreateGroundBody(SDL_Rect &r);

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
