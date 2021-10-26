#ifndef JGSSCENE_H

#define JGSSCENE_H

#include "jgsinterface.h"
#include "jgsgame.h"

class jgsGame;

class jgsScene : public jgsInitialize, public jgsRender, public jgsUpdate, public jgsLoop
{
public:
    inline jgsScene(jgsGame &game) : m_Game(game) {}

    inline virtual void Initialize() {}
    void Loop(SDL_Event &e, jgsGameTime &time);

protected:
    jgsGame &m_Game;
};

#endif