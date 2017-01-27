# General Docker Commands

Here are some basic docker commands

### View docker images

`docker images -a`

### List containers

`docker ps -a`

### View Container Logs

`docker logs <name>|<container id>`

### Bash Terminal

`docker run -it <image> /bin/bash`

### View container enviroment variables

`docker inspect -f "{{ .Config.Env }}" <name>|<container id>

Get all sorts of information on a specific container

`docker inspect <name>|<container id>`

### Stop/Start containers

`docker stop <name>|<container id>

### Remove container

`docker rm <name>|<container id>`

### Remove image

`docker rmi <image-name>`

