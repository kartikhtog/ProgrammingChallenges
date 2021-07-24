using System.Collections.Generic;

public class ConvertRomanToInterger
{
    public int RomanToInt(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }
        s = s.ToUpper();
        var queue = new Queue<int>();
        foreach(var c in s)
        {
            queue.Enqueue(RomanLetterToInt(c));
        }
        var sum = 0;
        var current = queue.Dequeue();
        while (queue.Count > 0)
        {
            if (queue.Peek() > current)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }
            current = queue.Dequeue();
        }
        sum += current;
        return sum;

    }

    private int RomanLetterToInt(char c)
    {
        var returnValue = 0;
        switch(c)
        {
            case 'M':
                returnValue =  1000;
                break;
            case 'D':
                returnValue = 500;
                break;
            case 'C':
                returnValue = 100;
                break;
            case 'L':
                returnValue = 50;
                break;
            case 'X':
                returnValue = 10;
                break;
            case 'V':
                returnValue = 5;
                break;
            case 'I':
                returnValue = 1;
                break;
            default:
                returnValue = 0;
                break;
        }
        return returnValue;
    }
}