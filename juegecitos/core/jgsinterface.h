#ifndef JGSINTERFACE_H

#define JGSINTERFACE_H

typedef struct
{
	Uint32 timeStamp, elapsedGameTime;
} jgsGameTime;

class jgsLoop
{
public:
    inline virtual void Loop(SDL_Event &e, jgsGameTime &time)
    {
    }
};

class jgsInitialize
{
public:
	virtual void Initialize() = 0;
    inline virtual void Destroy()=0;
};

class jgsRender
{
public:
	inline virtual void Render(jgsGameTime &time) {}
};

class jgsUpdate
{
public:
	inline virtual void Update(SDL_Event &e, jgsGameTime &time) {}
};

#endif
