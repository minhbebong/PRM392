namespace SE1626_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripTextBox1.LostFocus += toolStripTextBox1_LostFocus;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromName(toolStripTextBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            BackColor = Color.FromName(mi.Text);
        }
    }
}