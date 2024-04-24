create or replace view `temp` as 
select  course.courseid as CourseId,course.cname as Course, instructor.name as Teacher ,department.deptname as Department
	from course
left outer join studentcourse
	on course.courseid = studentcourse.courseid
left outer join studentinfo
	on studentcourse.studentid = studentinfo.studentid
left outer join instructor
	on instructor.iid = course.instructor
left outer join department
	on department.deptid = course.deptid
where studentcourse.studentid = 1; # change the 1 to the username that just logged 


select course.* 
	from course
where courseid not in (select CourseId from temp);

drop view `temp`;