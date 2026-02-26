using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

// step8. Window가 아닌 사용자가 만든 "MainWindow" 클래스 사용하기 

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

    }
}

class App : Application
{
    [STAThread]
    public static void Main()
    {
        //--------------------------------------------------
        FileStream fs = new FileStream("../../../ui8.txt",
                                       FileMode.Open, FileAccess.Read);

        Window w = (Window)XamlReader.Load(fs);

        fs.Close();
        //--------------------------------------------------

        w.Show();

        App app = new App();
        app.Run();
    }
}

// UI를 만들기 위해 사용하는 XML을 XAML 이라고 부름(자말)
// 관례적으로 .xaml 사용

// 하나의 창은 2개의 파일로 구성
// .xaml: UI를 마들기 위한 XML 코드
// .cs   : UI 에서 발생하는 이벤트를 처리하기 위한 C# 코드. 위 코드의 Foo 함수