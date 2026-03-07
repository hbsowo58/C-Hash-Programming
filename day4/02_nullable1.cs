using static System.Console;

// 핵심. null
//      "가리키는 대상이 없음"

// 언어별 의미 차이
// C/C++ - null : 포인터가 가리키는 것이 없음
// C#/java - null : 참조 타입 변수가 가리키는 객체가 없음

// 값 타입: 스택에 값을 저장
// 참조 타입: 힙에 데이터 저장, 스택에 이를 가리키는 참조 변수 저장


// 1. null은 참조 타입만 사용 가능
//      reference type 변수는 null로 초기화 될수 있음
//      참조 객체 없음을 의미
//      스택에는 변수가 존재하는데 저장된 값이 객체의 주소가 아닌, null이 저장됨
string s2 = null;   // null 이라는 값으로 초기화 
string s3;          // C#은 초기화되지 않으면 읽지도 못함

// 2. value type 의 변수는 null 로 초기화  될 수 없음
int n1 = 0;
int n2 = null;	// error

//------------------대신,  C#8.0 부터 value type 도 Nullable 타입을 통해 null 가질 수 있음 

Nullable<int> n3 = null;         // ok
Nullable<double> n4 = null;      // ok
// Nullable<string> n5 = null; // error. Nullable<> 안에는 value type만가능

// 1. Nullable의 단축 표기법
Nullable<int> n5 = null;
// 아래는 동일한 표기법
int? n6 = null;             // 실전에서는 이렇게 사용

// 2. Nullable 의 원리 - 55 page n1, n2 그림 참고
int n7 = 10;
Nullable<int> n8 = null;
Nullable<int> n9 = 10;