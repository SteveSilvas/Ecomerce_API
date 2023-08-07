CREATE TABLE AddressState (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Description VARCHAR(100) NOT NULL
);

INSERT INTO
    AddressState (Description)
VALUES
    ('São Paulo');

INSERT INTO
    AddressState (Description)
VALUES
    ('Rio de Janeiro');

INSERT INTO
    AddressState (Description)
VALUES
    ('São Paulo'),
    ('Bahia'),
    ('Pernambuco'),
    ('Rio de Janeiro'),
    ('Ceará'),
    ('Minas Gerais'),
    ('Mato Grosso'),
    ('Acre'),
    ('Amapá'),
    ('Amazonas');