# Aspnet-Microservices
1. Catalog.API
2. Mongo DB
   1. Go to https://hub.docker.com/_/mongo
   2. Open Terminal in VS and pull docker Image "docker pull mongo"
   3. Run docker image "docker run -d -p 27017:27017 --name shopping-mongo mongo"
   4. Getting inside the mongo image "docker exec -it shopping-mongo /bin/bash"