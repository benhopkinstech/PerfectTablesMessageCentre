namespace PerfectTablesMessageCentre
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddResponse_Click(object sender, EventArgs e)
        {
            frmAddResponse form = new frmAddResponse();
            form.Show();
        }
    }
}