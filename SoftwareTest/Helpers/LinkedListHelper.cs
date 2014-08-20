using System;

namespace SoftwareTest.Helpers
{
    public static class LinkedListHelper
    {
        public static int GetElementAt(LinkedList<int> linkedList, int index)
        {
            int n = index; ;
            var end = -n;

            var start = linkedList.First;
            var chase = linkedList.First;

            do
            {
                end++;
                start = start.Next;
                if (end > 0)
                {
                    chase = chase.Next;
                }
                if (start == null)
                {
                    return chase.Item;
                }
            } while (true);

        }

        public static string GetElementAt(LinkedList<string> linkedList, int index)
        {
            int n = index; ;
            var end = -n;

            var start = linkedList.First;
            var chase = linkedList.First;

            do
            {
                end++;
                start = start.Next;
                if (end > 0)
                {
                    chase = chase.Next;
                }
                if (start == null)
                {
                    return chase.Item;
                }
            } while (true);

        }
    }
}

