using System.Windows;

namespace 绑定静态字段
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            ClassA.myLabel = "ButtonA的事件";
        }
    }
}
