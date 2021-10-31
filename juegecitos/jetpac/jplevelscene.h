#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

class jpLevelScene : public jgsScene
{
public:
    inline jpLevelScene(jgsGame &game) : jgsScene(game) {}
    void Render(jgsGameTime &time);

protected:
	jgsSpriteRender *m_SpriterBase;

    virtual void InitializeInternal();
	virtual void Destroy();
};

#endif