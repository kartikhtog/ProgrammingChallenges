public class MergeLists
{
    public int IndexOfLowestInt(ListNode[] lists)
    {
        var indexOfLowest = -1;
        var lowValue = int.MaxValue;
        var currentIndex = 0;
        foreach(var list in lists)
        {
            if (list != null && list.val <= lowValue)
            {
                lowValue = list.val;
                indexOfLowest = currentIndex;
            }
            currentIndex++;
        }
        return indexOfLowest;
    }
 
    public ListNode MergeKLists(ListNode[] lists)
    {
        var mergedListNode = new ListNode();
        var currentNext = mergedListNode;
        var indexOfMin = IndexOfLowestInt(lists);
        if (indexOfMin != -1)
        {
            currentNext.val = lists[indexOfMin].val;
            lists[indexOfMin] = lists[indexOfMin].next;
        }
        else
        {
            mergedListNode = null;
        }
        while (true)
        {
            indexOfMin = IndexOfLowestInt(lists);
            if (indexOfMin != -1)
            {
                currentNext.next = new ListNode(lists[indexOfMin].val);
                currentNext = currentNext.next;
                lists[indexOfMin] = lists[indexOfMin].next;
            }
            else
            {
                break;
            }
        }
        return mergedListNode;
    }
}
