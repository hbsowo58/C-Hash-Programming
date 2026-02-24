// wpf2.cs

// 핵심: 직접 window 만들기
//      지금 단계부터는 top-level이 불가함

using System.Windows;

class Program
{
    // GUI를 만들 경우 Main 위에 반드시 아래 코드 추가
    [STAThread]
    public static void Main()
    {
        Window w= new Window();
        w.Show();

        MessageBox.Show("Hello");
    }
}