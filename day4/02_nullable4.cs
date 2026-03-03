using static System.Console;

// null-coalescing operator (?? 연산자)

int? a = null;

// a : int? 타입입니다.

int b = a;    // error

// null이면 에러나는 방법
int n1 = (int)a;
int n2 = a.Value;

// null이어도 에러 안나는 방법
int n3 = a.GetValueOrDefault(); 
int n4 = a ?? 0;                    // 실전에서 사용되는 방법


// string 은 reference type 이므로 ? 가 없어도 null 가능
string s1 = null;
string s2 = s1;  // s2 도 null
string s3 = s1 ?? "Unknown";  // s3 은 "Unknown"


