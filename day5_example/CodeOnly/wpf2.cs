using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Windows;

// step2. window 와 application 클래스
// WPF에는 수천개의 클래스가 있지만 핵심 클래스는 이 2개

// 1. window: 프로그램의 주 윈도우를 만듬
// 2. application: 프로그램의 시작/끝/event 처리를 담당 

// 관례
// 클래스에서 WPF 클래스를 상속 받아서 사용
class MainWindow: Window
{
    // 주된 UI 담당
}
class App: Application
{
    // UI는 아님
    // 프로그램의 life Cycle
    protected override void OnExit(ExitEventArgs e)
    {
        Console.WriteLine("프로그램이 종료되었습니다");
        base.OnExit(e);  // 부모 클래스의 원래 onexit 호출
    }
    protected override void OnStartup(StartupEventArgs e)
    {
        Console.WriteLine("프로그램이 시작됨니다. To Do: 로고 화면 보이기");
        base.OnStartup(e);
    }
}

class Program
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