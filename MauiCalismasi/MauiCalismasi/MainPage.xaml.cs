namespace MauiCalismasi
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void kabul(object sender, CheckedChangedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {

                DisplayAlert("CheckBox", "İşlem Tamam", "ok");
            }
        }
    }

}
