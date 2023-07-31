// See https://leetcode.com/problems/valid-parentheses for details about question
using System.Runtime.InteropServices;

var sol = new Solution();
var input = "(){}}{";
//var input = "(){}";
Console.WriteLine(sol.IsValid(input));
 
public class Solution
{
    private readonly Stack<char> _parenthesesStack = new();
    public bool IsValid(string str)
    {
        char[] parenthesesArray = str.ToCharArray();
        if(parenthesesArray.Length == 1) {
            return false;
        }
        foreach (char parentheses in parenthesesArray)
        {
            var popResult = true;
            switch (parentheses)
            {
                case '(':
                case '{':
                case '[':
                    _parenthesesStack.Push(parentheses);
                    break;
                case ')': { popResult = _parenthesesStack.Count > 0 && _parenthesesStack.Pop() == '('; break; };
                case ']': { popResult = _parenthesesStack.Count > 0 && _parenthesesStack.Pop() == '['; break; };
                case '}': { popResult = _parenthesesStack.Count > 0 && _parenthesesStack.Pop() == '{'; break; };
                default: return false;
            }

            if(!popResult) { return false;}
        }

        return _parenthesesStack.Count == 0;
    }
}
