Use master;
Go

drop database if exists Chores;

create database Chores;
Go

Use Chores;
Go

Begin Transaction;

Create Table users
(
	userId int,
	userName varchar(25) not null,
	Constraint pk_users Primary Key (userId)
)
Create Table chores
(
	choresId int identity(1,1),
	chore_title varchar(50)not null,
	chore_description varchar(max)not null,
	chore_payout money
Constraint pk_chores Primary Key(choresId)
)
Create Table payout
(
	transactionId int identity(10000,1),
	userId int,
	choresId int,
Constraint pk_payout Primary Key(transactionId),
Constraint fk_payout_users Foreign Key(userId) references users(userId),
Constraint fk_payout_chores Foreign Key(choresId) references chores (choresId)
)
Commit