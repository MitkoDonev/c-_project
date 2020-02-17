using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void EncryptButtom(object sender, RoutedEventArgs e)
        {
            Encrypted.Text = Eramake.eCryptography.Encrypt(Word.Text);
        }

        private void DecryptButtom(object sender, RoutedEventArgs e)
        {
            Decrypted.Text = Eramake.eCryptography.Decrypt(Encrypted.Text);
        }

        private void Convert(object sender, RoutedEventArgs e)
        {
            char[] cArray = Word.Text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            this.Converted.Text = reverse.ToString();
        }

        private void SumTextButtom(object sender, RoutedEventArgs e)
        {
            int sumNumber = 0;
            for (int i = 0; i < Word.Text.Length; i++)
            {
                sumNumber = int.Parse(Word.Text.Substring(i, 1)) + sumNumber;
            }

            this.Converted.Text = sumNumber.ToString();
        }
    }
}
