#ifndef JGSAPP_H

#define JGSAPP_H

typedef struct {
    float timeStamp, elapsedGameTime;
} jgsGameTime;

class jgsGame;

class jgsLoop
{
public:
    inline virtual void Loop(SDL_Event& e, jgsGameTime& time)
    {
    }
};

class jgsApp
{
public:
	static void ChangeGame(jgsGame *game);
	static void SetMainGame(jgsGame *game);
	static void Run();
private:
    static jgsLoop* m_Loop;
    static jgsGameTime m_Time;
	static jgsGame *m_GameAct;

    static void GameLoop();
};

#endif