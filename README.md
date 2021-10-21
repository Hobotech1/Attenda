# Attenda
this project is an attendance register.
run script.sql on your local sql instance to create the database.
you can find this file inside the Attenda folder where all the files are.
you can run the app from visual studio 2019. 
when the app launches, first register yourself as a user (teacher).
login and go to the Admin tab of the form.
add the name of the class that you will be teaching e.g. Maths.
add students to the class. please give the each student a different studentid. 
i did not implement this to validate on the system but using the same studentid for more than one student does result in exceptions later.
the relationships between tables are not enforced in the db hence the system is requiring you to typed in studentid and classid.
fill in all the columns in the Add Students datagrid. 
you might need to log out and back in to see the new students.
go to the attendance tab and click on Show Class List to view the students you added for that specific class.
mark each student either present or absent by typing either 'p' or 'a' in the Status column of the datagrid.
click on Save Attendance to save your changes.
you can clear the status by clicking on the Clear button.
go to the Reports tab to view the monthy and daily report based on the class and date you select.
play around and try to break the system.
it is a mere prototype meant to show a basic understanding of c#.
there's no validation so expect some system generated errors.
the app connects to the database via adapters.
