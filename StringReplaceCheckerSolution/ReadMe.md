# Write a function: 
    class Solution { public string solution(string S, string T); }
that given two string S and T consisting of N and M characters, respectively, 
determines whether string T can be obtained from string S by at most one simple operation
from the set specified below.

The function should return a string: 

-	**"INSERT c"** if string T can be obtained from string S by inserting a single character "c";
-	**"REPLACE c d"** if sting T can be obtained from string S by replacing a single occurrence of character "c" with a single character "d" (these characters should be distinct);
-	**"SWAP c d"** if string T can be obtained from string S by swapping two adjacent  characters "c" and "d" (these characters should be distinct and in the order as is sting S exactly one swap is performed);
-	**"EQUAL"** if no operation is needed (strings T and S are equal);
-	**"IMPOSSIBLE"** if none of the above works. 

Note that by characters "c" and "d" from the operation above, we mean any English alphabet
lowercase letters. 
For example: 
-	given S = "nice" and T = "niece", the function should return **"INSERT e"**;
-	given S = "test" and T = 'tent', the function  should return **"REPLACE s n"**;
-	given S = "form" and T = 'from', the function should return **"SWAP o r"**;
-	given S = "o"and T = "odd", the function should return **"IMPOSSIBLE"**.
	
Assume that: 
    N and M are integers within the range [1..100];
    string S consists only of lowercase letters (a-z);
    sting T consists only of lowercase letters (a-z).

    In your solution, focus on correctness. The performance of your solution will not be 
    the focus of the assessment.
