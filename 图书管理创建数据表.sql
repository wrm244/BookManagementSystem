CREATE DATABASE IF NOT EXISTS library DEFAULT CHARSET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE library;

/***************************************************************************
1：创建用户表payment表及插入数据 booksinfo(UserName,Sex,IDCardNumber,WorkUnit,PhoneNumber,UserID,SigninTime)
*******************************************************************************/

CREATE TABLE users(
    Power CHAR(10),
	UserName CHAR(15),
	StudentName CHAR(15),##名字
	Sex CHAR(5),	##性别
	Password CHAR(16),
	WorkUnit CHAR(15),	##工作单位
	PhoneNumber CHAR(11),
	UserID CHAR(15),
	SigninTime CHAR(25),
	PRIMARY KEY (UserName)
);
drop table users;

INSERT INTO library.users (Power,UserName, StudentName, Sex, Password, WorkUnit, PhoneNumber, UserID, SigninTime) VALUES ('普通用户','2000500927', '吴河山', '男', '778899', '计算机科学与技术', '15260135211', '2000500927', '2022年5月18日 0:00:00');
INSERT INTO library.users (Power,UserName, StudentName, Sex, Password, WorkUnit, PhoneNumber, UserID, SigninTime) VALUES ('普通用户','test1', '王小龙', '男', '778899', '计算机与信息安全', '15260254566', 'test1', '2022年5月18日 0:00:00');
INSERT INTO library.users (Power,UserName, StudentName, Sex, Password, WorkUnit, PhoneNumber, UserID, SigninTime) VALUES ('普通用户','test2', '黄岚', '女', '778899', '商学院', '15245654323', 'test2', '2022年5月18日 0:00:00');
INSERT INTO library.users (Power,UserName, StudentName, Sex, Password, WorkUnit, PhoneNumber, UserID, SigninTime) VALUES ('普通用户','test3', '冬梅', '女', '778899', '计算机与信息安全', '15268372634', 'test3', '2022年5月18日 0:00:00');
INSERT INTO library.users (Power,UserName, StudentName, Sex, Password, WorkUnit, PhoneNumber, UserID, SigninTime) VALUES ('普通用户','text4', 'text', '男', '778899', '计算机', '15260135211', 'text4', '2022年5月18日 0:00:00');

/***************************************************************************
2：创建书本信息表booksinfo表及插入数据 booksinfo(书名,类别,语种,原名,编号,索书号,作者,ISBN号,译者,出版时间,出版社,内容摘写)
*******************************************************************************/

CREATE TABLE booksinfo(
	书名 CHAR(50),
	类别 CHAR(15),
	语种 CHAR(10),
	原名 CHAR(55),
	编号 CHAR(20),
	索书号 CHAR(20),
	作者 CHAR(25),
	ISBN号 CHAR(30),
	译者 CHAR(25),
	出版时间 CHAR(15),
	出版社 CHAR(25),
	内容摘写  CHAR(200),
	PRIMARY KEY (书名,编号)
);
drop table booksinfo;


/***************************************************************************
3：创建借阅信息表loaninfo表及插入数据 loaninfo(图书编号,书名,借阅人,借阅时间,应归还时间,是否归还,归还时间)
*******************************************************************************/
CREATE TABLE loaninfo(
	图书编号 CHAR(15),
	书名 CHAR(30),
	借阅人 CHAR(15),
	借阅时间 CHAR(40),
	应归还时间 CHAR(30),
	是否归还 CHAR(15),
	归还时间 CHAR(40),
	foreign key (书名,图书编号) REFERENCES booksinfo(书名,编号),
	foreign key (借阅人) REFERENCES users(UserName)
);
drop table loaninfo;
/***************************************************************************
4：创建审计表loginrecord表及插入数据 loginrecord(UserName,LoginTime)
*******************************************************************************/


CREATE TABLE loginrecord(
	UserName CHAR(10),
	LoginTime CHAR(25)
);
drop table loginrecord;


/***************************************************************************
5：创建管理员表admin表及插入数据 admin(AdminName,Password)
*******************************************************************************/
CREATE TABLE admin(
	AdminName CHAR(10),
	Password CHAR(16),
	primary key (AdminName)
);