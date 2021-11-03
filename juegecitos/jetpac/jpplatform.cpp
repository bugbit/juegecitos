#include "stdafx.h"
#include "jpplatform.h"

void jpPlaform::Initialize()
{	
	jgsBox2dScene &scene=(jgsBox2dScene &) m_Scene;
	
	m_Body=scene.CreateGroundBody(m_Rect);	
}
