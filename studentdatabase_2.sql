#create schema `studentdb_test`;

create table `studentinfo` (
    `studentid` int not null AUTO_INCREMENT,
	`password`  varchar(50) not null,
    `fname` varchar(50) null,
    `lname` varchar(50) null,
    `phonenum` int null,
    `DOB` varchar(50) null,
    `gender` varchar(50) null,
    primary key (`studentid`));
    
create table `department` (
    `deptid` int not null,
    `deptname` varchar(50) null,
    primary key (`deptid`));
    
create table `course` (
    `courseid` int not null,
    `cname` varchar(50) null,
    `instructor` varchar(50) null,
    `deptid` int null,
    primary key (`courseid`),
    foreign key (`deptid`) references department(`deptid`));
    
create table `instructor` (
    `iid` int not null,
    `name` varchar(50) null,
    `email` varchar(50) null,
    `phone` int null,
    `deptid` int null,
    primary key (`iid`),
    foreign key (`deptid`) references department(`deptid`));
    
create table studentcourse (
    studentid int,
    courseid int,
    primary key (studentid, courseid),
    foreign key (studentid) references studentinfo(studentid),
    foreign key (courseid) references course(courseid));
    
INSERT INTO `studentdb_test`.`studentinfo` (`password`, `fname`, `lname`, `phonenum`, `DOB`, `gender`) VALUES ('Green', 'Mario', 'Mario', '555-555-5555', '3023', 'Male');
