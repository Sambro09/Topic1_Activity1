using System.Security.Cryptography.X509Certificates;

namespace Topic1_Activity1
{
    public partial class Form1 : Form
    {
        public bool isClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void clickHereButton_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked;

            if (isClicked)
            {
                surpriseLabel.Text = "Surprise!";
            }
            else
            {
                surpriseLabel.Text = "";
            }
        }
    }
}