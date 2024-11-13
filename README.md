# Aspnet-Microservices
1. Catalog.API
2. Mongo DB
   1. Go to https://hub.docker.com/_/mongo
   2. Open Terminal in VS and pull docker Image "docker pull mongo"
   3. Run docker image "docker run -d -p 27017:27017 --name shopping-mongo mongo"
   4. Getting inside the mongo image "docker exec -it shopping-mongo mongosh" (mongo shell is replaced with mongosh)
   5. List the exiting databases "show dbs"
   6. Create a new CatalogDb data base "use CatalogDb"
   7. Create a new Product Collection "db.createCollection('Products')"
   8. Insert products "db.Products.insertMany()"
   8. Sample Payload "db.Products.insertMany([{ 'Name':'Asus Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':54.93 }, { 'Name':'HP Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':88.93 }])"
      "db.Products.insertMany([{ 'Name':'Asus Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':54.93 }, { 'Name':'HP Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':88.93 }])"
   9. find products "db.Products.find({}).pretty()"       
   10 remove the products "db.Products.remove({})"
3. Basket Service
   1. Redis
      1. Pull Redis Image "docker pull redis"
      2. Run Docker Image "docker run -d -p 6379:6379 --name aspnetrun-redis redis"
      3. check the logs "docker logs -f aspnetrun-redis"
      4. Get inside the redis image "docker exec -it aspnetrun-redis /bin/bash"


4. Docker Componse
    1.  Sping up the containers using docker-compose "docker-compose -f .\docker-componse.yml -f .\docker-componse.override.yml up -d"