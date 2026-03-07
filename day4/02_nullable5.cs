using static System.Console;

// 핵심. null conditional operator ( ?, ?[]) 

// 참조 변수 값이 null이면 멤버에 접근 불가
string s1 = "hello";
string s2 = null;
var ret1 = s1.ToString(); // ok. 객체가 존재.
var ret2 = s2.ToString(); // 런타임에러(예외 발생)

// 메소드 호출시 안전하게 하려면 아래 처럼 하면 안전합니다.
string ret3 = null;
if (s2 != null)
{
    // 1. s2 != null 이면 ToString() 메소드호출
    // 2. s2 == null 이면 ToString() 메소드호출 안하고, null 반환
    ret3 = s2.ToString();
}


// 아래 한줄이 위코드와 완벽히동일
string ret4 = s2?.ToString();       // 아주 널리 사용되는 코드!!!
// 1. s2 != null 이면 ToString() 메소드호출
// 2. s2 == null 이면 ToString() 메소드호출 안하고, null 반환

// 배열도 reference type
// => "?." 아니라 "?[]" 도 가능
int[] arr = null;

int n1 = arr[0]; // 에러. 현재 배열 자체가 없음(null)

int n2 = arr?[0]; // 왜 에러일까요 ?
                  // 1. arr != null 이면 arr[0] 반환
                  // 2. arr == null 이면 arr[0] 접근 안하고, null 반환 
                  // => 그런데, "int n2" 에는 null 을 담을수 없다.

int? n3 = arr?[0]; // ok

if (n3 != null) { }
