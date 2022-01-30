#include "jpgame.h"
#include "jplevelscene.h"
#include "stdafx.h"

class jpContactListener : public b2ContactListener
{
public:
    void BeginContact(b2Contact* c)
    {
	b2Body* bA = c->GetFixtureA()->GetBody();
	b2Body* bB = c->GetFixtureB()->GetBody();
	jgsGameObj* objA = reinterpret_cast<jgsGameObj*>(bA->GetUserData().pointer);
	jgsGameObj* objB = reinterpret_cast<jgsGameObj*>(bB->GetUserData().pointer);

	if(objA == NULL || objA->GetType1() != jgsGameObjType1::GO_B2Body || objB == NULL ||
	    objB->GetType1() != jgsGameObjType1::GO_B2Body)
	    return;

	const b2Vec2& vA = bA->GetPosition();
	const b2Vec2& vB = bB->GetPosition();
	jpJetMan* objJM;
	jpPlaformTransport* objPT;

	// is jetman contact
	if(objB->GetType2() == jpGameObjType::jpJetManType) {
	    objJM = (jpJetMan*)objB;

	    // jetman is land
	    if(objA->GetType2() == jpGameObjType::jpPlatformType) {
		if(vB.y < vA.y) {

		    objJM->SetLand(!objJM->IsJetPac());
		}
	    } else if(objA->GetType2() == jpGameObjType::jpPlatformTransportLType) {
		objPT = (jpPlaformTransport*)objA;
		objJM->SetPosTransp(objPT->GetDest()->GetBody()->GetPosition());
		objJM->SetIsPosTransp(true);
	    }
	}
    }

    void EndContact(b2Contact* contact)
    {
	/* handle end event */
    }

    void PreSolve(b2Contact* contact, const b2Manifold* oldManifold)
    {
	/* handle pre-solve event */
	// contact->SetEnabled(false);
    }

    void PostSolve(b2Contact* contact, const b2ContactImpulse* impulse)
    {
	/* handle post-solve event */
    }
};

void jpLevelScene::InitializeInternal()
{
    // Define the gravity vector.
    b2Vec2 gravity(0.0f, 0.0f);

    m_World = new b2World(gravity);

    int w, h, ws, hs; // texture width & height
    int wh;
    SDL_Rect rect, rectsrc;
    jpAssetsData* pAssetsData = (jpAssetsData*)m_Game.GetAssetsData();

    SDL_QueryTexture(pAssetsData->texBase, NULL, NULL, &w, &h); // get the width and height of the texture
    m_Game.SDL_GetWindowSize(&ws, &hs);
    wh = (w - ws) / 2;
    // rectsrc.x = (w - ws) / 2;
    rectsrc.x = 0;
    rectsrc.y = 0;
    rectsrc.w = ws;
    rectsrc.h = h;
    rect.x = -wh;
    rect.y = hs - h;
    // rect.w = ws;
    rect.w = w;
    rect.h = h;
    m_Game.SDL_GetWindowSize(&ws, &hs);

    m_PlaformBase = new jpPlaform(*this, pAssetsData->texBase, rect, rectsrc);
    m_PlaformBase->Initialize();

    rect.y = -h;

    m_PlaformTop = new jpPlaformNoRender(*this, (int)jpGameObjType::jpPlatformTopType, rect);
    m_PlaformTop->Initialize();

    rect.x = -2 * wh;
    rect.y = 0;
    rect.w = wh;
    rect.h = hs;

    m_PlaformTranspL = new jpPlaformTransport(*this, (int)jpGameObjType::jpPlatformTransportLType, rect);
    m_PlaformTranspL->Initialize();

    rect.x = ws + wh;
    rect.y = 0;

    m_PlaformTranspR = new jpPlaformTransport(*this, (int)jpGameObjType::jpPlatformTransportRType, rect);
    m_PlaformTranspR->Initialize();

    m_PlaformTranspL->SetDest(m_PlaformTranspR);
    m_PlaformTranspR->SetDest(m_PlaformTranspL);

    SDL_QueryTexture(pAssetsData->texPlaform2, NULL, NULL, &w, &h); // get the width and height of the texture

    rectsrc.x = 0;
    rectsrc.y = 0;
    rectsrc.w = w;
    rectsrc.h = h;
    rect.x = 90;
    rect.y = 200;
    rect.w = w;
    rect.h = h;

    m_PlaformLeft = new jpPlaform(*this, pAssetsData->texPlaform2, rect, rectsrc);
    m_PlaformLeft->Initialize();

    rect.x = 530;
    rect.y = 140;
    rect.w = w;
    rect.h = h;

    m_PlaformRight = new jpPlaform(*this, pAssetsData->texPlaform2, rect, rectsrc);
    m_PlaformRight->Initialize();

    SDL_QueryTexture(pAssetsData->texPlaform, NULL, NULL, &w, &h); // get the width and height of the texture

    rectsrc.x = 0;
    rectsrc.y = 0;
    rectsrc.w = w;
    rectsrc.h = h;
    rect.x = 330;
    rect.y = 330;
    rect.w = w;
    rect.h = h;

    m_PlaformCenter = new jpPlaform(*this, pAssetsData->texPlaform, rect, rectsrc);
    m_PlaformCenter->Initialize();

    SDL_QueryTexture(pAssetsData->texJetman, NULL, NULL, &w, &h); // get the width and height of the texture

    rect.x = 350;
    rect.y = 458;
    rect.w = w;
    rect.h = h;

    m_Player = new jpJetMan(*this, pAssetsData->texJetman, rect);
    m_Player->Initialize();

    m_World->SetContactListener(new jpContactListener());
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

    if(m_PlaformTop != NULL) {
	m_PlaformTop->Destroy();
	delete m_PlaformTop;

	m_PlaformTop = NULL;
    }

    if(m_PlaformTranspL != NULL) {
	m_PlaformTranspL->Destroy();
	delete m_PlaformTranspL;

	m_PlaformTranspL = NULL;
    }

    if(m_PlaformTranspR != NULL) {
	m_PlaformTranspR->Destroy();
	delete m_PlaformTranspR;

	m_PlaformTranspR = NULL;
    }

    if(m_Player != NULL) {
	m_Player->Destroy();
	delete m_Player;

	m_Player = NULL;
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
    m_Player->Render(time);

    m_Game.SDL_RenderPresent();
}
