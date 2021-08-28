using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class InsertNodeAtTail
	{
		public class SinglyLinkedListNode
		{
			public int data;
			public SinglyLinkedListNode next;
			public SinglyLinkedListNode() { }
			public SinglyLinkedListNode(int data, SinglyLinkedListNode next = null)
			{
				this.data = data;
				this.next = null;

			}
		}

		public SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
			var tail = new SinglyLinkedListNode(data);
			if (head != null)
			{
				SinglyLinkedListNode next = head;
				while(next.next != null)
				{
					next = next.next;
				}
				next.next = tail;
			}
			else
			{
				head = tail;
			}
			return head;
        }
		
	}
}
