#include "stdafx.h"
#include "jpgame.h"
#include "jplevelscene.h"

void jpLevelScene::InitializeInternal()
{
	// Define the gravity vector.
	b2Vec2 gravity(0.0f, 0.0f);

	m_World = new b2World(gravity);

	int w, h, ws, hs; // texture width & height
	SDL_Rect rect, rectsrc;
	jpAssetsData *pAssetsData=(jpAssetsData*)m_Game.GetAssetsData();

	SDL_QueryTexture(pAssetsData->texBase, NULL, NULL, &w,&h); // get the width and height of the texture
	m_Game.SDL_GetWindowSize(&ws, &hs);
	rectsrc.x = (w - ws) / 2;
	rectsrc.y = 0;
	rectsrc.w = ws;
	rectsrc.h = h;
	rect.x = 0;
	rect.y = hs - h;
	rect.w = ws;
	rect.h = h;
	m_Game.SDL_GetWindowSize(&ws, &hs);

	m_PlaformBase=new jpPlaform(*this,pAssetsData->texBase, rect, rectsrc);

	SDL_QueryTexture(pAssetsData->texPlaform2, NULL, NULL, &w,&h); // get the width and height of the texture

	rectsrc.x = 0;
	rectsrc.y = 0;
	rectsrc.w = w;
	rectsrc.h = h;
	rect.x = 90;
	rect.y = 200;
	rect.w = w;
	rect.h = h;

	m_PlaformLeft=new jpPlaform(*this,pAssetsData->texPlaform2, rect, rectsrc);

	rect.x = 530;
	rect.y = 140;
	rect.w = w;
	rect.h = h;

	m_PlaformRight=new jpPlaform(*this,pAssetsData->texPlaform2, rect, rectsrc);

	SDL_QueryTexture(pAssetsData->texPlaform, NULL, NULL, &w,&h); // get the width and height of the texture

	rectsrc.x = 0;
	rectsrc.y = 0;
	rectsrc.w = w;
	rectsrc.h = h;
	rect.x = 330;
	rect.y = 330;
	rect.w = w;
	rect.h = h;

	m_PlaformCenter=new jpPlaform(*this,pAssetsData->texPlaform, rect, rectsrc);
}

void jpLevelScene::Destroy()
{
	if(m_PlaformBase != NULL) {
		m_PlaformBase->Destroy();
		delete m_PlaformBase;

		m_PlaformBase = NULL;
	}
	if(m_PlaformLeft != NULL) {
		m_PlaformLeft->Destroy();
		delete m_PlaformLeft;

		m_PlaformLeft = NULL;
	}
	if(m_PlaformCenter != NULL) {
		m_PlaformCenter->Destroy();
		delete m_PlaformCenter;

		m_PlaformCenter = NULL;
	}
	if(m_PlaformRight != NULL) {
		m_PlaformRight->Destroy();
		delete m_PlaformRight;

		m_PlaformRight = NULL;
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
	m_PlaformBase->Render(time);
	m_PlaformLeft->Render(time);
	m_PlaformCenter->Render(time);
	m_PlaformRight->Render(time);

	m_Game.SDL_RenderPresent();
}
