using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;
using System;
using System.Security;


class Program
{
    static void Main()
    {

        //string[] texting = {"baba","good" };
        //occunrences(texting);
        Console.WriteLine(FindPalindrone("ghhggh"));
        //PalindroneReverse("madam");
    }

    static void PalindroneReverse(string p)
    {
        string temp = string.Empty;
        for(int i =p.Length-1;i>=0;i--)
        {
            temp = temp + p[i];
            //Console.WriteLine(temp);
        }
        if(temp == p)
        {
            Console.WriteLine(temp);

        }
    }
    static bool IsPalindroneCheck(char[] ch)
    {
        return ch[0] == ch[3] && ch[1] == ch[2];
        
    }

    //

    
    static int FindPalindrone(string s)
    {
        int a = 0;
        int b = 1;
        int c= 2;
        int d = 3;
        int count = 0;
        char[] chars = s.ToCharArray();
        int sLen = s.Length;
        
        if (sLen < 4) return 0;

        if (IsPalindroneCheck(new char[] { chars[a],chars[b],chars[c],chars[d]}))
        {
            count++;
        }

        while (a < sLen - 4)
        {
            
            while (b < sLen-3) {
            
                while (c < sLen-2) {
                    

                    while (d< sLen-1)
                    {
                        
                        d++;
                        if (IsPalindroneCheck(new char[] { chars[a], chars[b], chars[c], chars[d] }))
                        {
                            count++;
                        }
                    }

                    c++;
                    d = c + 1;
                    if (IsPalindroneCheck(new char[] { chars[a], chars[b], chars[c], chars[d] }))
                    {
                        count++;
                    }

                }
                b++;
                c = b + 1;
                d= c + 1;
                if (IsPalindroneCheck(new char[] { chars[a], chars[b], chars[c], chars[d] }))
                {
                    count++;
                }
            }
            a++;
            b = a + 1;
            c= b + 1;
            d= c + 1;
            if (IsPalindroneCheck(new char[] { chars[a], chars[b], chars[c], chars[d] }))
            {
                count++;
            }
        }

        return count;









        /*
        for(int a = 0; a < sLen - 3; a++)
        {
            

            for(int b = a+1; b < sLen - 2; b++)
            {
              
                for(int c = b+1; c < sLen - 1; c++)
                {
                    
                   for (int d = c+1; d < sLen; d++)
                    {
                        if (IsPalindroneCheck(chars[a], chars[b], chars[c], chars[d])){
                            Console.WriteLine($"Palindrome found: {chars[a]}{chars[b]}{chars[c]}{chars[d]}");
                            count++;
                        }
                    }
                }
            }
        }*/

        //return count;




    }
}

    