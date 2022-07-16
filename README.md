Este es el ejercicio para la capacitación de Kubernetes:
Los 3 microservicios se levantan correctamente, pero aún no es posible conectar la base de datos del microservicio Java.

La imagen de la base de datos se construyo con MySQL con el comando:

docker run --name mysql-services -e MYSQL_ROOT_PASSWORD=admin -p 3306:3306 -d mysql:5.6

El nombre, password y puertos hacen alusión a la configuración que se dio en el microservicio de Java.

La URL de las imagenes de Docker es:

https://hub.docker.com/r/107004909/ejemplo-netcore

https://hub.docker.com/r/107004909/ejemplo-nodejs

https://hub.docker.com/r/107004909/springapp

https://hub.docker.com/r/107004909/db4springapp

De manera local todas funcionan correctamente, mediante Kubernetes solo netcore y nodejs funcionan correctamente, springapp se despliega correctamente, pero no se conecta con la base de datos.

Se seguira investigando al respecto para que se de un correcto funcionamiento.
