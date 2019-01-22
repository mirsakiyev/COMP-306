CREATE TABLE Students(
	id int, 
    fname varchar(255), 
    lname varchar(255),
    email varchar(255),
    phone varchar(255)
);

INSERT INTO Students (id,fname,lname,email,phone)
VALUES (300850326, 'Aslan', 'Mirsakiyev', 'mirsakiyev@yahoo.com', '6477031920');
INSERT INTO Students (id,fname,lname,email,phone)
VALUES (300878231, 'Andrew', 'Slodowski', 'andy@yahoo.com', '4167012334');
INSERT INTO Students (id,fname,lname,email,phone)
VALUES (300859031, 'Illias', 'Sippis', 'isippis@gmail.com', '6477771029');

SELECT * From Students