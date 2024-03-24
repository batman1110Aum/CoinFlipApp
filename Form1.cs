namespace CoinFlip
{
    public partial class Form1 : Form
    {
        int heads;
        int tails;
        public Form1()
        {
            InitializeComponent();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            Random coin = new Random();
            int result = coin.Next(1, 3);

            if (result == 1)
            {
                coinImage.ImageLocation = @"D:\Heads.png";
                coinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                heads++;
                HeadsLabel.Text = "Heads : " + heads.ToString();

            }
            else
            {
                coinImage.ImageLocation = @"D:\Tails.png";
                coinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                tails++;
                TailsLabel.Text = "Tails : " + tails.ToString();
            }

        }

      
    }
}
