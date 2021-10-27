#ifndef JGSGAMEASSETS_H

#define JGSGAMEASSETS_H

enum jgsGameAssetType
{
    Texture
};

typedef struct
{
    jgsGameAssetType type;
    const char *file;
    void *vardata;
    void *data;
} jgsGameAssetData;

class jgsGameAssets
{
    public:
    void Add(jgsGameAssetType type,const char *file,void *vardata);
    bool LoadDatas();
private:
    std::vector<jgsGameAssetData *> m_Datas;
};

#endif