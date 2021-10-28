#include "stdafx.h"
#include "jplevelscene.h"
#include "jpgame.h"

void jpLevelScene::InitializeInternal()
{
    int w, h; // texture width & height

    SDL_QueryTexture(((jpAssetsData *)m_Game.GetAssetsData())->texBase, NULL, NULL, &w, &h); // get the width and height of the texture
    m_RectBase.x=0;
    m_RectBase.y=570-h;
    m_RectBase.w=w;
    m_RectBase.h=h;
}

void jpLevelScene::Render(jgsGameTime &time)
{
    SDL_Rect rect;

    rect.x = 250;
    rect.y = 150;
    rect.w = 200;
    rect.h = 200;

    m_Game.SDL_RenderClear();
    // m_Game.SDL_SetRenderDrawColor( 0, 255, 0, 255);
    // m_Game.SDL_RenderFillRect( &rect);

    // m_Game.SDL_SetRenderDrawColor( 0, 0, 0, 255);

    m_Game.SDL_RenderCopy(((jpAssetsData *)m_Game.GetAssetsData())->texBase, NULL, &m_RectBase);

    m_Game.SDL_RenderPresent();
}