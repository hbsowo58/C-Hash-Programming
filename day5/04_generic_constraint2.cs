using System;

// generic constraint
// where

using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{

    // 아래 코드가 에러인 이유
    // 임의 타입 T에 CompareTo가 항상 있다는 보장이 없다!
    //      CompareTo도 제네릴 문법이면 항상 있다는 보장이 되지 않나?
    //      아마 컴파일러가 where T까지는 몰라서 그런걸까?
    //      객체의 메소드니까 내가 지금 다른 층위를 헷갈려하는건가?
    // => 일단 현재는 object에 있는 작업(메소드)만 가능하다
    public static T Max<T>(T a, T b)
    {
        string s = a.ToString();

        return a.CompareTo(b) > 0 ? a : b;
    }

    // 이럴 때 사용하는 기술이 Generic constraint(제약)
    //      제약을 만족하는 타입만 사용할 수 있음
    // T는 IComparable 인터페이스를 구현한 것만 사용 가능한 메소드
    public static T Max<T>(T a, T b) where T:IComparable
    {
        // IComparable 인터페이스가 구현되어 있으면 CompareTo가 있다는 보장이 있음
        string s = a.ToString();

        return a.CompareTo(b) > 0 ? a : b;
    }

    public static void Main()
    {
        WriteLine($"{Max(10, 20)}");
        WriteLine($"{Max("AAA", "CC")}");

        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        Max(p1, p2); // error. Point는 IComparable 인터페이스를 구현 안함        
    }
}
