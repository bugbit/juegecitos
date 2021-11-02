#ifndef JPPLAFORM_H

#define JPPLAFORM_H

#include "jpgameobjstype.h"

class jpPlaform : public jgsGameObjB2Body, public jgsRender
{
public:
    inline jpPlaform(jgsScene& scene)
        : jgsGameObjB2Body(scene, (int)jpGameObjType::jpPlatformType)
    {
    }
	void Initialize();
    inline void virtual Render(jgsGameTime& time)
    {
	m_Render->Render(time);
    }

private:
    jgsB2BodySpriteRender* m_Render;
};

#endif