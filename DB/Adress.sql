CREATE TABLE Address (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Street VARCHAR(255) NOT NULL,
    Number VARCHAR(50) NOT NULL,
    Complement VARCHAR(255),
    CityId INT NOT NULL,
    StateId INT NOT NULL,
    ZipCode VARCHAR(8) NOT NULL,
    Country VARCHAR(100),
    CONSTRAINT FK_Address_City FOREIGN KEY (CityId) REFERENCES AddressCity (Id),
    CONSTRAINT FK_Address_State FOREIGN KEY (StateId) REFERENCES AddressState (Id)
);


INSERT INTO Address (Street, Number, Complement, CityId, StateId, ZipCode, Country) 
VALUES ('Rua A','10', 'Ap 101', 1, 1, '12345678', 'Brasil');

INSERT INTO Address (Street, Complement, CityId, StateId, ZipCode, Country) 
VALUES ('Avenida B','5', 'Casa 20', 2, 2, '87654321', 'Brasil');