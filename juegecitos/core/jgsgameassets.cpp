#include "stdafx.h"
#include "jgsgameassets.h"
#include "jgsgame.h"

bool jgsGameAssets::LoadDatas(jgsGame &game)
{
    for(std::vector<jgsGameAssetData *>::iterator it = std::begin(m_Datas); it != std::end(m_Datas); ++it) {
        if (!(*it)->Load(game))
			return false;
    }
    return true;
}