namespace Color_Picker
{
    public partial class MainPage : ContentPage
    {
        bool isRandom = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (!isRandom)
            {
            var red = sldRed.Value;
            var green = sldGreen.Value;
            var blue = sldBlue.Value;
            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
            }
        }
        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            isRandom = true;

            Random random = new();
            var color = Color.FromRgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
            SetColor(color);
            isRandom = false;
        }
        private void SetColor(Color color)
        {
            Container.BackgroundColor = color;
            btnRandom.BackgroundColor = color;
            lblHex.Text = color.ToHex();
        }
    }

}
