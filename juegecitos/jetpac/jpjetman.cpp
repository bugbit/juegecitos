#include "stdafx.h"
#include "jgsbox2dscene.h"
#include "jpjetman.h"

const int jpJetMan::m_LandNumFrameToIdx3[] = { 0, 2, 1, 2 };

void jpJetMan::Initialize()
{
    jgsBox2dScene& scene = (jgsBox2dScene&)m_Scene;

    m_Body = scene.CreateDynamicBody(this, m_Rect, m_Desp, 1.0f, 0);
}
