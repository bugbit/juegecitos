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
Date                   :=31/10/21
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
OutputFile             :=../build-$(ConfigurationName)/lib/lib$(ProjectName).a
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E 
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch)../extern/box2d/include/ $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := $(LibrarySwitch)stdc++ $(LibrarySwitch)SDL2 $(LibrarySwitch)SDL2_image 
ArLibs                 :=  "stdc++" "SDL2" "SDL2_image" 
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
CodeLiteDir:=/usr/share/codelite
Objects0=../build-$(ConfigurationName)/core/jgsgame.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/core/jgsgameassets.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/core/jgsscene.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(ObjectSuffix) 



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
../build-$(ConfigurationName)/core/jgsgame.cpp$(ObjectSuffix): jgsgame.cpp ../build-$(ConfigurationName)/core/jgsgame.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgsgame.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgsgame.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgsgame.cpp$(DependSuffix): jgsgame.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgsgame.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgsgame.cpp$(DependSuffix) -MM jgsgame.cpp

../build-$(ConfigurationName)/core/jgsgame.cpp$(PreprocessSuffix): jgsgame.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgsgame.cpp$(PreprocessSuffix) jgsgame.cpp

../build-$(ConfigurationName)/core/jgsgameassets.cpp$(ObjectSuffix): jgsgameassets.cpp ../build-$(ConfigurationName)/core/jgsgameassets.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgsgameassets.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgsgameassets.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgsgameassets.cpp$(DependSuffix): jgsgameassets.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgsgameassets.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgsgameassets.cpp$(DependSuffix) -MM jgsgameassets.cpp

../build-$(ConfigurationName)/core/jgsgameassets.cpp$(PreprocessSuffix): jgsgameassets.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgsgameassets.cpp$(PreprocessSuffix) jgsgameassets.cpp

../build-$(ConfigurationName)/core/jgsscene.cpp$(ObjectSuffix): jgsscene.cpp ../build-$(ConfigurationName)/core/jgsscene.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgsscene.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgsscene.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgsscene.cpp$(DependSuffix): jgsscene.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgsscene.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgsscene.cpp$(DependSuffix) -MM jgsscene.cpp

../build-$(ConfigurationName)/core/jgsscene.cpp$(PreprocessSuffix): jgsscene.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgsscene.cpp$(PreprocessSuffix) jgsscene.cpp

../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(ObjectSuffix): jgstexturegameassets.cpp ../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgstexturegameassets.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgstexturegameassets.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(DependSuffix): jgstexturegameassets.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(DependSuffix) -MM jgstexturegameassets.cpp

../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(PreprocessSuffix): jgstexturegameassets.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgstexturegameassets.cpp$(PreprocessSuffix) jgstexturegameassets.cpp

../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(ObjectSuffix): jgsbox2dscene.cpp ../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/core/jgsbox2dscene.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jgsbox2dscene.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(DependSuffix): jgsbox2dscene.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(DependSuffix) -MM jgsbox2dscene.cpp

../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(PreprocessSuffix): jgsbox2dscene.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/core/jgsbox2dscene.cpp$(PreprocessSuffix) jgsbox2dscene.cpp


-include ../build-$(ConfigurationName)/core//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


