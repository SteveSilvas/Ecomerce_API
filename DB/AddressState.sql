CREATE TABLE AddressState (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Description VARCHAR(100) NOT NULL
);

-- INSERT INTO AddressState (Description) VALUES
-- ('State 1'),
-- ('State 2'),
-- ('State 3'),
-- ('State 4'),
-- ('State 5'),
-- ('State 6'),
-- ('State 7'),
-- ('State 8'),
-- ('State 9'),
-- ('State 10');

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