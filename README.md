# BlocDeNotas
First you'll need to import the mySQL database. This is the Query:

```
CREATE DATABASE `blocdenotas`;

USE `blocdenotas`;

/*Table structure for table `escritor` */

DROP TABLE IF EXISTS `escritor`;

CREATE TABLE `escritor` (
  `nombre` varchar(25) NOT NULL,
  `contrasenia` varchar(25) NOT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Table structure for table `notas` */

DROP TABLE IF EXISTS `notas`;

CREATE TABLE `notas` (
  `ID_NOTA` int NOT NULL,
  `TITULO` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TEXTO` text,
  `AUTOR` varchar(25) DEFAULT NULL,
  `DATE` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_NOTA`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

Then, in Form1.cs, line 28 inside method "CreateDataBase( here )" you must insert as string (""):

host (if it's a localhost: "localhost"),
mySQL database name,
mySQL user,
mySQL password

Then the line will be something like this: 
    mysql = MySQLDatabase.CreateConnection("host", "databasename", "user","password");

