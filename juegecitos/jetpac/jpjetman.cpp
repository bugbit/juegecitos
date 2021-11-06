#include "stdafx.h"
#include "jpjetman.h"
#include "jgsbox2dscene.h"

void jpJetMan::Initialize()
{
	jgsBox2dScene &scene=(jgsBox2dScene &) m_Scene;

	m_Body= scene.CreateDynamicBody(this,m_Rect,m_Desp);
}
