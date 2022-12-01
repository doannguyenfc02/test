namespace Bai28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOoO_Click(object sender, EventArgs e)
        {
            if(picOn.Visible==false)
            {
                picOn.Visible = true;
                picOff.Visible = false;
                BtnOoO.Text = BtnOoO.Text.Replace("on", "off");
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                BtnOoO.Text = BtnOoO.Text.Replace("off", "on");
            }

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(picOn.Visible==false)
            {
                BtnOoO.Text = txtName.Text + " turn on the light, please!";
            }
            else
            {
                BtnOoO.Text = txtName.Text + " turn off the light, please!";
            }
        }
    }
}