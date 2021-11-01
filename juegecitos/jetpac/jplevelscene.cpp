#include "stdafx.h"
#include "jpgame.h"
#include "jplevelscene.h"

void jpLevelScene::InitializeInternal()
{
	// Define the gravity vector.
	b2Vec2 gravity(0.0f, 0.0f);
	
	m_World=new b2World(gravity);
	
    int w, h, ws, hs; // texture width & height
    SDL_Rect m_RectBase, m_RectImgBaseSrc;

    SDL_QueryTexture(((jpAssetsData*)m_Game.GetAssetsData())->texBase, NULL, NULL, &w,
        &h); // get the width and height of the texture
    m_Game.SDL_GetWindowSize(&ws, &hs);
    m_RectImgBaseSrc.x = (w - ws) / 2;
    m_RectImgBaseSrc.y = 0;
    m_RectImgBaseSrc.w = ws;
    m_RectImgBaseSrc.h = h;
    m_RectBase.x = 0;
    m_RectBase.y = hs - h;
    m_RectBase.w = ws;
    m_RectBase.h = h;

    m_SpriterBase = new jgsSpriteRender(
        m_Game.GetRender2D(), ((jpAssetsData*)m_Game.GetAssetsData())->texBase, &m_RectBase, &m_RectImgBaseSrc);
}

void jpLevelScene::Destroy()
{
    if(m_SpriterBase != NULL) {
	delete m_SpriterBase;

	m_SpriterBase = NULL;
    }
}

void jpLevelScene::Render(jgsGameTime& time)
{
    /*SDL_Rect rect;

    rect.x = 250;
    rect.y = 150;
    rect.w = 200;
    rect.h = 200;*/

    m_Game.SDL_RenderClear();
    // m_Game.SDL_SetRenderDrawColor( 0, 255, 0, 255);
    // m_Game.SDL_RenderFillRect( &rect);

    // m_Game.SDL_SetRenderDrawColor( 0, 0, 0, 255);

    // m_Game.SDL_RenderCopy(((jpAssetsData *)m_Game.GetAssetsData())->texBase, &m_RectImgBaseSrc, &m_RectBase);
    m_SpriterBase->Render(time);

    m_Game.SDL_RenderPresent();
}