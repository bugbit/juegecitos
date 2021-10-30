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
Date                   :=30/10/21
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
Libs                   := $(LibrarySwitch)core $(LibrarySwitch)stdc++ $(LibrarySwitch)SDL2 $(LibrarySwitch)SDL2_image 
ArLibs                 :=  "core" "stdc++" "SDL2" "SDL2_image" 
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
Objects0=../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/jetpac/jpgame.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/jetpac/.d "$(IntermediateDirectory)/core.relink" $(Objects) 
	@mkdir -p "../build-$(ConfigurationName)/jetpac"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

"$(IntermediateDirectory)/core.relink":
	@mkdir -p $(IntermediateDirectory)
	@echo stam > "$(IntermediateDirectory)/core.relink"




MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/jetpac"
	@mkdir -p ""../build-$(ConfigurationName)/bin""

../build-$(ConfigurationName)/jetpac/.d:
	@mkdir -p "../build-$(ConfigurationName)/jetpac"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(ObjectSuffix): jplevelobj.cpp ../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jplevelobj.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jplevelobj.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(DependSuffix): jplevelobj.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(DependSuffix) -MM jplevelobj.cpp

../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(PreprocessSuffix): jplevelobj.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jplevelobj.cpp$(PreprocessSuffix) jplevelobj.cpp

../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(ObjectSuffix): jplevelscene.cpp ../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/jetpac/jplevelscene.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/jplevelscene.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(DependSuffix): jplevelscene.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(DependSuffix) -MM jplevelscene.cpp

../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(PreprocessSuffix): jplevelscene.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/jetpac/jplevelscene.cpp$(PreprocessSuffix) jplevelscene.cpp

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


