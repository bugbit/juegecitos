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
    target_link_libraries(${PROJECT_NAME} "-s USE_SDL=2")
    target_link_libraries(${PROJECT_NAME} "-s USE_SDL_IMAGE=2")
    target_link_libraries(${PROJECT_NAME} "-s SDL2_IMAGE_FORMATS='[\"png\"]'")
    target_link_libraries(${PROJECT_NAME} "--preload-file assets")
else(EMSCRIPTEN)
    target_link_libraries(jetpac SDL2main)
    set(copy_source_dir "${CMAKE_SOURCE_DIR}/jetpac/assets")
    set(copy_dest_dir "${CMAKE_BINARY_DIR}/jetpac/assets")
    set(copy_file_name "*.png")
    add_custom_command(
        TARGET ${PROJECT_NAME} POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E make_directory ${copy_dest_dir}
    )
    add_custom_command(
        TARGET ${PROJECT_NAME} POST_BUILD 
        COMMAND ${CMAKE_COMMAND} -E copy_directory "${copy_source_dir}" "${copy_dest_dir}"
        COMMENT "Copying ${copy_file_name} to build directory"
    )
endif(EMSCRIPTEN)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
