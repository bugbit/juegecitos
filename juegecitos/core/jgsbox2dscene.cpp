#include "stdafx.h"
#include "jgsbox2dscene.h"

void jgsBox2dScene::Update(SDL_Event& e, jgsGameTime& time)
{
	jgsScene::Update(e,time);
	UpdateBeforeStep(e,time);
	UpdateStep(e,time);
	UpdateAfterStep(e,time);
}