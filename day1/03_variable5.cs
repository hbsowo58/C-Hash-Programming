using static System.Console;

// casting
double d = 3.4;
int n1 = d;     //  error: double 타입을 int로 자동 casting 불가

int n2 = (int)d;  // 직접, 명시적 casting 필요

// nameof
int color = 100;
string s = "abcd";
string name = nameof(color);

WriteLine($"{nameof(color)} : {color}");				

				

