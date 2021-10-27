cmake_minimum_required(VERSION 3.8.0)

project(jetpac VERSION 0.1.0)

# if (EMSCRIPTEN)
#     set(CMAKE_AR "emcc")
#     set(CMAKE_STATIC_LIBRARY_SUFFIX ".bc")
#     set(CMAKE_C_CREATE_STATIC_LIBRARY "<CMAKE_AR> -o <TARGET> <LINK_FLAGS> <OBJECTS>")
#     set(CMAKE_CXX_CREATE_STATIC_LIBRARY "<CMAKE_AR> -o <TARGET> <LINK_FLAGS> <OBJECTS>")
# endif()
if (EMSCRIPTEN)
    set(CMAKE_EXECUTABLE_SUFFIX ".html")
    #set(CMAKE_C_FLAGS "-s STANDALONE_WASM" )
endif()

include_directories(../core)
add_executable(jetpac jpgame.cpp jplevelscene.cpp)

target_precompile_headers(jetpac PUBLIC pch.h)
target_compile_features(jetpac PUBLIC c_std_99)

link_directories(../core)
target_link_libraries(jetpac SDL2 core)
if (EMSCRIPTEN)
else(EMSCRIPTEN)
    target_link_libraries(jetpac SDL2main)
endif(EMSCRIPTEN)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
