##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=box2d
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/home/oscar/proyectos/oscar/juegecitos/juegecitos
ProjectPath            :=/home/oscar/proyectos/oscar/juegecitos/juegecitos/box2d
IntermediateDirectory  :=../build-$(ConfigurationName)/box2d
OutDir                 :=../build-$(ConfigurationName)/box2d
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
OutputFile             :=../build-$(ConfigurationName)/lib/lib$(ProjectName).a
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E 
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch)../extern/box2d/include/ $(IncludeSwitch)../extern/box2d/src $(IncludeSwitch). 
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
CXXFLAGS :=  -g $(Preprocessors)
CFLAGS   :=  -g $(Preprocessors)
ASFLAGS  := 
AS       := as


##
## User defined environment variables
##
CodeLiteDir:=/usr/share/codelite
Objects0=../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(ObjectSuffix) \
	../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(ObjectSuffix) \
	../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(ObjectSuffix) \
	../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(ObjectSuffix) \
	../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs ../build-$(ConfigurationName)/box2d/$(OutputFile)

../build-$(ConfigurationName)/box2d/$(OutputFile): $(Objects)
	@mkdir -p "../build-$(ConfigurationName)/box2d"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(AR) $(ArchiveOutputSwitch)$(OutputFile) @$(ObjectsFileList)
	@echo rebuilt > $(IntermediateDirectory)/box2d.relink

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/box2d"
	@mkdir -p ""../build-$(ConfigurationName)/lib""

