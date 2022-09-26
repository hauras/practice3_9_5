using System;
public class practice3_9_5
{
    public static void Main(String[] args)
    {
        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);
        int maxNum=0; // 최대 공약수
        int minNum; // 최소공배수 

        for (int i = 1; i <= a && i <= b; i++) // 두 수 중 작은수 까지 i를 계속 증가시킴
        {
            if (a % i == 0 && b % i == 0) // a랑 b를 각각 i로 나눴을때 0인 값을 찾는 과정
            {
                maxNum = i; // 나온 값을 maxnum에 저장 // 최대 공약수
                
            }
        }
        minNum = (a * b) / maxNum; // 최소공배수는 두 수 곱한뒤 최소공약수로 나눠주면됨
        Console.WriteLine("최소 공배수 : " +minNum + " 최대 공약수 : " + maxNum);
    }

}
       
    

