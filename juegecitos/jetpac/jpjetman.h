#ifndef JPJETMAN_H

#define JPJETMAN_H

#include "jgsbox2dscene.h"
#include "jgsgameobj.h"
#include "jpgameobjstype.h"

class jpJetMan;

// This class captures the closest hit shape.
class JetManLandCastCallback : public b2RayCastCallback
{
public:
    JetManLandCastCallback()
        : m_IsLand(false)
    {
    }

    inline bool IsLand() const
    {
	return m_IsLand;
    }

    float ReportFixture(b2Fixture* fixture, const b2Vec2& point, const b2Vec2& normal, float fraction);

private:
    bool m_IsLand;
};

class ApplyImpulseToCenter;
class jpJetMan : public jgsGameObjB2Body, public jgsRender
{
public:
    inline jpJetMan(jgsScene& scene, SDL_Texture* texture, SDL_Rect& rect)
        : jgsGameObjB2Body(scene, jpGameObjType::jpJetManType)
        //, m_LandCB(*this)
        , m_Texture(texture)
        , m_Rect(rect)
        , m_ImpulseJetpac(5)
        , m_ImpulseGavity(15 * 0.01f)
        , m_ImpulseWalk(1)
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

    inline bool const IsJetPac() const
    {
	return m_IsJetPac;
    }

    inline bool IsLand() const
    {
	return m_IsLand;
    }

    inline void SetLand(bool isLand)
    {
	m_IsLand = isLand;
    }

    inline bool IsPosTransp() const
    {
	return m_IsPosTransp;
    }

    inline void SetIsPosTransp(bool isPosTransp)
    {
	m_IsPosTransp = isPosTransp;
    }

    inline const b2Vec2& GetPosTransp() const
    {
	return m_PosTransp;
    }

    inline void SetPosTransp(const b2Vec2& p)
    {
	m_PosTransp = p;
    }

    inline virtual void FixedUpdate(jgsEvents& e, jgsGameTime& time)
    {
	jgsGameObjB2Body::FixedUpdate(e, time);

	if(!m_IsJetPac && m_IsLand)
	    m_IsLand = false;

	/*
	        // Para saber si el jetman pisa el suelo
	        if(!m_IsJetPac) {
	            JetManLandCastCallback cb;
	            b2Vec2 pi = m_Body->GetPosition();
	            b2Vec2 pf = b2Vec2(pi.x, pi.y + Getb2Scene().PixelToMeter(2 + m_Rect.h / 2));

	            m_Body->GetWorld()->RayCast(&cb, pi, pf);
	            m_IsLand = cb.IsLand();
	        } else
	            m_IsLand = false;
	                 */
	/*
if(!m_IsJetPac) {
m_IsLand = false;
for(b2ContactEdge* ce = m_Body->GetContactList(); ce; ce = ce->next) {
b2Contact* c = ce->contact;
jgsGameObj* obj = reinterpret_cast<jgsGameObj*>(c->GetFixtureA()->GetBody()->GetUserData().pointer);

if(c->IsEnabled() && obj != NULL && obj->GetType1() == jgsGameObjType1::GO_B2Body &&
   obj->GetType2() == jpGameObjType::jpPlatformType)
   m_IsLand = true;
}
} else
m_IsLand = false;
*/

	b2Vec2 impulse(m_ImpulseWalk * m_Direction,
	    /*(m_IsLand) ? 0 :*/ (m_IsJetPac) ? -m_ImpulseJetpac : m_ImpulseGavity * time.elapsedGameTime);

	if(m_IsPosTransp) {
	    m_Body->SetTransform(m_PosTransp, 0);
	    m_IsPosTransp = false;
	}
	m_Body->SetLinearVelocity(impulse);
    }

    inline virtual void Update(jgsEvents& e, jgsGameTime& time)
    {
	if(e.IsKeyCode(SDL_KEYUP, SDLK_UP))
	    m_IsJetPac = false;
	else if(e.IsKeyCode(SDL_KEYDOWN, SDLK_UP))
	    m_IsJetPac = true;
	if(e.IsKeyCode(SDL_KEYUP, SDLK_LEFT) || e.IsKeyCode(SDL_KEYUP, SDLK_RIGHT))
	    m_Direction = 0;
	else {
	    if(e.IsKeyCode(SDL_KEYDOWN, SDLK_LEFT))
		m_Direction = -1;
	    if(e.IsKeyCode(SDL_KEYDOWN, SDLK_RIGHT))
		m_Direction = 1;
	}
    }

    inline void virtual Render(jgsGameTime& time)
    {
	Getb2Scene().GetPosition(m_Body, m_Desp, m_Rect);
	m_Scene.GetGame().SDL_RenderCopy(m_Texture, NULL, &m_Rect);
    }

private:
    // JetManLandCastCallback m_LandCB;
    SDL_Texture* m_Texture;
    SDL_Rect m_Rect;
    b2Vec2 m_Desp, m_Impulse, m_PosTransp;
    float m_ImpulseJetpac, m_ImpulseGavity, m_ImpulseWalk;
    bool m_IsJetPac, m_IsLand, m_IsPosTransp;
    int m_Direction;
};

#endif
