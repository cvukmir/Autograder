Christopher Vukmir
CSCI 671
5/7/2023
ArcticAG-Server

- This progam acts as the server to recieve files from the client view
- To run this program, either run in VS or use the .exe of this project to start.
- Upon opening, the command window will ask for a directory location to store the assignments it recieves.
	-> This directory is the assignment related to the one that was created in the admin view.
- After selecting this location, the window will try to find an IP address to start the server on.
	-> If it finds an avaiable IP address, it will prompt to ask whether it is correct or not.
		-> If not correct, the user will be promted to enter a new IP address
	-> If no available IP address is found, it will ask the user to enter one.
- Once complete, the server will now be set up and available to connect to from outside networks.