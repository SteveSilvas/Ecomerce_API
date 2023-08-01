CREATE TABLE Address (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Street VARCHAR(255) NOT NULL,
    Complement VARCHAR(255),
    CityId INT NOT NULL,
    StateId INT NOT NULL,
    ZipCode INT NOT NULL,
    Country VARCHAR(100),
    CONSTRAINT FK_Address_City FOREIGN KEY (CityId) REFERENCES AddressCity (Id),
    CONSTRAINT FK_Address_State FOREIGN KEY (StateId) REFERENCES AddressState (Id)
);


INSERT INTO Address (Street, Complement, CityId, StateId, ZipCode, Country) 
VALUES ('Rua A', 'Ap 101', 1, 1, 12345678, 'Brasil');

INSERT INTO Address (Street, Complement, CityId, StateId, ZipCode, Country) 
VALUES ('Avenida B', 'Casa 20', 2, 2, 87654321, 'Brasil');