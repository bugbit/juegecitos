##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=core
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/home/oscar/proyectos/oscar/juegecitos/juegecitos
ProjectPath            :=/home/oscar/proyectos/oscar/juegecitos/juegecitos/core
IntermediateDirectory  :=../build-$(ConfigurationName)/core
OutDir                 :=../build-$(ConfigurationName)/core
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Oscar
Date                   :=17/10/21
CodeLitePath           :=/home/oscar/.codelite
LinkerName             :=gcc
SharedObjectLinkerName :=gcc -shared -fPIC
ObjectSuffix           :=.o
DependSuffix           :=.o.d
PreprocessSuffix       :=.o.i
DebugSwitch            :=-g 
IncludeSwitch          :=-I
LibrarySwitch          :=-l
OutputSwitch           :=-o 
LibraryPathSwitch      :=-L
PreprocessorSwitch     :=-D
SourceSwitch           :=-c 
OutputFile             :=../build-$(ConfigurationName)/lib/$(ProjectName)
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E 
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := 
ArLibs                 :=  
LibPath                := $(LibraryPathSwitch). 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := ar rcus
CXX      := gcc
CC       := gcc
CXXFLAGS := -O3 -include pch.h -g $(Preprocessors)
CFLAGS   :=  -g $(Preprocessors)
ASFLAGS  := 
AS       := as


##
## User defined environment variables
##
CodeLiteDir:=/usr/share/codelite
Objects0=../build-$(ConfigurationName)/core/jgsGame.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs ../build-$(ConfigurationName)/core/$(OutputFile)

../build-$(ConfigurationName)/core/$(OutputFile): $(Objects)
	@mkdir -p "../build-$(ConfigurationName)/core"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(AR) $(ArchiveOutputSwitch)$(OutputFile) @$(ObjectsFileList)
	@echo rebuilt > $(IntermediateDirectory)/core.relink

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/core"
	@mkdir -p ""../build-$(ConfigurationName)/lib""

:
	@mkdir -p "../build-$(ConfigurationName)/core"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/core/jgsGame.cpp$(ObjectSuffix): jgsGame.cpp ../build-$(ConfigurationName)/core/jgsGame.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgsGame.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgsGame.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgsGame.cpp$(DependSuffix): jgsGame.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgsGame.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgsGame.cpp$(DependSuffix) -MM jgsGame.cpp

../build-$(ConfigurationName)/core/jgsGame.cpp$(PreprocessSuffix): jgsGame.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgsGame.cpp$(PreprocessSuffix) jgsGame.cpp


-include ../build-$(ConfigurationName)/core//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


