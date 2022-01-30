#ifndef JGSINTERFACE_H

#define JGSINTERFACE_H

typedef struct {
    Uint32 timeStamp, elapsedGameTime;
} jgsGameTime;

typedef struct {
    SDL_Event events[20];
    int numEvents;

    inline bool IsType(Uint32 type)
    {
	int n = numEvents;

	for(SDL_Event* e = events; n-- > 0; e++)
	    if(e->type == type)
		return true;

	return false;
    }
    inline bool IsKeyCode(Uint32 type, SDL_Keycode keycode)
    {
	int n = numEvents;

	for(SDL_Event* e = events; n-- > 0; e++)
	    if(e->type == type && e->key.keysym.sym == keycode)
		return true;

	return false;
    }
} jgsEvents;

class jgsLoop
{
public:
    inline virtual void Loop(jgsEvents & e, jgsGameTime& time)
    {
    }
};

class jgsInitialize
{
public:
    virtual void Initialize() = 0;
    inline virtual void Destroy() = 0;
};

class jgsRender
{
public:
    inline virtual void Render(jgsGameTime& time)
    {
    }
};

class jgsUpdate
{
public:
    inline virtual void Update(jgsEvents & e, jgsGameTime& time)
    {
    }
};

#endif
