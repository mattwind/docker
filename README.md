# General Docker Commands

With docker there are images and containers. Here are some basic docker commands.

### View docker images

`docker images -a`

### List containers

`docker ps -a`

### View Container Logs

`docker logs <name>`

### Bash Terminal

`docker run -it <image> /bin/bash`

### View container enviroment variables

`docker inspect -f "{{ .Config.Env }}" <name>`

Get all sorts of information on a specific container

`docker inspect <name>`

### Stop/Start containers

`docker stop <name>`

### Remove container

`docker rm <name>`

### Remove image

`docker rmi <image>`

