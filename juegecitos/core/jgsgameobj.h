#ifndef JGSGAMEOBJ_H

#define JGSGAMEOBJ_H

#include "jgsscene.h"

enum jgsGameObjType1 { GameObj, GO_B2Body };

class jgsGameObjType
{
public:
    inline jgsGameObjType(jgsGameObjType1 type1 = GameObj,
        Uint8 type2 = 0,
        bool isupdate = false,
        bool isrender = false)
        : m_Type1(type1)
        , m_Type2(type2)
        , m_IsUpdate(isupdate)
        , m_IsRender(isrender)
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
    const bool m_IsUpdate, m_IsRender;
};

class jgsGameObj : public jgsGameObjType, public jgsInitialize
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
    inline virtual void Destroy()
    {
    }

protected:
    const jgsScene& m_Scene;
};

class jgsGameObjB2Body : public jgsGameObj, public jgsUpdate
{
public:
    inline jgsGameObjB2Body(jgsScene& scene, Uint8 type2 = 0)
        : jgsGameObj(scene, GO_B2Body, type2)
        , m_Body(NULL)
    {
    }

    inline b2Body* GetBody() const
    {
	return m_Body;
    }

    inline jgsBox2dScene& Getb2Scene() const
    {
	return (jgsBox2dScene&)m_Scene;
    }

    inline virtual ~jgsGameObjB2Body()
    {
    }

    inline virtual void Initialize()
    {
	jgsGameObj::Initialize();
    }
    inline virtual void Destroy()
    {
	jgsGameObj::Destroy();
    }

    inline virtual void FixedUpdate(jgsEvents& e, jgsGameTime& time)
    {
    }

    inline virtual void Update(jgsEvents& e, jgsGameTime& time)
    {
	jgsUpdate::Update(e, time);
    }

protected:
    b2Body* m_Body;
};

#endif
