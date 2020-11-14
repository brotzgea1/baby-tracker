My console app is used for tracking stats for your baby.  The whole thing is run through a master loop that pulls up a list of options.  The loop is tied to my other methods so that when a user selects something the appropriate method runs.  I have one method that adds a new profile to the list. Another that checks to see if the profile exists.  A third that allows you to add new measurements and then calculate how much the profile has grown.  Finally a method that calculates age based on the current date and previously given data.  Each function clears the console until the prompts have finished and then displays the pertinent information for 5 seconds, then returning to the master loop.

Ultimately, I would not consider this to be a finished application as it would ideally be tied to a JSON file that would then keep permanent records of each profile. As it stands, I have instantiated several profiles already and others can be added when used, but not stored permanently.  I would also like to add a list of feedings tied to specific profiles.  This would keep track of how much and and for how long the baby feeds, measuring how each either increase or decrease.  Time permitting I will add.

Features:
1. Master Loop - runs a function that calls switch statement menu. stays active until user exits.
2. Create a list, populate it, and retrieve - this is essentially the essence of my program.  
3. Calculate and display data based on an external factor - my HowOld function uses the profile's birthdate and calculates the user's age, based on the current date, in years/months/days.

Notes:

My master list is pre-populated with three profiles: Andrew, Silas, and Lindsay.  These are the instantiation of my class.  Their information can be displayed using "Profile Search", and manipulated in "Add new measurements" and "Calculate Age."

The best example of utilizing a return value from one of my four functions is within the DisplayMenu function.  It returns true by defualt and the loop runs until it returns false. Each switch, except for the exit switch, returns true when used keeping the loop running.