cmake_minimum_required(VERSION 3.8.0)

project(core VERSION 0.1.0)

add_library(core jgsgame.cpp)

target_precompile_headers(core PUBLIC pch.h)
target_compile_features(core PUBLIC c_std_99)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
