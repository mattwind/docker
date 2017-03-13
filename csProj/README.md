# Docker container for dotnetcore and websocketd

Source code for dotnet program is in ./app/program/

## Compile the dotnet project

dotnet build

dotnet run

dotnet publish

## Build Container

docker-compose -f ./docker-compose.yml build

## Start Container

docker-compose -f ./docker-compose.yml up -d

## Stop

docker-compose -f ./docker-compose.yml stop

## Remove

docker-compose -f ./docker-compose.yml rm -f

## Connect to bash

docker exec -it MyApp bash
