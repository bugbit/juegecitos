#include "jgsbox2dscene.h"
#include "jpjetman.h"
#include "stdafx.h"

float JetManLandCastCallback::ReportFixture(b2Fixture* fixture,
    const b2Vec2& point,
    const b2Vec2& normal,
    float fraction)
{
    jgsGameObj* obj = reinterpret_cast<jgsGameObj*>(fixture->GetBody()->GetUserData().pointer);

    if(obj != NULL && obj->GetType1() == jgsGameObjType1::GO_B2Body &&
        obj->GetType2() == jpGameObjType::jpPlatformType) {
	m_IsLand = true;
    }

    return fraction;
}

void jpJetMan::Initialize()
{
    jgsBox2dScene& scene = (jgsBox2dScene&)m_Scene;

    m_Body = scene.CreateDynamicBody(this, m_Rect, m_Desp, 1.0f, 0);
}
