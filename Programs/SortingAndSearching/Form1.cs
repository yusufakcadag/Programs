namespace SortingAndSearching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbrAutoDataCount_Scroll(object sender, EventArgs e)
        {
            lblAutoDataCount.Text = tbrAutoDataCount.Value.ToString();
        }
    }
}