namespace ödev_67_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0;
            do
            {
                richTextBox1.Text = richTextBox1.Text + say.ToString();
                say++;
            } while (say <= 30);
        }
    }
}