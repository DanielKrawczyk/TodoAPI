INSERT INTO Users(Name, Email)
VALUES ('Test', 'test@test.com'),
	('Test2', 'test@test.com'),
	('Test3', 'test@test.com');

INSERT INTO Todos(Title, Description, CreationDate, DueTo, Status, UserId)
VALUES ('Make todo', 'Make first todo', DATE('now'), DATE('now', '+1 day'), 0, 1),
	('Make todo', 'Make second todo', DATE('now'), null, 0, 1),
	('Make todo', null, DATE('now'), DATE('now', '+1 day'), 0, 2),
	('Make todo', 'Make test todo', DATE('now'), DATE('now', '+5 days'), 0, 3);