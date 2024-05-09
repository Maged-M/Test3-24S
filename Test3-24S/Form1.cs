namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sum = (string)this.textBox1.Text;
            string count = (string)this.textBox1.Text;
            string average = (string)this.textBox1.Text;
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox1.Text);
            double z = double.Parse(textBox1.Text);
            z = x + y;
            z = x / y;

            
          

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox2.Text);
            if (x < 0) ;
        }
    }
}
