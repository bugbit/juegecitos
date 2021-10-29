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
    inline jgsGameAssetData(jgsGameAssetType type, const char *file) : m_Type(type), m_File(std::string("assets/") + file) {}
    inline virtual ~jgsGameAssetData() {}

    virtual bool Load(jgsGame &game) { return true; }

protected:
    jgsGameAssetType m_Type;
    std::string m_File;
    // void *vardata;
    // void *data;
};

class jgsTextureGameAssetData : public jgsGameAssetData
{
public:
    inline jgsTextureGameAssetData(const char *file, SDL_Texture **texture) : jgsGameAssetData(Texture, file)
    {
        m_Texture = texture;
    }
    virtual ~jgsTextureGameAssetData();
    virtual bool Load(jgsGame &game);

protected:
    SDL_Texture **m_Texture;
};

class jgsGameAssets
{
public:
    void Add(const char *file, SDL_Texture **Texture)
    {
        m_Datas.push_back(new jgsTextureGameAssetData(file, Texture));
    }
    bool LoadDatas(jgsGame &game);

private:
    std::vector<jgsGameAssetData *> m_Datas;
};

#endif