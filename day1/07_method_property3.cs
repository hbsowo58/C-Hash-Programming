using static System.Console;

// 사용자에게 double 값 한개를 입력받아서 화면 출력해 보세요

// 1. ReadLine은 문자열 형태로 입력됨
// 2. 입력된 문자열("3.4")을 double 변수로 변경
//      convert 클래스 또는 double 타입의 static 메소드
// 3. double 변수 출력

string s = Console.ReadLine(); // "3.4"

double d1 = double.Parse(s);
double d2 = Convert.ToDouble(s);

Console.WriteLine(d1);
Console.WriteLine(d2);
