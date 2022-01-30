#ifndef JPPLAFORM_H

#define JPPLAFORM_H

#include "jgsgameobj.h"
#include "jpgameobjstype.h"

class jpPlaformNoRender : public jgsGameObjB2Body
{
public:
    inline jpPlaformNoRender(jgsBox2dScene& scene, Uint8 type2, SDL_Rect& rect)
        : jgsGameObjB2Body(scene, type2)
        , m_Rect(rect)
    {
    }
    void Initialize();

protected:
    SDL_Rect m_Rect;
};

class jpPlaform : public jpPlaformNoRender, public jgsRender
{
public:
    inline jpPlaform(jgsBox2dScene& scene, SDL_Texture* texture, SDL_Rect& rect, SDL_Rect& rectimgsrc)
        : jpPlaformNoRender(scene, (int)jpGameObjType::jpPlatformType, rect)
        , m_Texture(texture)
        , m_RectImgSrc(rectimgsrc)
    {
    }
    inline void virtual Render(jgsGameTime& time)
    {
	m_Scene.GetGame().SDL_RenderCopy(m_Texture, &m_RectImgSrc, &m_Rect);
    }

private:
    SDL_Texture* m_Texture;
    SDL_Rect m_RectImgSrc;
};

#endif
