##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=libcore
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
Date                   :=10/23/21
CodeLitePath           :=
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
OutputFile             :=../build-$(ConfigurationName)/lib/lib$(ProjectName).so
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
Libs                   := $(LibrarySwitch)stdc++ $(LibrarySwitch)SDL2 
ArLibs                 :=  "stdc++" "SDL2" 
LibPath                := $(LibraryPathSwitch). 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := ar rcus
CXX      := gcc
CC       := gcc
CXXFLAGS := -Wall -O3 -include pch.h -g $(Preprocessors)
CFLAGS   := -Wall -O3 -include pch.h -g $(Preprocessors)
ASFLAGS  := 
AS       := as


##
## User defined environment variables
##
Objects0=../build-$(ConfigurationName)/core/jgsgame.cpp$(ObjectSuffix) 



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
	@echo rebuilt > $(IntermediateDirectory)/libcore.relink

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/core"
	@mkdir -p ""../build-$(ConfigurationName)/lib""

:
	@mkdir -p "../build-$(ConfigurationName)/core"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/core/jgsgame.cpp$(ObjectSuffix): jgsgame.cpp ../build-$(ConfigurationName)/core/jgsgame.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgsgame.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgsgame.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgsgame.cpp$(DependSuffix): jgsgame.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgsgame.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgsgame.cpp$(DependSuffix) -MM jgsgame.cpp

../build-$(ConfigurationName)/core/jgsgame.cpp$(PreprocessSuffix): jgsgame.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgsgame.cpp$(PreprocessSuffix) jgsgame.cpp


-include ../build-$(ConfigurationName)/core//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


