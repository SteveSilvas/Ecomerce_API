CREATE TABLE Department (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL
);

INSERT INTO
    Department (Name)
VALUES
    ('Financeiro'),
    ('Recursos Humanos'),
    ('Vendas'),
    ('Marketing'),
    ('Tecnologia da Informação'),
    ('Logística'),
    ('Produção'),
    ('Qualidade'),
    ('Administrativo'),
    ('Jurídico');