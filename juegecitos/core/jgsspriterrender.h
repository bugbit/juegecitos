#ifndef JGSSPRITERRENDER_H

#define JGSSPRITERRENDER_H

#include "jgsinterface.h"
#include <box2d/box2d.h>

class jgsSpriteRenderBase : public jgsRender
{
public:
    inline jgsSpriteRenderBase(SDL_Renderer* render, SDL_Texture* texture, SDL_Rect* rect, SDL_Rect* rectimgsrc)
        : m_Render(render)
        , m_Texture(texture)
    {
	if(rect != NULL) {
	    m_Rect = new SDL_Rect();
	    *m_Rect = *rect;
	} else
	    m_Rect = NULL;
	if(rectimgsrc != NULL) {
	    m_RectImgSrc = new SDL_Rect();
	    *m_RectImgSrc = *rectimgsrc;
	} else
	    m_RectImgSrc = NULL;
    }
    inline virtual ~jgsSpriteRenderBase()
    {
	if(m_Rect)
	    delete m_Rect;
	if(m_RectImgSrc)
	    delete m_RectImgSrc;
    }
    inline virtual void Render(jgsGameTime& time)
    {
	jgsRender::Render(time);
    }

protected:
    SDL_Renderer* m_Render;
    SDL_Texture* m_Texture;
    SDL_Rect *m_Rect, *m_RectImgSrc;
};

class jgsSpriteRender : public jgsSpriteRenderBase
{
public:
    inline jgsSpriteRender(SDL_Renderer* render, SDL_Texture* texture, SDL_Rect* rect, SDL_Rect* rectimgsrc)
        : jgsSpriteRenderBase(render, texture, rect, rectimgsrc)
    {
    }

    inline virtual void Render(jgsGameTime& time)
    {
	SDL_RenderCopy(m_Render, m_Texture, m_RectImgSrc, m_Rect);
    }
};

class jgsB2BodySpriteRender : public jgsSpriteRender
{
public:
    inline jgsB2BodySpriteRender(SDL_Renderer* render, SDL_Texture* texture, SDL_Rect* rect, SDL_Rect* rectimgsrc)
        : jgsSpriteRender(render, texture, rect, rectimgsrc)
    {
	int w, h;

	SDL_QueryTexture(texture, NULL, NULL, &w, &h); // get the width and height of the texture
	m_Desp = b2Vec2(w / 2, h / 2);
    }

    inline void Render(jgsGameTime& time)
    {
	const b2Vec2& pos = m_Body->GetPosition();

	m_Rect->x = pos.x - m_Desp.x;
	m_Rect->y = pos.y - m_Desp.y;
	jgsSpriteRender::Render(time);
    }

private:
    b2Body* m_Body;
    b2Vec2 m_Desp;
};

#endif