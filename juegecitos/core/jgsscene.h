#ifndef JGSSCENE_H

#define JGSSCENE_H

#include "jgsinterface.h"
#include "jgsgame.h"

class jgsGame;

class jgsScene : public jgsInitialize, public jgsRender, public jgsUpdate, public jgsLoop
{
public:
    inline jgsScene(jgsGame &game) : m_Game(game), m_IsInit(false) {}

    void Initialize();
    void Loop(SDL_Event &e, jgsGameTime &time);

    inline bool IsInit() const { return m_IsInit; }

protected:
    jgsGame &m_Game;
    bool m_IsInit;

    inline virtual void InitializeInternal() {}
};

#endif