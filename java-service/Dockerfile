FROM openjdk:11
ADD target/users-mysql.jar users-mysql.jar
EXPOSE 8099
ENTRYPOINT ["java", "-jar", "users-mysql.jar"]
