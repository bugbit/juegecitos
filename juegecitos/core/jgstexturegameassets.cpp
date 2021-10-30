#include "stdafx.h"
#include "jgsgame.h"
#include "jgsgameassets.h"
#include "stdafx.h"
#include <SDL2/SDL_image.h>

jgsTextureGameAssetData::~jgsTextureGameAssetData()
{
    if(m_Texture != NULL && *m_Texture != NULL)
	SDL_DestroyTexture(*m_Texture);
}

bool jgsTextureGameAssetData::Load(jgsGame& game)
{
    if(m_Texture != NULL)
		if ((*m_Texture = IMG_LoadTexture(game.GetRender2D(), m_File.c_str()))==NULL)
			return game.SetError(std::string("IMG_Load: ") + IMG_GetError() + std::string("\n"));

    return true;
}