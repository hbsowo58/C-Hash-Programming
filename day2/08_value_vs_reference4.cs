using static System.Console;

// 핵심 : 어떤 타입이 "value type" 인지 "reference type"
//        인지를 정확히 알아야 한다.

// C#의 기본타입인 Int32 도 struct로 만들어져서 값 타입인 것!!


// int는 값 타입
int n1 = 10;
int n2 = n1;
n1 = 20;
WriteLine($"{n1} {n2}");	// 20  10	

// 배열
// C#, java : reference 타입
//      배열은 크기가 보통 커서, = 연산 시에 (메모리 복제가 아닌) 참조로 메모리 아낌!!
// swift, C++ : value 타입
int[] x1 = {1, 2, 3};
int[] x2 = x1;

x1[0] = 20;
WriteLine($"{x1[0]} {x2[0]}");	// 20 20

// "string" 정의로 이동 -> class로 타입 선언 => reference 타입
string s1 = "AB";
string s2 = s1;

s1 = "XY";   // "AB" 내부 메모리를 변경한게 아니라, 자체 주소를 변경하는 거라서 별개 
WriteLine($"{s1} {s2}");  