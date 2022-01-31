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

class jpPlaformTransport : public jpPlaformNoRender
{
public:
    inline jpPlaformTransport(jgsBox2dScene& scene, Uint8 type2, SDL_Rect& rect)
        : jpPlaformNoRender(scene, type2, rect)
        , m_IsToTransport(false)
    {
    }

    inline void SetDest(jpPlaformTransport* dest)
    {
	m_Dest = dest;
    }

    inline jpPlaformTransport* GetDest() const
    {
	return m_Dest;
    }

    inline void SetIsToTransport(bool isTo)
    {
	m_IsToTransport = isTo;
    }

    inline bool const IsToTransport() const
    {
	return m_IsToTransport;
    }

private:
    jpPlaformTransport* m_Dest;
    bool m_IsToTransport;
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
