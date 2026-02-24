int add1(int a, int b)
{
    return a + b;
}

Console.WriteLine( add1(3, 4) );   

// 함수 () 뒤에 "=>반환값"으로 표현
// expression bodied 문법
// 다른 언어에서 볼 수 없는 C#만의 특징으로 아주 널리 사용됨!!
int add2(int a, int b) => a + b;
void sayHello() => Console.WriteLine("Hello");