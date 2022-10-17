# Como fazer a publicação da DLL
```shell
dotnet publish -c Release -o out
```

# Como gerar a imagem do docker
```shell
docker build -t didox/api-basica-stone .
```

# Criar um container
```shell
docker run -d -p 80:80 --name api-basica-stone didox/api-basica-stone
```

# Removendo um container
```shell
docker rm api-basica-stone --force
```

# Mostrando logs de um container
```shell
docker logs api-basica-stone
```

# Como vejo se o container está rodando
```shell
docker ps
```

# Como parar o container
```shell
docker stop api-basica-stone
```

# Como iniciar um container já criado
```shell
docker start api-basica-stone
```

# Verificar todos os containers
```shell
docker ps -a
```

# Me logando na conta do https://hub.docker.com/
```shell
docker login
```

# Enviando imagem para o https://hub.docker.com/
```shell
docker push didox/api-basica-stone
```

# Como baixar imagem docker no servidor https://hub.docker.com/
```shell
docker pull didox/api-basica-stone
```

# Como entrar dentro do container
```shell
docker exec -it api-basica-stone bash
```

# No servidor ubuntu:
```shell
sudo su -
apt update
apt install docker.io -y
docker pull didox/api-basica-stone
docker run -d -p 80:80 --name api-basica-stone didox/api-basica-stone

# ai só preciso liberar no firewall a porta 80
```

