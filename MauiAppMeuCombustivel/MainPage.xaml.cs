namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if(etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando.";
                } else
                {
                    msg = "A gasolina está compensando.";
                }

                DisplayAlertAsync("Calculando", msg, "OK");
            }
            catch (Exception ex) 
            {
                DisplayAlertAsync("Ops!", ex.Message, "Fechar");
            }
        }
    }
}
