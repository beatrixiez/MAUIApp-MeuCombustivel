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

                string marca = txt_marcaVeiculo.Text;
                string modelo = txt_modeloVeiculo.Text;

                string combustivelRecomendado = "";

                if(etanol <= (gasolina * 0.7))
                {
                    combustivelRecomendado = "O etanol";
                } else
                {
                    combustivelRecomendado = "A gasolina";
                }

                string msg = $"{combustivelRecomendado} é a melhor opção para o seu veículo {marca} {modelo}.";

                DisplayAlertAsync("Calculando", msg, "OK");
            }
            catch (Exception ex) 
            {
                DisplayAlertAsync("Ops!", ex.Message, "Fechar");
            }
        }
    }
}
