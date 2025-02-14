using System.Windows;

namespace AnkiWindow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();

            // ウィンドウの透明設定
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
            Background = System.Windows.Media.Brushes.Transparent;
        }
    }
}