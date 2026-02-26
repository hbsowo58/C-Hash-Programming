using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

// step5. UI를 XML로 구축
// 1. ui1. txt 파일 추가(확장자는 상관없긴함)
class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

        //-------------

        // 1. 파일 오픈
        // "../../../ui1.txt": 실행 파일 기준에서 ui5.txt 파일의 위치 (실행파일의 위치??)
        FileStream fs = new FileStream("../../../ui5.txt", FileMode.Open, FileAccess.Read);

        // 2. 파일의 내용(XML)에 참고해서 컴트롤 생성
        //      ui를 만드는 xml을 xaml이라고 부름
        Button btn = (Button)XamlReader.Load(fs);

        // 3. 파일 닫기
        fs.Close();
        //------------------

        this.Content = btn;
       

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
