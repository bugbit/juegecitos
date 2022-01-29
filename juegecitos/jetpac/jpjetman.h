#ifndef JPJETMAN_H

#define JPJETMAN_H

#include "jgsbox2dscene.h"
#include "jgsgameobj.h"
#include "jpgameobjstype.h"

class ApplyImpulseToCenter;
class jpJetMan : public jgsGameObjB2Body, public jgsRender
{
public:
    inline jpJetMan(jgsScene& scene, SDL_Texture* texture, SDL_Rect& rect)
        : jgsGameObjB2Body(scene, jpGameObjType::jpJetManType)
        , m_Texture(texture)
        , m_Rect(rect)
        , m_ImpulseJetpac(15 * 0.00001f)
        , m_ImpulseGavity(15 * 0.00001f)
        , m_ImpulseWalk(15 * 0.00001f)
        , m_IsJetPac(false)
        , m_Direction(0)
    {
    }
    void Initialize();

    inline const SDL_Rect& GetRect() const
    {
	return m_Rect;
    }

    inline virtual void FixedUpdate(SDL_Event& e, jgsGameTime& time)
    {
	jgsGameObjB2Body::FixedUpdate(e, time);
	b2Vec2 impulse(
	    m_ImpulseWalk * m_Direction, (m_IsJetPac) ? -m_ImpulseJetpac : m_ImpulseGavity * time.elapsedGameTime);

	m_Body->ApplyLinearImpulseToCenter(impulse, true);
    }

    inline virtual void Update(SDL_Event& e, jgsGameTime& time)
    {
	m_IsJetPac = false;
	m_Direction = 0;
	if(e.type == SDL_KEYDOWN) {
	    if(e.key.keysym.sym == SDLK_UP)
		m_IsJetPac = true;
	    if(e.key.keysym.sym == SDLK_LEFT)
		m_Direction = -1;
	    else if(e.key.keysym.sym == SDLK_RIGHT)
		m_Direction = 1;
	}
    }

    inline void virtual Render(jgsGameTime& time)
    {
	((jgsBox2dScene&)m_Scene).GetPosition(m_Body, m_Desp, m_Rect);
	m_Scene.GetGame().SDL_RenderCopy(m_Texture, NULL, &m_Rect);
    }

private:
    SDL_Texture* m_Texture;
    SDL_Rect m_Rect;
    b2Vec2 m_Desp, m_Impulse;
    float m_ImpulseJetpac, m_ImpulseGavity, m_ImpulseWalk;
    bool m_IsJetPac;
    int m_Direction;
};

#endif
