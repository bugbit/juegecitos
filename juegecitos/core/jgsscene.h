#ifndef JGSSCENE_H

#define JGSSCENE_H

#include "jgsgame.h"
#include "jgsinterface.h"

class jgsGame;

class jgsScene : public jgsInitialize, public jgsRender, public jgsUpdate, public jgsLoop
{
public:
    inline jgsScene(jgsGame& game)
        : m_Game(game)
        , m_IsInit(false)
    {
    }

    void Initialize();
    inline virtual void Destroy()
    {
    }
    void Loop(SDL_Event& e, jgsGameTime& time);

    inline bool IsInit() const
    {
	return m_IsInit;
    }

    inline virtual void Update(SDL_Event& e, jgsGameTime& time)
    {
	jgsUpdate::Update(e, time);
    }
    inline virtual void Render(jgsGameTime& time)
    {
	jgsRender::Render(time);
    }

protected:
    jgsGame& m_Game;
    bool m_IsInit;

    inline virtual void InitializeInternal()
    {
    }
};

#endif