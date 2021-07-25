
namespace Algorithms
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode Insert(params int[] items)
        {
            var currentNext = this;
            if (currentNext != null)
            {
                while (true)
                {
                    if (currentNext.next == null)
                    {
                        break;
                    }
                    currentNext = currentNext.next;
                }
            }
            foreach (var item in items)
            {
                currentNext.next = new ListNode(item);
                currentNext = currentNext.next;
            }
            return this;
        }
    }
}
