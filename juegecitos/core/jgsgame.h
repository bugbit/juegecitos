#ifndef __JGS_GAME__H

#define	__JGS_GAME__H

#include "jgsparams.h"
#include "jgsinterface.h"

class jgsGame : public jgsInitialize
{
public:
	inline jgsGame():m_Params() {}
	void Run();
protected:
	jgsParams m_Params;
	
	virtual inline void Initialize() {}
	virtual void InitializeParams();
};

#endif