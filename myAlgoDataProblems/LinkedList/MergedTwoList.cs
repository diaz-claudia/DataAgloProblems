using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.LinkedList
{
    internal class MergedTwoList
    {/*
        public LinkedListNode<int> MergeTwoLists(LinkedListNode<int> list1, LinkedListNode<int> list2)
        {
            
            LinkedListNode<int> head = new LinkedListNode<int>(0);
            LinkedListNode<int> tail = head;

            while (list1 != null && list2 != null)
            {
                if (list1.Value < list2.Value)
                {
                    tail.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    tail.Next = list2;
                    list2 = list2.Next;
                }
                tail = tail.Next;

            }
            if (list1 == null)
            {
                tail.Next = list2;
            }
            else if (list2 == null)
            {
                tail.Next = list1;
            }
            return head.Next;



        }
        */
    }
}
