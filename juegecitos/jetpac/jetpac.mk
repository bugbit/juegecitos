##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=jetpac
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/home/oscar/proyectos/oscar/juegecitos/juegecitos
ProjectPath            :=/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac
IntermediateDirectory  :=../build-$(ConfigurationName)/jetpac
OutDir                 :=../build-$(ConfigurationName)/jetpac
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Oscar
Date                   :=29/01/22
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
OutputFile             :=../build-$(ConfigurationName)/bin/$(ProjectName)
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E 
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch)../extern/box2d/include/ $(IncludeSwitch)../core $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := $(LibrarySwitch)core $(LibrarySwitch)box2d $(LibrarySwitch)stdc++ $(LibrarySwitch)m $(LibrarySwitch)SDL2 $(LibrarySwitch)SDL2_image 
ArLibs                 :=  "core" "box2d" "stdc++" "m" "SDL2" "SDL2_image" 
LibPath                := $(LibraryPathSwitch). $(LibraryPathSwitch)$(WorkspacePath)/build-$(WorkspaceConfiguration)/lib 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := ar rcus
CXX      := gcc
CC       := gcc
CXXFLAGS := -Wall -O3 -include pch.h -g -O0 -Wall $(Preprocessors)
CFLAGS   := -Wall -O3 -include pch.h -g -O0 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := as


##
## User defined environment variables
##
CodeLiteDir:=/usr/share/codelite
Objects0=../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(ObjectSuffix) 



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
../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(ObjectSuffix): jpjetman.cpp ../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jpjetman.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jpjetman.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(DependSuffix): jpjetman.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(DependSuffix) -MM jpjetman.cpp

../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(PreprocessSuffix): jpjetman.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jpjetman.cpp$(PreprocessSuffix) jpjetman.cpp

../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix): jpgame.cpp ../build-$(ConfigurationName)/jetpac/jpgame.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jpgame.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jpgame.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jpgame.cpp$(DependSuffix): jpgame.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jpgame.cpp$(DependSuffix) -MM jpgame.cpp

../build-$(ConfigurationName)/jetpac/jpgame.cpp$(PreprocessSuffix): jpgame.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jpgame.cpp$(PreprocessSuffix) jpgame.cpp

../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(ObjectSuffix): jpplatform.cpp ../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jpplatform.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jpplatform.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(DependSuffix): jpplatform.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(DependSuffix) -MM jpplatform.cpp

../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(PreprocessSuffix): jpplatform.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jpplatform.cpp$(PreprocessSuffix) jpplatform.cpp

../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(ObjectSuffix): jplevelscene.cpp ../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jplevelscene.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jplevelscene.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(DependSuffix): jplevelscene.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(DependSuffix) -MM jplevelscene.cpp

../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(PreprocessSuffix): jplevelscene.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(PreprocessSuffix) jplevelscene.cpp


-include ../build-$(ConfigurationName)/jetpac//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


