#include "stdafx.h"
#include "jgsgameassets.h"
#include "jgsgame.h"

void jgsGameAssetData::Load(jgsGame &game) {}

void jgsTextureGameAssetData::Load(jgsGame &game)
    {
        if (m_Texture != NULL && *m_Texture != NULL)
            *m_Texture = IMG_LoadTexture(game.GetRender2D(), m_File);
    }

void jgsGameAssets::Add(jgsGameAssetType type, const char *file, void *vardata)
{
    // jgsGameAssetData *data = new jgsGameAssetData();

    // data->type = type;
    // data->file = file;
    // data->vardata = vardata;
    // data->data = NULL;
    // m_Datas.push_back(data);
}

bool jgsGameAssets::LoadDatas()
{
    return true;
}