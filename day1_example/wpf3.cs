// wpf３.cs

// 핵심: UI를 만들 경우 바로 

using System.Windows;

class Program
{
    // GUI를 만들 경우 Main 위에 반드시 아래 코드 추가
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        MessageBox.Show("Hello");
    }
}