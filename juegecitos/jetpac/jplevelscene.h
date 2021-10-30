#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

class jpLevelScene : public jgsBox2dScene
{
public:
    inline jpLevelScene(jgsGame &game) : jgsBox2dScene(game) {}
    void Render(jgsGameTime &time);

protected:
    SDL_Rect m_RectBase,m_RectImgBaseSrc;

    virtual void InitializeInternal();
};

#endif