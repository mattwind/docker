# Docker

## Install dependencies

`apt-get install apt-transport-https ca-certificates gnupg2 jq curl git -y`

## Add key

`apt-key adv \
      --keyserver hkp://ha.pool.sks-keyservers.net:80 \
      --recv-keys 58118E89F3A912897C070ADBF76221572C52609D`

## Add docker repository

`echo "deb https://apt.dockerproject.org/repo debian-jessie main" >> /etc/apt/sources.list.d/docker.list`

## Update apt

`apt-get update`

## Install docker engine

`apt-get install docker-engine -y`

# Docker Compose

## Grab the binary

`curl -L "https://github.com/docker/compose/releases/download/1.9.0/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose`

## Update the permissions

`chmod +x /usr/local/bin/docker-compose`

# Update Group

## Add the current user "canara" to docker group

`gpasswd -a canara docker`

# Restart Docker

## Apply changes and restart engine

`service docker restart`
