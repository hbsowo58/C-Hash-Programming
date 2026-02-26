using System;

// 

using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // 임의 타입의 인자 2개를 받아서 더 큰 값을 반환하는 함수
    // 이때, 비교연산자는 수치 타입만 가능하고 string 타입은 안됨
    public static T Max<T>(T a, T b) 
    {

        //return a < b ? b : a;

        // int, string은 모두 compareTo 메소드가 있는데 이거는 오류임
        return a.CompareTo(b) > 0 ? a : b;
    }

    public static void Main()
    {
		WriteLine($"{Max(10, 20)}");
		WriteLine($"{Max("AAA", "CC")}");

        Foo(10, 20); 
    }
}
