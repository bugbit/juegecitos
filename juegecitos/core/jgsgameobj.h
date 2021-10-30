#ifndef JGSGAMEOBJ_H

#define JGSGAMEOBJ_H

#include "jgsscene.h"

enum jgsGameObjType1 { GameObj, GO_B2Body };

class jgsGameObjType
{
public:
    inline jgsGameObjType(jgsGameObjType1 type1 = GameObj, Uint8 type2 = 0)
        : m_Type1(type1)
        , m_Type2(type2)
    {
    }

    inline jgsGameObjType1 GetType1() const
    {
	return m_Type1;
    }
    inline Uint8 GetType2() const
    {
	return m_Type2;
    }

protected:
    const jgsGameObjType1 m_Type1;
    const Uint8 m_Type2;
};

class jgsGameObj : public jgsGameObjType, jgsInitialize, jgsUpdate
{
public:
    inline jgsGameObj(jgsScene& scene, jgsGameObjType1 type1 = GameObj, Uint8 type2 = 0)
        : jgsGameObjType(type1, type2)
        , m_Scene(scene)
    {
    }

    inline virtual ~jgsGameObj()
    {
    }

    inline virtual void Initialize()
    {
    }

    inline virtual void Update(SDL_Event& e, jgsGameTime& time)
    {
	jgsUpdate::Update(e, time);
    }

protected:
    const jgsScene& m_Scene;
};

class jgsGameObjB2World : jgsGameObj
{
public:
    inline jgsGameObjB2World(jgsScene& scene, Uint8 type2 = 0)
        : jgsGameObj(scene, GO_B2Body, type2)
        , m_World(NULL)
        , m_PixelsPerMeter(1)
    {
	// m_Body->SetUserData(this);
    }

    inline virtual ~jgsGameObjB2World()
    {
	if(m_World != NULL)
	    delete m_World;
    }

    inline virtual void Initialize()
    {
	jgsGameObj::Initialize();
	m_World = InitializeWorld();
    }

    inline virtual void Update(SDL_Event& e, jgsGameTime& time)
    {
	jgsGameObj::Update(e, time);
    }

protected:
    b2World* m_World;
    float m_PixelsPerMeter;

    inline virtual b2World* InitializeWorld()
    {
	return NULL;
    }
};

class jgsGameObjB2Body : jgsGameObj
{
public:
    inline jgsGameObjB2Body(jgsScene& scene, Uint8 type2 = 0)
        : jgsGameObj(scene, GO_B2Body, type2)
        , m_Body(NULL)
    {
    }

    inline virtual ~jgsGameObjB2Body()
    {
    }

    inline virtual void Initialize()
    {
	jgsGameObj::Initialize();
    }
    inline void InitializeBody(jgsGameObjB2World& world)
    {
	m_Body = CreateBody(world);
	m_Body->SetUserData(this);
    }

    inline virtual void Update(SDL_Event& e, jgsGameTime& time)
    {
	jgsGameObj::Update(e, time);
    }

protected:
    b2Body* m_Body;

    inline virtual b2Body* CreateBody(jgsGameObjB2World& world)
    {
	return NULL;
    }
};

#endif