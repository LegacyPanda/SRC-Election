# STC Election 

## To do
- Implement a program to view the number of votes for the upcoming SRC election
- The use must be able to choose which campus along with the number of voters from each campus
- Calculate and display to total number of voters.
- Calculate and display the average number of voters.
- Display the campus with the highest number of voters.
- Display the campus with the lowest number of voters.

## 2025-01-10
- I understood why our lectures suggested working with 1 as the first index.
- The thing I was struggling with was choosing the proper position because I was working with 0 in strCampus.
- The solution was use a sort of null in that index.
- In VB null can be expressed as Nothing.
- Another issue was that the user could only input upper case but the solution was using ToUpper() or ToLower()