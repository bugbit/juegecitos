#include "stdafx.h"
#include "jplevelscene.h"

void jpLevelScene::Render(jgsGameTime &time)
{
    SDL_Rect rect;
    
    rect.x = 250;
    rect.y = 150;
    rect.w = 200;
    rect.h = 200;
    m_Game.SDL_SetRenderDrawColor( 0, 255, 0, 255);
    m_Game.SDL_RenderFillRect( &rect);

    m_Game.SDL_SetRenderDrawColor( 0, 0, 0, 255);

    m_Game.SDL_RenderPresent();
}