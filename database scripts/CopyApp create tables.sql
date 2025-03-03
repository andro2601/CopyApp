CREATE TABLE IF NOT EXISTS test_schema.document(
	id serial primary key,
	title varchar(255),
	author varchar(127),
	pageCount int,
	fileType varchar(4)
);

CREATE TABLE IF NOT EXISTS test_schema.order(
	id serial primary key,
	documentId int references test_schema.document(id),
	email varchar(50),
	name varchar(50),
	copies int,
	color boolean,
	price decimal(6,2),
	completed boolean
)
