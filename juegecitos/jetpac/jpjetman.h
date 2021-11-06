#ifndef JPJETMAN_H

#define JPJETMAN_H

#include "jpgameobjstype.h"
#include "jgsgameobj.h"
#include "jgsbox2dscene.h"

class jpJetMan : public jgsGameObjB2Body, public jgsRender
{
public:
	inline jpJetMan(jgsScene& scene, SDL_Texture* texture, SDL_Rect& rect)
		: jgsGameObjB2Body(scene, jpGameObjType::jpJetManType)
		, m_Texture(texture)
		, m_Rect(rect),m_ImpulseJetpac(60*0.00001f),m_ImpulseGavity(60*0.00001f),m_ImpulseWalk(60*0.00001f)
	{
	}
	void Initialize();

	inline virtual void FixedUpdate(SDL_Event& e, jgsGameTime& time)
	{
		jgsGameObjB2Body::FixedUpdate(e,time);
		b2Vec2 impulse(0,-60*0.00001f*time.elapsedGameTime);

		m_Body->ApplyLinearImpulseToCenter(impulse,true);
	}

	inline void virtual Render(jgsGameTime& time)
	{
		((jgsBox2dScene &) m_Scene).GetPosition(m_Body,m_Desp,m_Rect);
		m_Scene.GetGame().SDL_RenderCopy(m_Texture, NULL, &m_Rect);
	}

private:
	SDL_Texture* m_Texture;
	SDL_Rect m_Rect;
	b2Vec2 m_Desp,m_Impulse;
	float m_ImpulseJetpac,m_ImpulseGavity,m_ImpulseWalk;
};

#endif
