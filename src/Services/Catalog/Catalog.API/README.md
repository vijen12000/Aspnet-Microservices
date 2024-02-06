# Catalog API Objectives
## Catalog API is created using ASP.Net Core Web API
## We have used REST API principles, CRUD operations, Repositiory Pattern
## MongoDb in a container is used as backend
## Containerize Catalog Microservice with MongoDb using docker compose

## Catalog REST API endpoints
| Method   | Request Url                                     | Use Case                               | 
| -------- | ----------------------------------------------- | -------------------------------------- |     
| GET      | api/v1/catalog                                  | Lists Products and Categories          |
| GET      | api/v1/catalog/{id}                             | Gets a single product with product id  |
| GET      | api/v1/catalog/GetProductbyCategory/{category}  | Gets products with category			  |
| POST     | api/v1/catalog                                  | Creates a new Product				  |
| PUT      | api/v1/catalog                                  | Updates the product					  |
| DELETE   | api/v1/catalog/{id}                             | deletes the product					  |

## Catalog Service Archictecture

## Coding 
### Install MongoDB.Driver nuget package
## Containerize 
### Right Click on the Catalog API => Go to Add => Select "Container Orchestrator Support"
### Select Docker Compose as "Container Orchestrator"
### Select Linux as Target OS
### Add MongoDB to Docker Compose File
### Sping up the containers using docker-compose "docker-compose -f .\docker-componse.yml -f .\docker-componse.override.yml up -d"