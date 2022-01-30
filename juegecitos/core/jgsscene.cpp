#include "stdafx.h"
#include "jgsscene.h"

void jgsScene::Initialize()
{
    if (!m_IsInit)
    {
        InitializeInternal();
        m_IsInit=true;
    }
}

void jgsScene::Loop(jgsEvents &e, jgsGameTime &time)
{
    Update(e,time);
    Render(time);
}