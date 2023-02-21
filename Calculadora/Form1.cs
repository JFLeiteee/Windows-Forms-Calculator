namespace Calculadora
{
    public partial class master_form : Form
    {
        public master_form()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int value1;
            int value2;
            int result;

            value1 = int.Parse(txtFirstNumber.Text);
            value2 = int.Parse(txtSecondNumber.Text);

            if (rdbPlus.Checked == true)
            {
                result =  value1 + value2;
                lblResult.Text = result.ToString();
            }
            else if (rdbMenos.Checked == true)
            {
                result = value1 - value2;
                lblResult.Text = result.ToString();
            }
            else if (rdbTimes.Checked == true)
            {
                result = value1 * value2;
                lblResult.Text = result.ToString();
            }
            else if (rdbDivided.Checked == true)
            {
                result = value1 / value2;
                lblResult.Text = result.ToString();
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
        }
    }
}