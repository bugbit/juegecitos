#include "stdafx.h"
#include "jgsscene.h"

void jgsScene::Loop(SDL_Event &e, jgsGameTime &time)
{
    Update(e,time);
    Render(time);
}