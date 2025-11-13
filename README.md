	This application was developed using some packages that you may need to install in your Visual Studio IDE in order
	for it work properly. They are:
		- EntityFrameWorkCore (version 10.0.0): used to map and model the local database.
		- EntityFrameWorkCore.InMemory (version v10.0.0): used to store data locally in memory, without the need to set a database.
		- xUnit (version v2.9.2): used to develop the unit tests for the classes and methods.
		- .NET.Test.SDK (version v17.12.0): responsible to run the unit tests.
	
	Once these dependencies are installed the application should run without further problems.
	
	The web interface developed is very simple:

		- The home page is where all stored vehicles are displayed, if there is no previous saved data the page will
		  show a "No records to display yet." message.

		- To add a vehicle, you must click over the "Add Vehicle" option on the top left of the home page, near the "Home" button 
		  and the page title. This will redirect you to a new page where you can input the vehicle information, as the "Chassis Series", "Chassis Number"...

		- All fields are required to be fulfilled. 

		- Once all data is input, you can save the vehicle by clicking the "Save" button. The page will refresh and show a brief message informing if the 
		  vehicle was successfully saved. If you try to save a new vehicle with existing chassis info from another previously existing vehicle,
		  the page will display a message informing that another vehicle with the same caracteristics already exists.

		- After having some vehicles stored, if you return to the home page, all of them will be displayed with a button to edit their info.

		- If needed, you can to look up for a specific vehicle, just by filling the "CHASSIS SERIES" AND "CHASSIS NUMBER" fields at the 
		top right corner, with the correct information, and then pressing "Search Vehicle". If there is a record of said vehicle, only its register will 
		appear in the home page, else, the message "No records to display yet." will be displayed.

		- To display all the registries again you can press the "Home" button, or the "Search Vehicle" button with the fields "CHASSIS SERIES" and
		"CHASSIS NUMBER" being empty.

		- After finding the vehicle of choice, to alter its data, just click on the "Edit" button on the right side of the table, near the vehicle color.

		- Once in the edit page, all vehicle information will be displayed, including its current color. To change the color of the vehicle, inform 
		the new color on the "New Color" field and click "Save". You will be taken to the home page, where the vehicle and its new color can be displayed.
		A message informing that the changes where applied will be shown.