USE finance_demo;

/*
#Create tables
CREATE TABLE Income (
    transactionID INT AUTO_INCREMENT PRIMARY KEY,
    transactionValue DECIMAL(10,2),
    transactionDescription VARCHAR(255),
    transactionDate DATE
);

CREATE TABLE expenses (
    transactionID INT AUTO_INCREMENT PRIMARY KEY,
    transactionValue DECIMAL(10,2),
    transactionDescription VARCHAR(255),
    transactionDate DATE
);

#Insert demo Income transactions
INSERT INTO income (transactionValue, transactionDescription, transactionDate) VALUES ('2567.20', 'Paycheck', '2026-01-10');
INSERT INTO income (transactionValue, transactionDescription, transactionDate) VALUES ('1849.00', 'Paycheck', '2026-08-10');
INSERT INTO income (transactionValue, transactionDescription, transactionDate) VALUES ('2787.95', 'Paycheck', '2025-09-10');
INSERT INTO income (transactionValue, transactionDescription, transactionDate) VALUES ('2403.00', 'Paycheck', '2025-10-10');
INSERT INTO income (transactionValue, transactionDescription, transactionDate) VALUES ('2767.11', 'Paycheck', '2025-11-10');
INSERT INTO income (transactionValue, transactionDescription, transactionDate) VALUES ('1948.45', 'Paycheck', '2025-12-10');

#Insert demo Expenses transactions
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('45.60', 'fuel', '2026-01-05');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('32.90', 'medication', '2026-01-08');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('120.00', 'clothing', '2025-11-12');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('78.40', 'fuel', '2025-11-15');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('26.75', 'groceries', '2025-12-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('59.99', 'medication', '2025-10-22');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('185.30', 'clothing', '2025-12-25');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('210.00', 'fuel', '2026-01-02');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('42.10', 'groceries', '2025-12-06');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('95.00', 'clothing', '2025-08-10');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('67.80', 'medication', '2025-08-14');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('134.25', 'fuel', '2025-09-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('28.60', 'groceries', '2025-10-21');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('260.00', 'clothing', '2025-12-25');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('310.45', 'fuel', '2025-11-03');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('49.90', 'medication', '2025-10-06');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('72.15', 'groceries', '2025-11-10');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('180.00', 'clothing', '2025-12-14');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('420.00', 'fuel', '2026-1-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('38.50', 'medication', '2026-01-06');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('28.90', 'parking', '2025-08-14');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('118.90', 'utilities', '2025-09-10');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('76.80', 'internet', '2025-09-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('41.60', 'coffee', '2025-09-26');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('27.90', 'parking', '2025-10-13');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('129.30', 'utilities', '2025-11-11');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('110.00', 'gifts', '2025-12-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('44.90', 'parking', '2025-12-14');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('142.90', 'utilities', '2026-01-10');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('198.00', 'car maintenance', '2026-01-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('750.00', 'rent', '2025-08-01');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('750.00', 'rent', '2025-09-01');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('750.00', 'rent', '2025-10-01');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('750.00', 'rent', '2025-11-01');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('750.00', 'rent', '2025-12-01');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('750.00', 'rent', '2026-01-01');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('45.30', 'other', '2025-08-05');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('62.80', 'other', '2025-08-12');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('98.45', 'other', '2025-08-19');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('140.00', 'other', '2025-08-27');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('73.60', 'other', '2025-09-04');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('115.20', 'other', '2025-09-11');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('54.90', 'other', '2025-09-18');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('160.00', 'other', '2025-09-25');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('89.75', 'other', '2025-10-03');
INSERT INTO expenses(transactionValue, transactionDescription, transactionDate) VALUES ('132.40', 'other', '2025-10-10');
*/
SELECT * from income;
SELECT * from expenses;
SELECT SUM(transactionValue) As total_value
FROM expenses; 
