using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


// 모든 wpf gui의 속성에는 content가 있다 

class wpf3
{
    [STAThread]
    public static void Main()
    {

        Window w = new Window();

        // Title 속성 : 윈도우의 캡션 문자열에 나타낼 문자열 설정
        w.Title = "Hello";

        // Content 속성: window 자체에 나타낼 컨텐츠

        //w.Content = "Hello";              // window 컨텐츠에 문자열 연결
        //w.Content = new Button { Content ="버튼" };         // 윈도우 컨텐츠에 버튼 연결
        
        // Content의 타입은 object
        //      부모 타입 참조변수에는 자식 타입을 할당 가능하므로 
        //      Content에 다양한 타입을 할당 가능한 이유는 Upcasting!!


        // 그림 나타내기
        BitmapImage bm = new BitmapImage();
        bm.BeginInit();
        bm.UriSource = new Uri("C:\dev\8mU3ECBYfwQK2U7Ws-d7mnnDqDMBAF2_zTbXfmDX5YR3ovgEzd9ikO-W7ZROOd-iDCR_kVRZtcnSo_XpE7j1fQ.webp");
        bm.EndInit();

        Image img = new Image();
        img.Source = bm;
        w.Show();


        // UI 를 만든경우, 종료되지 말고 event loop 실행
        Application app = new Application();
        app.Run();
    }
}