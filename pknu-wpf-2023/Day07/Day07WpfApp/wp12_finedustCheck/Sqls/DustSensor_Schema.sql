CREATE TABLE `dustsensor` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Dev_id` varchar(20) DEFAULT NULL,
  `Name` varchar(20) DEFAULT NULL,
  `Loc` varchar(100) DEFAULT NULL,
  `Coordx` double DEFAULT NULL,
  `Coordy` double DEFAULT NULL,
  `Ison` bit(1) DEFAULT NULL,
  `Pm10_after` int DEFAULT NULL,
  `Pm25_after` int DEFAULT NULL,
  `State` int DEFAULT NULL,
  `Timestamp` datetime DEFAULT NULL,
  `Company_id` varchar(50) DEFAULT NULL,
  `Company_name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
);
