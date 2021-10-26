#ifndef JPLEVELSCENE_h

#define JPLEVELSCENE_h

class jpLevelScene : public jgsScene
{
public:
    inline jpLevelScene(jgsGame &game) : jgsScene(game) {}
    void Render(jgsGameTime &time);
};

#endif