:
	@mkdir -p "../build-$(ConfigurationName)/box2d"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_world.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_world.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_world.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_world.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_world.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_world.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_world.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_wheel_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_wheel_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_wheel_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_wheel_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_wheel_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_wheel_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_wheel_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_revolute_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_revolute_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_revolute_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_revolute_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_revolute_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_revolute_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_revolute_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_mouse_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_mouse_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_mouse_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_mouse_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_mouse_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_mouse_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_mouse_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_gear_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_gear_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_gear_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_gear_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_gear_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_gear_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_gear_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_friction_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_friction_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_friction_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_friction_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_friction_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_friction_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_friction_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_fixture.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_fixture.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_fixture.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_fixture.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_fixture.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_fixture.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_fixture.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_fixture.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_edge_circle_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_edge_circle_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_edge_circle_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_edge_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_edge_circle_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_circle_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_edge_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_circle_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_circle_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_circle_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_circle_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_circle_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_chain_polygon_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_chain_polygon_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_chain_polygon_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_chain_polygon_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_chain_polygon_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_polygon_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_chain_polygon_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_chain_circle_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_chain_circle_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_chain_circle_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_chain_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_chain_circle_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_chain_circle_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_chain_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_body.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_body.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_body.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_body.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_body.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_body.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_body.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_body.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(ObjectSuffix): ../extern/box2d/src/common/b2_settings.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/common/b2_settings.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_common_b2_settings.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(DependSuffix): ../extern/box2d/src/common/b2_settings.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(DependSuffix) -MM ../extern/box2d/src/common/b2_settings.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(PreprocessSuffix): ../extern/box2d/src/common/b2_settings.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_settings.cpp$(PreprocessSuffix) ../extern/box2d/src/common/b2_settings.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_edge_polygon_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_edge_polygon_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_edge_polygon_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_edge_polygon_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_edge_polygon_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_edge_polygon_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_edge_polygon_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_circle_shape.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_circle_shape.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_circle_shape.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_circle_shape.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_circle_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_circle_shape.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_circle_shape.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_circle_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(ObjectSuffix): ../extern/box2d/src/common/b2_timer.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/common/b2_timer.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_common_b2_timer.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(DependSuffix): ../extern/box2d/src/common/b2_timer.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(DependSuffix) -MM ../extern/box2d/src/common/b2_timer.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(PreprocessSuffix): ../extern/box2d/src/common/b2_timer.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_timer.cpp$(PreprocessSuffix) ../extern/box2d/src/common/b2_timer.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_polygon_circle_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_polygon_circle_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_polygon_circle_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_polygon_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_polygon_circle_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_circle_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_polygon_circle_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_weld_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_weld_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_weld_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_weld_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_weld_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_weld_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_weld_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_world_callbacks.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_world_callbacks.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_world_callbacks.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_world_callbacks.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_world_callbacks.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_world_callbacks.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_world_callbacks.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_collide_edge.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_collide_edge.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_collide_edge.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_collide_edge.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_collide_edge.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_collide_edge.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_edge.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_collide_edge.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_dynamic_tree.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_dynamic_tree.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_dynamic_tree.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_dynamic_tree.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_dynamic_tree.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_dynamic_tree.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_dynamic_tree.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(ObjectSuffix): ../extern/box2d/src/rope/b2_rope.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/rope/b2_rope.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_rope_b2_rope.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(DependSuffix): ../extern/box2d/src/rope/b2_rope.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(DependSuffix) -MM ../extern/box2d/src/rope/b2_rope.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(PreprocessSuffix): ../extern/box2d/src/rope/b2_rope.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_rope_b2_rope.cpp$(PreprocessSuffix) ../extern/box2d/src/rope/b2_rope.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_distance_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_distance_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_distance_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_distance_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_distance_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_distance_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_distance_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_pulley_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_pulley_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_pulley_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_pulley_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_pulley_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_pulley_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_pulley_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_collide_polygon.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_collide_polygon.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_collide_polygon.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_collide_polygon.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_collide_polygon.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_polygon.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_collide_polygon.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_contact_solver.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_contact_solver.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_contact_solver.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_contact_solver.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_contact_solver.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_solver.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_contact_solver.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(ObjectSuffix): ../extern/box2d/src/common/b2_math.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/common/b2_math.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_common_b2_math.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(DependSuffix): ../extern/box2d/src/common/b2_math.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(DependSuffix) -MM ../extern/box2d/src/common/b2_math.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(PreprocessSuffix): ../extern/box2d/src/common/b2_math.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_math.cpp$(PreprocessSuffix) ../extern/box2d/src/common/b2_math.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_polygon_contact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_polygon_contact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_polygon_contact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_polygon_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_polygon_contact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_polygon_contact.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_polygon_contact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_island.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_island.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_island.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_island.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_island.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_island.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_island.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_island.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_contact_manager.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_contact_manager.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_contact_manager.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_contact_manager.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_contact_manager.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_contact_manager.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_contact_manager.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(ObjectSuffix): ../extern/box2d/src/common/b2_draw.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/common/b2_draw.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_common_b2_draw.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(DependSuffix): ../extern/box2d/src/common/b2_draw.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(DependSuffix) -MM ../extern/box2d/src/common/b2_draw.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(PreprocessSuffix): ../extern/box2d/src/common/b2_draw.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_draw.cpp$(PreprocessSuffix) ../extern/box2d/src/common/b2_draw.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_chain_shape.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_chain_shape.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_chain_shape.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_chain_shape.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_chain_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_chain_shape.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_chain_shape.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_chain_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_prismatic_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_prismatic_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_prismatic_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_prismatic_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_prismatic_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_prismatic_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_prismatic_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_collision.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_collision.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_collision.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_collision.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_collision.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_collision.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collision.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_collision.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_distance.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_distance.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_distance.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_distance.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_distance.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_distance.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_distance.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_distance.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_edge_shape.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_edge_shape.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_edge_shape.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_edge_shape.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_edge_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_edge_shape.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_edge_shape.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_edge_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_polygon_shape.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_polygon_shape.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_polygon_shape.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_polygon_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_polygon_shape.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_polygon_shape.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_polygon_shape.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_time_of_impact.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_time_of_impact.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_time_of_impact.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_time_of_impact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_time_of_impact.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_time_of_impact.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_time_of_impact.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(ObjectSuffix): ../extern/box2d/src/dynamics/b2_motor_joint.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/dynamics/b2_motor_joint.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(DependSuffix): ../extern/box2d/src/dynamics/b2_motor_joint.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(DependSuffix) -MM ../extern/box2d/src/dynamics/b2_motor_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(PreprocessSuffix): ../extern/box2d/src/dynamics/b2_motor_joint.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_dynamics_b2_motor_joint.cpp$(PreprocessSuffix) ../extern/box2d/src/dynamics/b2_motor_joint.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_broad_phase.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_broad_phase.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_broad_phase.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_broad_phase.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_broad_phase.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_broad_phase.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_broad_phase.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_broad_phase.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(ObjectSuffix): ../extern/box2d/src/common/b2_block_allocator.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/common/b2_block_allocator.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_common_b2_block_allocator.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(DependSuffix): ../extern/box2d/src/common/b2_block_allocator.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(DependSuffix) -MM ../extern/box2d/src/common/b2_block_allocator.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(PreprocessSuffix): ../extern/box2d/src/common/b2_block_allocator.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_block_allocator.cpp$(PreprocessSuffix) ../extern/box2d/src/common/b2_block_allocator.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(ObjectSuffix): ../extern/box2d/src/collision/b2_collide_circle.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/collision/b2_collide_circle.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_collision_b2_collide_circle.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(DependSuffix): ../extern/box2d/src/collision/b2_collide_circle.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(DependSuffix) -MM ../extern/box2d/src/collision/b2_collide_circle.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(PreprocessSuffix): ../extern/box2d/src/collision/b2_collide_circle.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_collision_b2_collide_circle.cpp$(PreprocessSuffix) ../extern/box2d/src/collision/b2_collide_circle.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(ObjectSuffix): ../extern/box2d/src/common/b2_stack_allocator.cpp ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/home/oscar/proyectos/oscar/juegecitos/juegecitos/extern/box2d/src/common/b2_stack_allocator.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/up_extern_box2d_src_common_b2_stack_allocator.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(DependSuffix): ../extern/box2d/src/common/b2_stack_allocator.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(DependSuffix) -MM ../extern/box2d/src/common/b2_stack_allocator.cpp

../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(PreprocessSuffix): ../extern/box2d/src/common/b2_stack_allocator.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/box2d/up_extern_box2d_src_common_b2_stack_allocator.cpp$(PreprocessSuffix) ../extern/box2d/src/common/b2_stack_allocator.cpp


-include ../build-$(ConfigurationName)/box2d//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


