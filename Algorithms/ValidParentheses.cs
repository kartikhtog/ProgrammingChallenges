using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ValidParentheses
    {
        private char OppositeOfForwardBracket(char c)
        {
            var opposite = '\0';
            switch (c)
            {
                case '(':
                    opposite = ')';
                    break;
                case '[':
                    opposite = ']';
                    break;
                case '{':
                    opposite = '}';
                    break;
            }
            return opposite;

        }
        private bool IsBracketType(char c)
        {
            var isTrue = false;
            switch (c)
            {
                case '(':
                    isTrue = true;
                    break;
                case '[':
                    isTrue = true;
                    break;
                case '{':
                    isTrue = true;
                    break;
                case ')':
                    isTrue = true;
                    break;
                case ']':
                    isTrue = true;
                    break;
                case '}':
                    isTrue = true;
                    break;
            }
            return isTrue;
        } 
        private bool IsForwardBracketType(char c)
        {
            var isTrue = false;
            switch (c)
            {
                case '(':
                    isTrue = true;
                    break;
                case '[':
                    isTrue = true;
                    break;
                case '{':
                    isTrue = true;
                    break;
            }
            return isTrue;
        }
        public bool IsValid(string s)
        {
            var isValid = true;
            var stack = new Stack<char>();
            foreach(var character in s)
            {
                if (IsBracketType(character))
                {
                    if (stack.Count > 0 && OppositeOfForwardBracket(stack.Peek()) == character)
                    {
                        stack.Pop();
                    }
                    else if (IsForwardBracketType(character))
                    {
                        stack.Push(character);
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if (stack.Count > 0)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
