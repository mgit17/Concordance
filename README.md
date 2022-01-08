# Instructions

Given an arbitrary text document written in English, write a program that will generate a concordance, labeled
with word frequencies. Bonus: label each word with the sentence numbers in which each occurrence appeared.
A concordance is an alphabetical list of all word occurrences.

# Process
To solve this problem:
* Got user input from console. 
* Read the file with built in file .NET methods. 
* Created a dictionary to save the words, the occurrence and also in what lines the words occured.
* Testing was done running and debugging the console app with valid sample files and also with invalid data to test error handling. Added some unit tests to test the file parsing and also the algorithm to solve the problem.

# Build and run
To run the solution
* Set the Concordance project as Startup project if needed.
* Press F5 or in the Debug Menu, select Start with / without debugging
* Type the sample file name from the Data folder or your own file from another path

To run the unit tests:
FileTests.cs and ServiceTests.cs contain tests to test both areas of the project, mainly using invalid or null data. To run tests
* Go to any of the previously mentioned files.
* Right click when your cursor is inside the test class , or inside the test method and select Run or Debug tests. This can be achived also by using Ctrl + R, T