##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Wasm
ProjectName            :=jetpac
ConfigurationName      :=Wasm
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/home/oscar/proyectos/oscar/juegecitos/juegecitos
ProjectPath            :=/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac
IntermediateDirectory  :=../build-$(ConfigurationName)/jetpac
OutDir                 :=../build-$(ConfigurationName)/jetpac
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Oscar
Date                   :=23/10/21
CodeLitePath           :=/home/oscar/.codelite
LinkerName             :=emcc
SharedObjectLinkerName :=
ObjectSuffix           :=.o
DependSuffix           :=.o.d
PreprocessSuffix       :=.i
DebugSwitch            :=-g 
IncludeSwitch          :=-I
LibrarySwitch          :=-l
OutputSwitch           :=-o 
LibraryPathSwitch      :=-L
PreprocessorSwitch     :=-D
SourceSwitch           :=-c 
OutputFile             :=../build-$(ConfigurationName)/bin/$(ProjectName)
Preprocessors          :=$(PreprocessorSwitch)NDEBUG 
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
LinkOptions            :=  -s USE_SDL=2
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch)../core $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := $(LibrarySwitch)core $(LibrarySwitch)stdc++ 
ArLibs                 :=  "core" "stdc++" 
LibPath                := $(LibraryPathSwitch). $(LibraryPathSwitch)$(WorkspacePath)/build-$(WorkspaceConfiguration)/lib 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := emar rcu
CXX      := emcc
CC       := emcc
CXXFLAGS := -Wall -O3 -include pch.h -O2 -Wall $(Preprocessors)
CFLAGS   := -Wall -O3 -include pch.h -O2 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := as


##
## User defined environment variables
##
CodeLiteDir:=/usr/share/codelite
Objects0=../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/jetpac/.d $(Objects) 
	@mkdir -p "../build-$(ConfigurationName)/jetpac"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/jetpac"
	@mkdir -p ""../build-$(ConfigurationName)/bin""

../build-$(ConfigurationName)/jetpac/.d:
	@mkdir -p "../build-$(ConfigurationName)/jetpac"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix): jpgame.cpp ../build-$(ConfigurationName)/jetpac/jpgame.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jpgame.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jpgame.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jpgame.cpp$(DependSuffix): jpgame.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jpgame.cpp$(DependSuffix) -MM jpgame.cpp

../build-$(ConfigurationName)/jetpac/jpgame.cpp$(PreprocessSuffix): jpgame.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jpgame.cpp$(PreprocessSuffix) jpgame.cpp


-include ../build-$(ConfigurationName)/jetpac//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


