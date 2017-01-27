# MySQL Container

In this document we assume the container is called test-mysql and the password is mypassword.

### Run a mysql server container

`docker run --detach --name=test-mysql --env="MYSQL_ROOT_PASSWORD=mypassword" mysql`

### Connect to mysql server console

`docker run -it --link test-mysql:mysql --rm mysql sh -c 'exec mysql -h"$MYSQL_PORT_3306_TCP_ADDR" -P"$MYSQL_PORT_3306_TCP_PORT" -uroot -p"$MYSQL_ENV_MYSQL_ROOT_PASSWORD"'`
