CREATE TABLE Employee (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Sexo VARCHAR(255),
    Salario DECIMAL(10, 2) NOT NULL,
    Admission DATETIME NOT NULL,
    Resignation DATETIME NOT NULL,
    Active TINYINT(1) NOT NULL,
    DepartmentId INT NOT NULL,
    FOREIGN KEY (DepartmentId) REFERENCES Department(Id)
);

INSERT INTO Employee (Name, Sexo, Salario, Admission, Resignation, Active, DepartmentId) VALUES
('John Doe', 'Male', 5000.00, '2023-07-31', '2025-07-31', 1, 1),
('Jane Smith', 'Female', 4500.00, '2023-07-31', '2025-07-31', 1, 1),
('Michael Johnson', 'Male', 5500.00, '2023-07-31', '2025-07-31', 1, 2),
('Emily Brown', 'Female', 4800.00, '2023-07-31', '2025-07-31', 1, 2),
('Robert Davis', 'Male', 5200.00, '2023-07-31', '2025-07-31', 1, 3),
('Sophia Miller', 'Female', 4900.00, '2023-07-31', '2025-07-31', 1, 3),
('William Wilson', 'Male', 5300.00, '2023-07-31', '2025-07-31', 1, 4),
('Olivia Anderson', 'Female', 4600.00, '2023-07-31', '2025-07-31', 1, 4),
('James Martinez', 'Male', 5400.00, '2023-07-31', '2025-07-31', 1, 5),
('Ava Hernandez', 'Female', 4700.00, '2023-07-31', '2025-07-31', 1, 5);
