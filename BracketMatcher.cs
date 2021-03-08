using System;
using System.Collections;

namespace MatchingBrackets
{
    public static class BracketMatcher
    {
        public static bool HasMatches(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            
            var stack = new Stack();
            try
            {
                foreach (var ch in str)
                {
                    switch (ch)
                    {
                        case '{':
                            stack.Push(ch);
                            break;
                        case '}':
                            stack.Pop();
                            break;
                        default:
                            continue;
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                // Stack was empty when a pop was attempted
                return false;
            }
            
            return stack.Count == 0;
        }
    }
}