#ifndef JPITEM_H

#define JPITEM_H

#include "jgsbox2dscene.h"
#include "jgsgameobj.h"
#include "jpgameobjstype.h"

class jpItemBase : public jgsGameObjB2Body, public jgsRender
{
public:
    inline jpItemBase(jgsBox2dScene& scene, Uint8 type2, SDL_Texture* texture, SDL_Rect& rect)
        : jgsGameObjB2Body(scene, type2)
        , m_Texture(texture)
        , m_Rect(rect)
    {
    }

    void Initialize();

    inline void virtual Render(jgsGameTime& time)
    {
	Getb2Scene().GetPosition(m_Body, m_Desp, m_Rect);
	m_Scene.GetGame().SDL_RenderCopy(m_Texture, NULL, &m_Rect);
    }

private:
    SDL_Texture* m_Texture;
    SDL_Rect m_Rect;
    b2Vec2 m_Desp;
};

class jpRocketItem : public jpItemBase
{
public:
    inline jpRocketItem(jgsBox2dScene& scene, SDL_Texture* texture, SDL_Rect& rect)
        : jpItemBase(scene, jpGameObjType::jpItemRocket, texture, rect)
    {
    }
};

#endif