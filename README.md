# General Docker Commands

With docker there are images and containers. Here are some basic docker commands.

### View docker images

`docker images -a`

If you have any images downloaded you would see something like this.

`REPOSITORY          TAG                 IMAGE ID            CREATED             SIZE
mysql               latest              f3694c67abdb        10 days ago         400 MB`

### List containers

`docker ps -a`

If you have any containers running you would see this.

`CONTAINER ID        IMAGE               COMMAND                  CREATED             STATUS              PORTS               NAMES
d7417a78e4a4        mysql               "docker-entrypoint..."   35 minutes ago      Up 33 minutes       3306/tcp            test-mysql`

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

