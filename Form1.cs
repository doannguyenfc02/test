namespace Bai27
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text=txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lblLapTrinh.ForeColor = radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
            {
                lblLapTrinh.ForeColor=radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lblLapTrinh.ForeColor=radBlue.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(radBlack.Checked == true)
            {
                lblLapTrinh.ForeColor=radBlack.ForeColor;
            }   
        }

        private void checkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Bold);

        }

        private void checkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void checkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}