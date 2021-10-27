#ifndef JGSGAMEASSETS_H

#define JGSGAMEASSETS_H

enum jgsGameAssetType
{
    Texture
};

class jgsGame;

class jgsGameAssetData
{
public:
    inline jgsGameAssetData(jgsGameAssetType type, const char *file) : m_Type(type), m_File(file) {}
    inline virtual ~jgsGameAssetData() {}

    virtual void Load(jgsGame &game);

protected:
    jgsGameAssetType m_Type;
    const char *m_File;
    // void *vardata;
    // void *data;
};

class jgsTextureGameAssetData : public jgsGameAssetData
{
public:
    inline jgsTextureGameAssetData(jgsGameAssetType type, const char *file, SDL_Texture **texture) : jgsGameAssetData(type, file)
    {
        m_Texture = texture;
    }
    inline virtual ~jgsTextureGameAssetData()
    {
        if (m_Texture != NULL && *m_Texture != NULL)
            SDL_DestroyTexture(*m_Texture);
    }
    virtual void Load(jgsGame &game);

protected:
    SDL_Texture **m_Texture;
};

class jgsGameAssets
{
public:
    void Add(jgsGameAssetType type, const char *file, void *vardata);
    bool LoadDatas();

private:
    std::vector<jgsGameAssetData *> m_Datas;
};

#endif