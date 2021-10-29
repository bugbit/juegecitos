#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

class jpLevelScene : public jgsScene
{
public:
    inline jpLevelScene(jgsGame &game) : jgsScene(game) {}
    void Render(jgsGameTime &time);

protected:
    SDL_Rect m_RectBase,m_RectImgBaseSrc;

    virtual void InitializeInternal();
};

#endif