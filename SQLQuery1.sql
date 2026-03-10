CREATE TABLE user_table (
	user_id INT IDENTITY(1,1), 
	username VARCHAR(30), 
	password VARCHAR(30),
	user_role INT,
	PRIMARY KEY(user_id)
);