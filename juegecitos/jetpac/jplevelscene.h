#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

class jpLevelScene : public jgsBox2dScene
{
public:
    inline jpLevelScene(jgsGame &game) : jgsBox2dScene(game) {}
    void Render(jgsGameTime &time);

protected:
	jgsSpriteRender *m_SpriterBase;

    virtual void InitializeInternal();
	virtual void Destroy();
};

#endif