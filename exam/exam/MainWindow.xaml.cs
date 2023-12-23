using System.Windows;

namespace exam
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextWindowButton_Click(object sender, RoutedEventArgs e)
        {
            TextWindow textWindow = new TextWindow();
            textWindow.Show();
            this.Close();
        }

        private void ImageWindowButton_Click(object sender, RoutedEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow();
            imageWindow.Show();
            this.Close();
        }

        private void OpenVideoWindow_Click(object sender, RoutedEventArgs e)
        {
            VideoWindow videoWindow = new VideoWindow();
            videoWindow.Show();
            this.Close();
        }
    }
}
