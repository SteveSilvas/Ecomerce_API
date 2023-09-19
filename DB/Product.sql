CREATE TABLE Product (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(150) NOT NULL,
    Description VARCHAR(150) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES ProductCategory(Id)
);

INSERT INTO Product (Name, Description, Price, CategoryId)
VALUES
    ('iPhone 13 Pro', 'Smartphone Apple iPhone 13 Pro 128GB', 1099.99, 1),
    ('Dell XPS 13', 'Notebook Dell XPS 13 com tela InfinityEdge', 1499.00, 2),
    ('Sony WH-1000XM4', 'Fone de Ouvido Sony WH-1000XM4 com cancelamento de ruído', 299.99, 3),
    ('Samsung QLED 4K', 'Smart TV Samsung QLED 4K de 55 polegadas', 899.50, 4),
    ('Canon EOS 90D', 'Câmera DSLR Canon EOS 90D com lente EF-S 18-135mm', 1299.95, 5),
    ('LG Geladeira', 'Geladeira LG de duas portas com dispensador de água', 799.99, 6),
    ('PlayStation 5', 'Console de jogos Sony PlayStation 5', 499.00, 7),
    ('Anker Power Bank', 'Power Bank Anker de 20.000mAh', 39.95, 8),
    ('Apple Watch Series 7', 'Relógio Inteligente Apple Watch Series 7', 249.00, 9),
    ('Google Nest Thermostat', 'Termostato Inteligente Google Nest', 129.99, 10);
