using static System.Console;

// 핵심 : for 문

int[] x = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

// C# for: C/C++ 언어와 동일. 파이썬과 다름
for(int i = 0; i < 10; i++)
{
    WriteLine($"{x[i]}");
}


// 도전 과제 - for로 아래처럼 출력
// *
// **
// ***
// ****
// *****
for(int i=1; i<6; i++)
{
    for(int j=0;j<i;j++)
        Console.Write('*');
    WriteLine();
}