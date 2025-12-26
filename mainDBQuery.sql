create table userData
(
userID int primary key identity(1,1),
Username nvarchar(50),
Email nvarchar(50),
Password nvarchar(50),
Role nvarchar(20)
)

create table customer
(
customerID int primary key identity(1,1),
userID int foreign key references userData(userID),
Feedback nvarchar(50),
totalPrice int,
[date] date
)

create table reservation
(
customerID int foreign key references customer(customerID),
amountPeople int, 
eventDate date,
eventHall nvarchar(50)
)

create table menu
(
menuID int identity (1,1),
foodItem nvarchar(50) primary key,
price int
)

create table [order]
(
orderID int primary key identity (1,1),
foodItem nvarchar(50) foreign key references menu(foodItem),
customerID int foreign key references customer(customerID)
)

create table Chef
(
chefID int identity (1,1),
userID int foreign key references userData(userID),
orderID int foreign key references [order](orderID),
timeTaken datetime,
timeCompleted datetime
)

create table inventory
(
invID int identity(1,1),
ingredient nvarchar(50),
amount int,
lastRestock date
)

create table sales
(
sales int, 
[date] date
)

insert into userData (Username, Email, Password, Role) values 
('Adlina', 'Adlina@mail.com', 'ad123', 'Admin'),
('Zhi', 'Zhi@mail.com', 'z123', 'Manager'),
('Lim', 'Lim@mail.com', 'lim123', 'Chef'),
('Tayyeba', 'Tayy@mail.com', 'tayy123', 'Customer');

alter table menu






