#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

#include "jpplatform.h"

class jpLevelScene : public jgsBox2dScene
{
public:
	inline jpLevelScene(jgsGame &game) : jgsBox2dScene(game),m_PlaformBase(NULL),m_PlaformCenter(NULL),m_PlaformRight(NULL) {}
	void Render(jgsGameTime &time);

protected:
	jpPlaform *m_PlaformBase,*m_PlaformLeft,*m_PlaformCenter,*m_PlaformRight;

	virtual void InitializeInternal();
	virtual void Destroy();
};

#endif
