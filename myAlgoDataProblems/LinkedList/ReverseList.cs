using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.LinkedList
{
    public class ReverseList
    {


        //[1,2,3]
        public ListNode ReversedList(ListNode head)
        {

            ListNode previous = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode nextNode = current.next; //nextnode = 2                //next node = 3             //nextNode == null
                current.next = previous;  //1 is now pointing to null           //2 is now pointing to 1    //3 is now pointing to 2
                previous = current; // previous = 1                              // previous =2              //previous =3
                current = nextNode; // current is 2                             // current is 3             // current is null
            }
            return previous.next ;
           // 3 ,2,1,    
           

        }
    }
}

