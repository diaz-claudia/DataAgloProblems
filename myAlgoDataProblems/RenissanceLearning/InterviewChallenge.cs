using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.RenissanceLearning
{
   public class InterviewChallenge
    {
        //Your specific task on the team is to design and implement the function that returns
        //the change due to the customer in the least number of coins possible.
        //The only contract requirement is that your method must accept an input integer, 0 – 99,
        //of the change that is to be returned. The register only supports pennies, nickels, dimes, and quarters.
        //Your response should indicate the number of each coin needed.

        // the number
        //a series of if statement 
        // 
        public int[] getChange( int num)
        {
            int[] change = new int[] { 0, 0, 0, 0 };
            int quarter = 25;
            
            int numberOfQuarter = num/ quarter;
            change[0] = numberOfQuarter;
            int remainderOne = num % quarter;

           
            // num/quarter = remiander1 
                    //push to the array the answer at postion 3
            //remanider1 / dime = remainder2 
            //  //push to the aray the answer at the respective positon 
            //remainder 2/nickel = remainder 3

            //if (nums ==25|| nums = 50 || nums =25
            //

            return change; 
        }



    }
}
