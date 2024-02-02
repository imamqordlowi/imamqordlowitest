namespace WinFormsAppTest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            var newForm = new FileConverter();
            newForm.Show();

        }
    }
}
