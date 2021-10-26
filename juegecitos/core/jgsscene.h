#ifndef JGSSCENE_H

#define JGSSCENE_H

#include "jgsinterface.h"
#include "jgsgame.h"

class jgsScene : public jgsInitialize, public jgsRender, public jgsUpdate, public jgsLoop
{
public:
    inline jgsScene(jgsGameTime &game) : m_Game(game) {}

    void Loop(SDL_Event &e, jgsGameTime &time);

protected:
    jgsGameTime &m_Game;
};

#endif