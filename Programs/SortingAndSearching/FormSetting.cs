namespace SortingAndSearching
{
    public partial class FormSetting : Form
    {

        Settings _settings;
        public FormSetting()
        {
            InitializeComponent();
            _settings = new Settings();
        }

        private void tbrAutoDataCount_Scroll(object sender, EventArgs e)
        {
            lblAutoDataCount.Text = tbrAutoDataCount.Value.ToString();
        }

        private void btnConfirmDataEntrySettings_Click(object sender, EventArgs e)
        {
            string dataEntrySettings;

            if (rbtnDigital.Checked)
            {
                dataEntrySettings = "Veriler sayısal olacak şekilde ";
            }
            else
            {
                dataEntrySettings = "Veriler karaktersel olacak şekilde ";
            }

            if (rbtnAuto.Checked)
            {
                dataEntrySettings += "bilgisayar tarafından oluşturulacaktır.";
            }
            else
            {
                dataEntrySettings += "sizin tarafınızdan girilecektir.";
            }

            DialogResult confirmResult = MessageBox.Show($"{dataEntrySettings} Onaylıyor musunuz? Geri Alamazsınız!", "Onay Penceresi", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                return;
            }
            else
            {
                if (rbtnAuto.Checked)
                {
                    gbxDataInput.BackColor = Color.IndianRed;
                    gbxAutoDataSettings.BackColor = Color.Green;
                    gbxAutoDataSettings.Enabled = true;

                    _settings.IsAuto = true;
                }
                else
                {
                    gbxAutoDataSettings.BackColor = Color.IndianRed;
                    gbxDataInput.BackColor = Color.Green;
                    gbxDataInput.Enabled = true;

                    _settings.IsAuto = false;
                }

                if (rbtnDigital.Checked)
                {
                    _settings.IsDigital = true;
                }
                else
                {
                    _settings.IsDigital = false;
                }

                gbxDataEntrySettings.BackColor = Color.IndianRed;
                gbxDataEntrySettings.Enabled = false;
            }
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            //todo Veri girişi manuel yapılınca veriyi ve sayısını elde et.
        }
    }
}