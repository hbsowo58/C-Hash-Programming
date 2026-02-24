using static System.Console;

// #1. 함수는 기본 적으로 한개의 값을 반환 합니다.
string Get1()
{
    return "john";
}

string ret1 = Get1();

// tuple은 언제 주로 사용?
// 함수에서 여러 개의 값을 반환할 때!!!  tuple을 반환한다고 생각하면 됨
(string, int) Get2()
{
    return ("John", 20);
}

var ret2 = Get2();
Console.WriteLine($"{ret2.Item1}, {ret2.Item2}");

(string Name, int Age) Get3()
{
    return ("John", 20);
}
var ret3 = Get3();
Console.WriteLine($"{ret3.Name}, {ret3.Age}");