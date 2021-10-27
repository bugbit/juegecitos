#include "stdafx.h"
#include "jgsgameassets.h"
#include "jgsgame.h"

void jgsGameAssetData::Load(jgsGame &game) {}

bool jgsGameAssets::LoadDatas(jgsGame &game)
{
    for(std::vector<jgsGameAssetData *>::iterator it = std::begin(m_Datas); it != std::end(m_Datas); ++it) {
        (*it)->Load(game);
    }
    return true;
}