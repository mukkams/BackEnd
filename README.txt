docker build -t userstoreapi:v1 .

docker run -d -p 5000:5000 --name userstore userstoreapi:v1

docker container logs 4dfd15425852