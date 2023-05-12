using System;
// explain this code here
namespace SolutionNamespace
{
    class C_21_Merge_Two_Sorted_Lists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode tail = dummyHead;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }

            if (list1 != null)
                tail.next = list1;
            else
                tail.next = list2;

            return dummyHead.next;
        }
    }
}

