#include "stdafx.h"
#ifdef __EMSCRIPTEN__
#include <SDL2/SDL_image.h>
#endif
#include "jgsgameassets.h"
#include "jgsgame.h"

jgsTextureGameAssetData::~jgsTextureGameAssetData()
{
    if (m_Texture != NULL && *m_Texture != NULL)
        SDL_DestroyTexture(*m_Texture);
}

void jgsTextureGameAssetData::Load(jgsGame &game)
{
    if (m_Texture != NULL)
        *m_Texture = IMG_LoadTexture(game.GetRender2D(), m_File.c_str());
}