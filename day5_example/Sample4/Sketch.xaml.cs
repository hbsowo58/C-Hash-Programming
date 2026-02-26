using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sample4
{
    /// <summary>
    /// Sketch.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sketch : Window
    {
        public Sketch()
        {
            InitializeComponent();
        }

        private Point ptFrom;
        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("left button down");

            ptFrom = e.GetPosition(this);
 
        }


        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // WPF는 아주 잘 만든 객체 지향 라이브러리
            // => 선을 그린다는 것은 선 객체를 만들어서 canvas 의 자식으로

            if (e.LeftButton == MouseButtonState.Pressed)
            {


                Line line = new Line();
                line.Stroke = new SolidColorBrush(Colors.Red);
                line.StrokeThickness = 5;

                Point to = e.GetPosition(this);

                line.X1 = ptFrom.X;
                line.Y1 = ptFrom.Y;
                line.X2 = to.X;
                line.Y2 = to.Y;

                Canvas.Children.Add(line);

                ptFrom = to;
            }
        }

        private void Canvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Canvas.Children.Clear();
        }
    }
}
