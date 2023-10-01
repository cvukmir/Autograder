Christopher Vukmir
CSCI 671
5/7/2023
ArcticAG-Client

- This progam acts as the student or "client" view for the autograder
- To run this program, either run in VS or use the .exe of this project to start.
- Upon entering the main menu, the user is prompted with entering:
	-> A IP address of the server.
	-> A Port number for the server.
	-> Their username.
	-> Their password.
- Upon entering and submitting their information, the program will verify with the server whether
	their information is correct.
- If not correct, the user will be prompted to enter again.
- If the information is correct, the next panel containing the following will appear:
	-> The avaiable assignments.
	-> The location of the assignment on the users drive to submit (in .zip format)
- After entering this information, a verification panel will appear.
- After verifying the information is correct, the user will submit and their program will be executed.
- The program is sent to the server and returns the grade of the program.
- Once finished, the user can either close the dialog or submit another assignment.