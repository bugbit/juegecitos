#ifndef JPJETMAN_H

#define JPJETMAN_H

#include "jgsbox2dscene.h"
#include "jgsgameobj.h"
#include "jpgame.h"
#include "jpgameobjstype.h"

class ApplyImpulseToCenter;
class jpJetMan : public jgsGameObjB2Body, public jgsRender
{
public:
    inline jpJetMan(jgsScene& scene, texJetmanData& textures, SDL_Rect& rect)
        : jgsGameObjB2Body(scene, jpGameObjType::jpJetManType)
        //, m_LandCB(*this)
        , m_Textures(textures)
        , m_Texture(textures[0][0][0])
        , m_Rect(rect)
		,m_IsPosTransp(false)
		,m_PosTransp(0,0)
        , m_ImpulseJetpac(5* 0.1f)
        , m_ImpulseGavity(5 * 0.1f)
        , m_ImpulseWalk(1* 0.1f)
        , m_TimeActFrame(0)
        , m_TimeFrame(43)
        , m_IsJetPac(false)
        , m_IsLand(false)
        , m_Direction(0)
        , m_Idx1(0)
        , m_Idx2(0)
        , m_Idx3(0)
        , m_NumFrame(0)
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
	m_Idx1 = (isLand) ? idx0_texJetman_land : idx0_texJetman_air;
	m_ChangeTexture = true;
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

	b2Vec2 impulse(m_ImpulseWalk * m_Direction* time.elapsed,
	    /*(m_IsLand) ? 0 :*/ ((m_IsJetPac) ? -m_ImpulseJetpac : m_ImpulseGavity) * time.elapsed);

	if(m_IsPosTransp) {
	    m_Body->SetTransform(m_PosTransp, 0);
	    m_IsPosTransp = false;
	}
	m_Body->SetLinearVelocity(impulse);
    }

    inline virtual void Update(jgsEvents& e, jgsGameTime& time)
    {
	if(e.IsKeyCode(SDL_KEYUP, SDLK_UP)) {
	    m_IsJetPac = false;
	} else if(e.IsKeyCode(SDL_KEYDOWN, SDLK_UP)) {
	    m_IsJetPac = true;
	}
	if(e.IsKeyCode(SDL_KEYUP, SDLK_LEFT) || e.IsKeyCode(SDL_KEYUP, SDLK_RIGHT)) {
	    m_Direction = 0;
	} else {
	    if(e.IsKeyCode(SDL_KEYDOWN, SDLK_LEFT)) {
		m_Direction = -1;
	    }
	    if(e.IsKeyCode(SDL_KEYDOWN, SDLK_RIGHT)) {
		m_Direction = 1;
	    }
	}
	m_Idx1 = (m_IsLand) ? idx0_texJetman_land : idx0_texJetman_air;
	if(m_Direction != 0)
	    m_Idx2 = (m_Direction > 0) ? idx1_texJetman_right : idx1_texJetman_left;
	if(m_IsJetPac || m_Direction != 0) {
	    m_TimeActFrame += time.elapsed;
	    if(m_TimeActFrame > m_TimeFrame) {
		m_TimeActFrame -= m_TimeFrame;
		m_ChangeTexture = true;
		if(!m_IsLand) {
		    m_NumFrame = (m_NumFrame + 1) % 2;
		    m_Idx3 = m_NumFrame;
		} else {
		    m_NumFrame = (m_NumFrame + 1) % 4;
		    m_Idx3 = m_LandNumFrameToIdx3[m_NumFrame];
		}
	    }
	} else
	    m_Idx3 = m_TimeActFrame = 0;
	SDL_Texture* t = m_Textures[m_Idx1][m_Idx2][m_Idx3];
	if(t != NULL)
	    m_Texture = t;
    }

    inline void virtual Render(jgsGameTime& time)
    {
	Getb2Scene().GetPosition(m_Body, m_Desp, m_Rect);
	m_Scene.GetGame().SDL_RenderCopy(m_Texture, NULL, &m_Rect);
    }

private:
    static const int m_LandNumFrameToIdx3[];
    // JetManLandCastCallback m_LandCB;
    texJetmanData& m_Textures;
    SDL_Texture* m_Texture;
    SDL_Rect m_Rect;
    b2Vec2 m_Desp, m_Impulse, m_PosTransp;
    float m_ImpulseJetpac, m_ImpulseGavity, m_ImpulseWalk;
    uint32 m_TimeActFrame, m_TimeFrame;
    bool m_IsJetPac, m_IsLand, m_IsPosTransp, m_ChangeTexture;
    int m_Direction, m_Idx1, m_Idx2, m_Idx3, m_NumFrame;
};

#endif
