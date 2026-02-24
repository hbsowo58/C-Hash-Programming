// mutable.cs

// 핵심. 애초에 문자열 표기 ""를, 그 자체로 컴파일러가 내장 타입인 string으로 인식함!!!!!

// mutable   : 객체의 상태를 변경할수 있는것
// immutable : 객체의 상태를 변경할수 없는것 / 상수형 

// #1. int 타입의 객체는 mutable 합니다.
int n = 10;
n = 20;    // ok


// #2. string이 immutable한 객체이기 때문에 문자열 리터럴은 수정이 불가능
//      string이 immutable한 이유는, 설계를 그렇게 한거임 
//          내부 변경 메서드도 없고, 상태 변경시에는 새 객체를 반환함 
// C / C++ : 문자열 리터럴이 정적 영역
// C#/Java : 문자열 리터럴이 힙(Intern Pool)에 저장됨
     

// 헷갈리는 string 생성
// string만, 컴파일러가 new 없이 문자열 리털럴로 초기화/대입 할 수 있도록 한것
string s1 = "abcd";  // new string("abcd") <- "abcd"는 String 객체이므로 수정 불가

char c = s1[0]; // ok
s1[0] = 'x';    // error

string s2 = s1.ToUpper();




