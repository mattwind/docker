# General Docker Commands

With docker there are images and containers. Here are some basic docker commands.

### View docker images

`docker images -a`

### List containers

`docker ps -a`

### View Container Logs

`docker logs <container>`

### Bash Terminal

`docker run -it <image> /bin/bash`

### View container enviroment variables

`docker inspect -f "{{ .Config.Env }}" <container>`

Get all sorts of information on a specific container

`docker inspect <container>`

### Stop/Start containers

`docker stop <container>`

`docker start --interactive <containter>`

### Remove container

`docker rm <container>`

### Remove image

`docker rmi <image>`

### GIT checkout submodule

`git submodule update --init`

### GIT update submodule

`git submodule foreach git pull origin master`
