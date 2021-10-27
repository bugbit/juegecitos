#include "stdafx.h"
#include "jgsgameassets.h"

void jgsGameAssets::Add(jgsGameAssetType type, const char *file, void *vardata)
{
    jgsGameAssetData *data = new jgsGameAssetData();

    data->type = type;
    data->file = file;
    data->vardata = vardata;
    data->data = NULL;
    m_Datas.push_back(data);
}

bool jgsGameAssets::LoadDatas()
{
    return true;
}