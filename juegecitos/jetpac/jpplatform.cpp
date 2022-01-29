#include "stdafx.h"
#include "jpplatform.h"
#include "jgsbox2dscene.h"

void jpPlaform::Initialize()
{	
	jgsBox2dScene &scene=(jgsBox2dScene &) m_Scene;

	m_Body = scene.CreateGroundBody(this,m_Rect);
}
