IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE [name] = N'ProGestion')
    CREATE DATABASE ProGestion;

GO

USE ProGestion

CREATE TABLE Missions(
	id INT IDENTITY PRIMARY KEY,
	libel VARCHAR(40) NOT NULL,
	);

CREATE TABLE Country(
	id INT IDENTITY PRIMARY KEY,
	name VARCHAR(40) NOT NULL,
	isoCode VARCHAR(3) NOT NULL,
	);

CREATE TABLE ChoosenCountryYears(
	country_id INT NOT NULL REFERENCES Country(id),
	choosenYear INT NOT NULL,
	PRIMARY KEY (country_id, choosenYear),
	);

CREATE TABLE Actions(
	id INT IDENTITY PRIMARY KEY,
	libel VARCHAR(40) NOT NULL,
	);

CREATE TABLE Associations(
	id INT IDENTITY PRIMARY KEY, 
	name VARCHAR (40) NOT NULL,
	responsable VARCHAR(40) NOT NULL,
	mission_id INT NOT NULL REFERENCES Missions(id),
	country_id INT NOT NULL REFERENCES Country(id),
	);

CREATE TABLE Partnerships(
	id INT IDENTITY PRIMARY KEY,
	date DATE NOT NULL,
	plafond FLOAT,
	forecastBudget FLOAT,
	realBudget FLOAT,
	action_id INT NOT NULL REFERENCES Actions(id),
	association_id INT NOT NULL REFERENCES Associations(id),
	country_id INT NOT NULL REFERENCES Country(id),
	);

CREATE TABLE Role(
	id INT IDENTITY PRIMARY KEY,
	libel VARCHAR(40) NOT NULL,
	);

CREATE TABLE Users(
	id INT IDENTITY PRIMARY KEY,
	login VARCHAR(40) NOT NULL,
	password VARCHAR(120) NOT NULL,
	role_id INT NOT NULL REFERENCES Role(id)
	);

CREATE TABLE InterventionsLogs(
	id INT IDENTITY PRIMARY KEY,
	tableName VARCHAR(40) NOT NULL,
	operation VARCHAR(6) NOT NULL,
	reference INT NOT NULL
	);