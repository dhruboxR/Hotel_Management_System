CREATE TABLE customers (
    name    VARCHAR(100),
    contact VARCHAR(20)  NOT NULL PRIMARY KEY,
    email   VARCHAR(100) NOT NULL UNIQUE,
    nid     VARCHAR(20)  NOT NULL UNIQUE
);
