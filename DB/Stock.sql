CREATE TABLE Stock (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    UpdatedAt DATETIME NOT NULL,
    FOREIGN KEY (ProductId) REFERENCES Product(Id)
);

INSERT INTO
    Stock (ProductId, Quantity, UpdatedAt)
VALUES
    (1, 50, NOW()),
    (2, 30, NOW()),
    (3, 100, NOW()),
    (4, 25, NOW()),
    (5, 40, NOW()),
    (6, 60, NOW()),
    (7, 15, NOW()),
    (8, 75, NOW()),
    (9, 35, NOW()),
    (10, 20, NOW());