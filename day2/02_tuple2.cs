using static System.Console;

// #1. tuple 생성
//      튜플 참조변수의 정확한 타입은 소괄호 안에 각 타입 명시 : (Type1, Type2, type3, ... )
//      초기화도 소괄호
(int, int, int) t1 = (1, 2, 3);
(int, double, string) t2 = (1, 3.4, "ABC");

// 튜플은 타입을 직접 표기하기 보단, 그냥 var 사용
var t = (1, 2.3, "abc");

// #2. 요소 접근
// .으로 "Item1", "Item2" 키워드에 접근
var t3 = (1, 2, 3);
t3.Item1 = 10;
Console.WriteLine($"{t3.Item1}, {t3.Item2}");



// #3. Named Member
// 요소 각각에 이름 부여 가능
(int one, int two, int three) v3 = (1, 2, 3);  // named tuple
Console.WriteLine("{0}, {1}", v3.one, v3.two);

var v4 = (one:1, two:2, three:3);

