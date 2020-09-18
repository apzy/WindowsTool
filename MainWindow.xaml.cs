using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopTool
{
        /// <summary>
        /// MainWindow.xaml 的交互逻辑
        /// </summary>
        public partial class MainWindow : Window
        {
                public MainWindow()
                {
                        InitializeComponent();
                }


                private void AddItem(object sender, RoutedEventArgs e)
                {
                        CheckBox check = new CheckBox();
                        TextBlock text = new TextBlock();
                        text.Text = Message.Text;
                        text.MaxWidth = 200;
                        text.TextWrapping = TextWrapping.Wrap;
                        text.Foreground = new SolidColorBrush(Colors.White);
                        check.Content = text;
                        List.Children.Add(check);
                }

                private void WindowMouseMove(object sender, MouseEventArgs e)
                {
                        if (e.LeftButton == MouseButtonState.Pressed)
                        {
                                this.DragMove();
                        }
                }

                private void Close(object sender, RoutedEventArgs e)
                {
                        this.Close();
                }
        }
}
