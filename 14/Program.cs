// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new Solution();
var input = new string[] {"dog","racecar","car" };
var result = sol.LongestCommonPrefix(input);

System.Console.WriteLine(result);

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        char[] refernceArray = strs[0].ToCharArray();

        var strsToCompare = strs.Skip(1).ToArray();

        foreach(string str in strsToCompare) {
            char[] charArray = str.ToCharArray();
            
            var minLength = Math.Min(charArray.Length, refernceArray.Length);
            Console.WriteLine($"{str} " + minLength);
            int i = 0;
            for(i = 0; i < minLength; i++) {
                // Console.WriteLine(i + " " + charArray[i] + " " + refernceArray[i] );
                Console.WriteLine( charArray[i] + " " + refernceArray[i] );
                if(charArray[i] != refernceArray[i]) {
                    Console.WriteLine("Mismatch at " + i);
                    refernceArray = refernceArray.Take(i).ToArray();
                    break;
                }
                Console.WriteLine("outside if " + i + " " + minLength);
            }

            Console.WriteLine("outside for " + i + " " + minLength);

            if( i == minLength ) {
                Console.WriteLine("Truncating to minLength");
                refernceArray = refernceArray.Take(minLength).ToArray();
            }
        }
        
        return new string(refernceArray);
    }
}