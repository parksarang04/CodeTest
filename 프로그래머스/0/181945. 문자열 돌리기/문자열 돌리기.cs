using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        foreach (char c in s)   
        {
            Console.WriteLine(c);       // 문자열의 각 문자를 한 줄씩 출력
        }

    }
}