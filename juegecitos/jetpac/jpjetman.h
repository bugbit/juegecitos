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
        , m_ImpulseJetpac(15 * 0.01f)
        , m_ImpulseGavity(15 * 0.01f)
        , m_ImpulseWalk(0.9)
        , m_IsJetPac(false)
        , m_IsLand(false)
        , m_Direction(0)
    {
    }
    void Initialize();

    inline const SDL_Rect& GetRect() const
    {
	return m_Rect;
    }

    inline bool IsLand() const
    {
	return m_IsLand;
    }

    inline void SetLand(bool isLand)
    {
	m_IsLand = isLand;
    }

    inline virtual void FixedUpdate(SDL_Event& e, jgsGameTime& time)
    {
	jgsGameObjB2Body::FixedUpdate(e, time);
	b2Vec2 impulse(m_ImpulseWalk * m_Direction,
	    (m_IsLand) ? 0 : (m_IsJetPac) ? -m_ImpulseJetpac : m_ImpulseGavity * time.elapsedGameTime);

	// m_Body->ApplyLinearImpulseToCenter(impulse, true);
	m_Body->SetLinearVelocity(impulse);
    }

    inline virtual void Update(SDL_Event& e, jgsGameTime& time)
    {
	switch(e.type) {
	case SDL_KEYDOWN:
	    switch(e.key.keysym.sym) {
	    case SDLK_UP:
		m_IsJetPac = true;
		break;
	    case SDLK_LEFT:
		m_Direction = -1;
		break;
	    case SDLK_RIGHT:
		m_Direction = 1;
		break;
	    }
	    break;
	case SDL_KEYUP:
	    switch(e.key.keysym.sym) {
	    case SDLK_UP:
		m_IsJetPac = false;
		break;
	    case SDLK_LEFT:
	    case SDLK_RIGHT:
		m_Direction = 0;
	    }
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
    bool m_IsJetPac, m_IsLand;
    int m_Direction;
};

#endif
