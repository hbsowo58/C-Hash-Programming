// wpf5.cs

// 핵심:

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
        w.Title = "AAA";

        w.MouseLeftButtonDown += W_MouseLeftButtonDown;


        Application app = new Application();
        MessageBox.Show("Hello");
    }

    private static void W_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("왼쪽 버튼 누름");
    }
}