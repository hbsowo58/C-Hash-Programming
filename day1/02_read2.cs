using System;

// 핵심 : 정수/실수 입력

// 대부분의 언어에서 입력을 받는다는 건, 문자열을 받는다는 것
// 따라서, 용도에 맞게 타입 변경이 필요

// C의 scanf는 입력+타입변환을 함수가 지원
//      형식지정자 %d,%f,%s를 매개변수로 받아서
// C#은 입력만 지원 -> 타입 변환은 개발자 책임(요즘방식)

Console.Write("input yout age >> ");

string s = Console.ReadLine(); // "10"

// Convert: 형변환 클래스 
// => 숫자가 아닌 문자가 있다면 예외 발생
int n = Convert.ToInt32(s); 

Console.WriteLine(n * n);



