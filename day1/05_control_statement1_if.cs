using static System.Console;

// 핵심 : if 문

// 프로그램은 약속된 entry point부터 순차적으로 실행됨
// 1. 실행흐름을 변경하고 싶음 -> 조건문 사용
// 2. 실행 흐름을 반복하고 싶음 -> 반복문 사용

// 언어별 조건/반복문 표
//       조건문 2개                반복문 2-4개
// C     : if, switch             while, do-while, for
// Python: if, match(switch 일종) while,        -,   -,  for(foreach스러운)
// C#    : if, switch             while, do-while, for, foreach (파이썬의 for)
// C++,Java                       while, do-while, for, for (iterable)


int score = 75;
if (score > 70)
    WriteLine("Pass");
else if (score < 40)
    WriteLine("Fail");
else WriteLine("Reexam");

