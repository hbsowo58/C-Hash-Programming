
// 1. 하나의 프로그램 작성시 여러 개의 소스파일로 나눠서 작성한다
// 2. main 함수는 빌드 영역 전체에서 한 개만 존재해야 한다.
// 3. 파일은 단지 코드를 나눠서 작성하는 물리적 단위 
//       java 처럼 패키지 단위 접근 제한이 존재하지 않음


partial class Button
{

}

// partial class : 하나의 클래스를 여러개 파일로 나누어 작성하는 기술
// => 모든 파일에서 "partial" 을 붙여야 합니다.
class Window
{
    public void Show() 
    {
        Console.WriteLine("Window is shown");
    }   
}

class Program
{
    static void Main()
    {
        // partial2에 있는 모듈들을 사용 가능
        // 같은 프로젝트에 있으면 사용 가능함
        Button b1 = new Button();
        Slider s1 = new Slider();

        Window w = new Window();
        w.Show();
        w.Hide(); //partial2에 작성된 메소드
    }
}

// 왜 하나의 클래스를 여러개 파일로 나누나요?
// 1. 하나의 클래스를 여러명의 개발자가 같이 만들기 떄문
// 2. 하나의 클래스를 사람개발자와 기계가 같이 작업할 떄 사용