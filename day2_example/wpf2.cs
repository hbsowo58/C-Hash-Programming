using System.Reflection;
using System.Windows;
using System.Windows.Controls;

class wpf2
{
    [STAThread]
    public static void Main()
    {
        //Window w = new Window();
        //w.Title = "Hello";
        //w.Width = 300;
        //w.Height = 300;

        // 위의 코드를 아래처럼 한줄로 표현 / property 초기화
        Window w = new Window { Title = "Hello", Width = 300, Height = 300 };

        Button b = new Button {Content="확인", FontSize=120};

        w.Content = b;
        w.Show();


        // UI 를 만든경우, 종료되지 말고 event loop 실행
        Application app = new Application();
        app.Run();
    }
}