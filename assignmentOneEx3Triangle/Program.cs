using System;
using System.Diagnostics;

namespace assignmentOneEx3Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize
            string p;
            int N;
            int n;
            int numofstars;
            string stars;
            int numofspaces;
            string spaces;

            //Pseudocode
            p = "Pseudo code for inverted triangle. Input is an integer, say N\n";
            p = p + "Number of stars follow the pattern of 1,3,5,7 from bottom to top, it is 2n-1 stars\n";
            p = p + "Use a loop to start from N and decrement till 1, each time create a string that contains 2N-1 stars and print it\n";
            p = p + "Add space to center the stars. Number of spaces on either side is (Top most layer (2N-1) stars minus each layer (2n-1) stars)/2\n";
            Debug.WriteLine(p);

            //Read input
            //N = 5;
            Debug.WriteLine("Enter the number to print inverse triangle: ");
            N = int.Parse(Console.ReadLine());
            n = N;
            //Iteration
            
            while (n > 0) //Repeat the loop until N reaches 1
            {
                stars = "";
                spaces = "";
                numofstars = (2 * n) - 1; //Number of stars for the line N
                for (int i=1; i<numofstars+1; i++)
                {
                    stars = stars + "*"; //Create a string by concatenating stars equal to a measure calculated above for numofstars
                }
                numofspaces = (((2 * N) - 1) - ((2 * n) - 1)) / 2;
                for (int j=1; j<numofspaces+1;j++)
                {
                    spaces = spaces + " "; //Create a string by concatenating spaces equal to a measure calculated above for numofspaces
                }
                Debug.WriteLine(spaces+stars); //print the string of stars to console
                n = n - 1; //Decrement the input value N by 1 to restart the while loop
            }

            p = "Learnings and Recommendations\n";
            p = p + "1. Invisible things like spaces need to be considered while thinking of logic. Negative of what we are able to see also to be considered.\n";
            p = p + "2. Memorizing the basic mathematical formulas is helpful. In this case, knowing the formula for odd numbers already is helpful and saved time.\n";
            p = p + "3. Proof reading the code before running is helpful\n";
            p = p + "4. It is recommended to practise all types of string operations\n";
            Debug.WriteLine(p);

        }
    }
}