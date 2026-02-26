using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;

// step4. UI 구축
// mainWindow 에서 생성자를 만들고 Panel, Control 들을 부착 및 event 처리 코드 추가

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

        StackPanel sp = new StackPanel();
        this.Content = sp;   // window.content는 한 개밖에 못 붙이니까 panel을 붙이기

        //---------------
        Button btn1 = new Button { Content = "OK1" };
        Button btn2 = new Button { Content = "OK2" };

        sp.Children.Add(btn1);
        sp.Children.Add(btn2);
        //---------------

        btn1.Click += Btn1_Click; // 눌렀을 때 이벤트 처리 (delegate??)

    }

    // 버튼 이벤트 처리 함수
    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("btn1 click");
    }
}
    class App: Application
{


    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        w.Show();

        App app = new App();
        app.Run();
    }
}
