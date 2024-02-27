CREATE DATABASE QuanLy;

USE QuanLy;

CREATE TABLE Groups (
    GroupID INT PRIMARY KEY,
    GroupName VARCHAR(50)
);

CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    UserName VARCHAR(50),
    GroupID INT,
    FOREIGN KEY (GroupID) REFERENCES Groups(GroupID)
);

INSERT INTO Groups (GroupID, GroupName)
VALUES
    (1, 'Member'),
    (2, 'Moderator'),
    (3, 'Super Moderator'),
    (4, 'Admin');

INSERT INTO Users (UserID, UserName, GroupID)
VALUES
    (1, 'Adon', 1),
    (2, 'Akuma', 2),
    (3, 'Balrog', 1),
    (4, 'Bison', 4),
    (5, 'Blanka', 1),
    (6, 'Cammy', 2),
    (7, 'ChunLi', 3),
    (8, 'Cody', 2),
    (9, 'Dan', 1),
    (10, 'DeeJay', 2);
