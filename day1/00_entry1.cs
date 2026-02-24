// c# 언어
// 소스 코드 확장자는 .cs
// 파일 포맷은 UTF-8 권장하지만 다른 포맷도 가능함
// 소스 스타일은 C/C++과 유사하며, 문장 끝에 세미콜론(;) 필요함

// entrypoint
// C#은 원래 1.0부터 c/c++과 같이, main 부터 실행했음
// 9.0부터는 python과 같이, 소스 파일의 1번째 문장부터 실행도 가능함
//      전역에 명령문을 쓰면 됨
//      원리는, 컴파일러가 자동으로 코드를 클래스의 main에 넣어줌

// <두 방식의 용도>
// 간단한 테스트 -> Top-Level 방식
// 큰 소스코드 -> 별도의 entry point

// 하나의 프로젝트에 두 개의 entrypoint가 존재하면 오류

System.Console.WriteLine("hello, C#");

class Program
{
    public static void Main()
    {
        System.Console.WriteLine("hello, C#");
    }
}