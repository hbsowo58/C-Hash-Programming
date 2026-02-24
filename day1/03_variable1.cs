
// python은 변수 선언시 타입 선언을 하지 않는다.
// == 하나의 변수는 모든 타입의 값을 가질 수 있다.
// [dynamic type check] : 실행 시간에 타입을 체크하는 언어
//age = 10
//age = "aaa"

// C/C++/C#/Java/Rust 등 대부분의 언어에서 모든 변수는 타입을 갖는다.
// 안전성이 높아짐
// [static type check] : 컴파일 시에 타입을 체크하는 언어
// int age = 10; -> age는 정수만 담을 수 있다.

// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A';
string s = "hello";

// #2. 타입 대신 var 사용하면, 우변의 초기값으로 컴파일러가 타입을 추론해서 정함
var v1 = 10;		    // int v1=10;
var v2 = 3.4;		    // double v2 = 3.4;
var v3 = "hello";	    // string v3 = "hello"

// #3. literal
int a1 = 10;		
int a2 = 0x10;		
int a3 = 0b10;		// 2진수 (10진수로는 2)

int a4 = 1000000;	
int a5 = 1_000_000; // 값이 크면 _로 구분도 가능


