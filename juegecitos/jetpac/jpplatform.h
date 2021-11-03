#ifndef JPPLAFORM_H

#define JPPLAFORM_H

#include "jpgameobjstype.h"
#include "jgsbox2dscene.h"

class jpPlaform : public jgsGameObjB2Body, public jgsRender
{
public:
	inline jpPlaform(jgsBox2dScene &scene, SDL_Texture *texture, SDL_Rect &rect, SDL_Rect &rectimgsrc)
		: jgsGameObjB2Body(scene, (int)jpGameObjType::jpPlatformType)
		, m_Texture(texture)
		, m_Rect(rect)
		, m_RectImgSrc(rectimgsrc)
	{
	}
	void Initialize();
	inline void virtual Render(jgsGameTime& time)
	{
		m_Scene.GetGame().SDL_RenderCopy(m_Texture,&m_RectImgSrc,&m_Rect);
	}

private:
	// jgsB2BodySpriteRender* m_Render;
	SDL_Texture* m_Texture;
	SDL_Rect m_Rect, m_RectImgSrc;
};

#endif
