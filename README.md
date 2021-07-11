# ISPYZU
ASP.net   International Student Portal in Yangzhou university.
![alt text](https://github.com/TeamV5/ISPYZU/blob/main/Pictures/gitup.png?raw=true)

This is Home page design , there anyone can look at the courses, Running courses,Colleges and others. Then, client can press the login button in the right corner.

Then we have the Login page.
![alt text](https://github.com/TeamV5/ISPYZU/blob/main/Pictures/login.png?raw=true)

Then we have the Use case Diagram.

Use case diagrams are considered for high level requirement analysis of a system. So when the requirements of a system are analyzed the functionalities are captured in use cases. So we can say that uses cases are nothing but the system functionalities written in an organized manner.Now the second things which are relevant to the use cases are the actors. Actors can be defined as something that interacts with the system. The actors can be human user, some internal applications or may be some external applications. So in a brief when we are planning to draw an use case diagram we should have the following items identified. 
![alt text](https://github.com/TeamV5/ISPYZU/blob/main/Pictures/UseCase.jpg?raw=true)

Next we have the database.

![alt text](https://github.com/TeamV5/ISPYZU/blob/main/Pictures/DBmodel.png?raw=true)
This is the database we designed for our project.
Link- https://dbdesigner.page.link/ubYfAaUS4jRdKoyk8
Admin is a individual there is no connection with the database , But in the project admin can control over every model.


There admin’s id is identity and auto incremented but in the student , teacher,college and other table their id must be insert manually. For avoiding conflicts we did that. But in future we will add more complex functionality.
Every table is connected each other through the foreign key except admin.

Then we have the class diagram.
![alt text](https://github.com/TeamV5/ISPYZU/blob/main/Pictures/ClassDiagram.png?raw=true)

This class diagram has many classes Login, create,details and Updatedetails,delete in database. Student is the class name. Its attributes are name, "StudentId, “Name”,”gender”,”majorId” etc.There is more classes like admin, teacher, major,college,courses The operations performed in the classes, Store database and Update and delete. 


Then we have the ER diagram.
This is System create for the Admin. He can stores the University Database details
about university students, Teacher, Courses, Running Courses, Colleges, Majors and Course Enrollment. Result, A student took a particular course and what degree program each student Or Teacher is enrolled in. The database is a long way from one that’d be suitable for a large tertiary institution;Consider the following requirements: The University offers one or more programs. A program is made up of one or more courses. A student must enroll in a program. A student takes the courses that are part of the program. A program has a name, a program identifier,  and the session year it commenced. Each course in a program is sequenced into a session year .
![alt text](https://github.com/TeamV5/ISPYZU/blob/main/Pictures/ER_Diagram.png?raw=true)
