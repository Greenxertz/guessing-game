@echo off

rem Save the current directory
set "currentDir=%cd%"

rem Navigate to the directory containing this batch file
cd %~dp0

rem Specify the location of the compose file
set "composeFile=loginapi\compose.yaml"

rem Start Docker container with the YAML file and build if needed
docker-compose -f %composeFile% stop

rem Return to the original directory
cd %currentDir%
