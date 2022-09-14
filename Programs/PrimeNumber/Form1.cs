namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNumber.Text = "";
        }

        public bool IsPN(int input)
        {
            if (input < 2)
            {
                return false;
            }
            else if (input == 2)
            {
                return true;
            }
            else
            {
                if (input % 2 == 0)
                {
                    return false;
                }
                else
                {
                    for (int i = 3; i < input; i += 2)
                    {
                        if (input % i == 0)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        // result[0] alt asal sayıdır.
        // result[1] üst asal sayıdır.
        public int[] ReturnUpperPNAndBottomPN(int input) 
        {
            int[] result = new int[2];
            int _input = input;

            while (true)
            {
                if (IsPN(_input -= 2))
                {
                    result[0] = _input;
                    break;
                }
            }

            _input = input;

            while (true)
            {
                if (IsPN(input += 2))
                {
                    result[1] = input;
                    break;
                }
            }
            return result;
        }

        private void btnIsPN_Click(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(tbxPN.Text);

                if (IsPN(input))
                {
                    lblNumber.Text = input + " sayısı";
                    lblPN.Text = "Asal sayı!";
                    lblPN.ForeColor = Color.Green;
                    lbxHistory.Items.Add(input + ": Asal");
                    int[] upperPNAndBottomPN = ReturnUpperPNAndBottomPN(input);
                    lblBottomPN.Text = "Alt Asal Sayı: " + upperPNAndBottomPN[0];
                    lblUpperPN.Text = "Üst Asal Sayı: " + upperPNAndBottomPN[1];
                    tbxPN.Clear();
                }
                else
                {
                    lblNumber.Text = input.ToString() + " sayısı";
                    lblPN.Text = "Asal sayı değil!";
                    lblPN.ForeColor = Color.Red;
                    lbxHistory.Items.Add(input.ToString() + ": Asal değil");
                    lblBottomPN.Text = "Alt Asal Sayı";
                    lblUpperPN.Text = "Üst Asal Sayı";
                    tbxPN.Clear();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı değer girdiniz. Lütfen tam sayı giriniz.");
                tbxPN.Clear();
                lblNumber.Text = "";
                lblBottomPN.Text = "Alt Asal Sayı";
                lblUpperPN.Text = "Üst Asal Sayı";
            }
        }
    }
}