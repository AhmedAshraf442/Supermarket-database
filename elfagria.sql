create database SuperMarket;

create table Admins
(
	admin_id int identity(1,1) primary key,
	admin_firstname varchar(25) not null,
	admin_lastname varchar(25) not null,
	admin_phone varchar(25) not null,
	admin_email varchar(25) not null,
	admin_username varchar(25) not null unique,
	admin_password varchar(25) not null
);

create table Brands
(
	brand_id int identity(1,1) primary key,
	brand_name varchar(25) not null
);

create table Categories
(
	Categorie_id int identity(1,1) primary key,
	Categorie_name varchar(25) not null,
	Categorie_income decimal not null
);

create table Products
(
	 Product_id int identity(1,1) primary key,
	 Product_name varchar(25) not null,
	 Brand_id int foreign key references Brands(brand_id),
	 categorie_id int foreign key references Categories(Categorie_id),
	 Product_modelYear int not null,
	 Product_price decimal not null,
	 quantity int not null
);

/*
create table Stocks
(
	store_id int identity(1,1),
	product_id int identity(1,1),
	primary key(store_id,product_id),
	quantity int not null
);
*/

/*
create table Staffs
(
	staff_id int identity(1,1) primary key,
	first_name varchar(25) not null,
	last_name varchar(25) not null,
	email varchar(25) not null,
	phone varchar(25) not null,
	active varchar(25) not null,
	store_id int,
	manager_id int,
	staff_username varchar(25) not null,
	staff_password varchar(25) not null
);
*/

/*
create table Stores
(
	store_id int identity(1,1) primary key,
	store_name varchar(25) not null,
	store_phone varchar(25) not null,
	store_email varchar(25) not null,
	store_address varchar(25) not null,
	city varchar(25) not null,
	stat varchar(25) not null,
	zip_code varchar(25) not null
);
*/

create table Customers
(
	customer_id int identity(1,1) primary key,
	customer_firstname varchar(25) not null,
	customer_lastname varchar(25) not null,
	customer_email varchar(25) not null,
	customer_phone varchar(25) not null,
	customer_street varchar(25) not null,
	customer_city varchar(25) not null,
	customer_state varchar(25) not null,
	customer_zip_code varchar(25) not null,
	customer_user_name varchar(25) not null,
	customer_password varchar(25) not null
);

create table Orders
(
	order_id int identity(1,1) primary key,
	product_id int foreign key references Products(Product_id),
	Customer_id int foreign key references Customers(customer_id),
	order_date date not null,
	discount decimal,
	totalPrice decimal not null,
	qunatity int not null
);

SELECT * from dbo.Orders;

