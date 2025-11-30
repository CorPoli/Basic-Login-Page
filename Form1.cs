namespace YOUR_PRODJECT_NAME_HERE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            if (Key.Text == "1234")
            {
                MessageBox.Show("Active Key", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SECOND_PAGE dash = new SECOND_PAGE();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Key!", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
