#create schema `studentdb_test`;

# Dropping the tables for ease of reset
#DROP TABLE `studentdb_test`.`course`, `studentdb_test`.`department`, `studentdb_test`.`instructor`, `studentdb_test`.`studentcourse`, `studentdb_test`.`studentinfo`;

create table `studentinfo` (
    `studentid` int not null AUTO_INCREMENT,
	`password`  varchar(50) not null,
    `fname` varchar(50) null,
    `lname` varchar(50) null,
    `phonenum` varchar(50) null,
    `DOB` varchar(50) null,
    `gender` varchar(50) null,
    primary key (`studentid`));
    
create table `department` (
    `deptid` int not null AUTO_INCREMENT,
    `deptname` varchar(50) null,
    primary key (`deptid`));
    
create table `course` (
    `courseid` int not null AUTO_INCREMENT,
    `cname` varchar(50) null,
    `instructor` varchar(50) null,
    `deptid` int null,
    primary key (`courseid`),
    foreign key (`deptid`) references department(`deptid`));
    
create table `instructor` (
    `iid` int not null AUTO_INCREMENT,
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

# creating dummy data
	# studtnes
INSERT INTO `studentdb_test`.`studentinfo` (`password`, `fname`, `lname`, `phonenum`, `DOB`, `gender`) VALUES ('Green', 'Mario', 'Mario', '555-555-5555', '1/2/3023', 'Male');
INSERT INTO `studentdb_test`.`studentinfo` (`password`, `fname`, `lname`, `phonenum`, `DOB`, `gender`) VALUES ('Blue', 'Toad', 'Blue', '555-555-5555', '5/12/100', 'Toad');
INSERT INTO `studentdb_test`.`studentinfo` (`password`, `fname`, `lname`, `phonenum`, `DOB`, `gender`) VALUES ('Luigi', 'Luigi', 'Mario', '555-555-5555', '1/1/2023', 'Luigi');

	# departments
INSERT INTO `studentdb_test`.`department` (`deptid`, `deptname`) VALUES ('1', 'science');
INSERT INTO `studentdb_test`.`department` (`deptid`, `deptname`) VALUES ('2', 'Math');
INSERT INTO `studentdb_test`.`department` (`deptid`, `deptname`) VALUES ('3', 'Music');
INSERT INTO `studentdb_test`.`department` (`deptid`, `deptname`) VALUES ('4', 'Compouter Science');

	# teachers
INSERT INTO `studentdb_test`.`instructor` (`name`, `email`, `phone`, `deptid`) VALUES ('red', 'a@gmail.com', '555', '1');
INSERT INTO `studentdb_test`.`instructor` (`name`, `email`, `phone`, `deptid`) VALUES ('blue', 'b@gmail.com', '555', '2');
INSERT INTO `studentdb_test`.`instructor` (`name`, `email`, `phone`, `deptid`) VALUES ('green', 'c@gmail.com', '555', '3');
INSERT INTO `studentdb_test`.`instructor` (`name`, `email`, `phone`, `deptid`) VALUES ('purple', 'd@gmail.com', '555', '4');
	
	# courses
INSERT INTO `studentdb_test`.`course` (`cname`, `instructor`, `deptid`) VALUES ('programing 1', '4', '4');
INSERT INTO `studentdb_test`.`course` (`cname`, `instructor`, `deptid`) VALUES ('songs 2', '3', '3');
INSERT INTO `studentdb_test`.`course` (`cname`, `instructor`, `deptid`) VALUES ('numbers', '2', '2');
INSERT INTO `studentdb_test`.`course` (`cname`, `instructor`, `deptid`) VALUES ('gravity', '1', '1');
INSERT INTO `studentdb_test`.`course` (`cname`, `instructor`, `deptid`) VALUES ('programing 2', '4', '4');
INSERT INTO `studentdb_test`.`course` (`cname`, `instructor`, `deptid`) VALUES ('numbers 2', '3', '3');

	# setting up course student stuff
		# mario
insert into studentcourse(`studentid`,`courseid`) VALUES ('1','1');
insert into studentcourse (`studentid`,`courseid`) VALUES ('1','3');
insert into studentcourse (`studentid`,`courseid`) VALUES ('1','4');
		# toad
insert into studentcourse (`studentid`,`courseid`) values ('2','1');
insert into studentcourse (`studentid`,`courseid`) values ('2','6');
		# luigi
insert into studentcourse (`studentid`,`courseid`) values ('3','3');
insert into studentcourse (`studentid`,`courseid`) values ('3','2');
insert into studentcourse (`studentid`,`courseid`) values ('3','6');