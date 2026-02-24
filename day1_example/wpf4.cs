// wpf３.cs

// 핵심:　ＵＩ를　만들　경우，　바로　종료되게　하지　않고　

// C#은 메소드보다 property를 더 자주 사용함

using System.Drawing;
using System.Windows;

class Program
{
    // GUI를 만들 경우 Main 위에 반드시 아래 코드 추가
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        // 윈도우 캡션 문자열을 "AAA"로 변경하기
        //      현재 윈도우를 관리하는 객체는 w
        //      윈도우에 대해 작업하고 싶을 때는 "W." 후에 lookup table에서 찾기

        w.Title = "AAA";
        w.Width = 300;
        w.Height = 300;

        w.Background = new SystemBrushes(Color.Yellow);

        Application app = new Application();
        MessageBox.Show("Hello");
    }
}