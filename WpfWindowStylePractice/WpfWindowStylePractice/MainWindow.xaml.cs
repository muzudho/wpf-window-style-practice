namespace WpfWindowStylePractice
{
    using System.Diagnostics;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウを閉じます
            this.Close();
        }

        private void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // ウィンドウのスクリーン座標位置
            Trace.WriteLine($"Window_MouseMove left={this.Left} right={this.Top}");
        }
    }
}
