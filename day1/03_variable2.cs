using static System.Console;

// 핵심 : 초기화되지 않은 변수는 쓰기만 가능.
int n;
int a = 0;

a = n;			// ?
WriteLine(n);	// ?

n = a;	// ?
a = n;  // ?