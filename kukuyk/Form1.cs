namespace kukuyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("out?", "sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gray;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "����Է������Ҫ�Ѯ�شøҹ�")
            {
                label1.Text = "Udonthani Rajiabgat University";
            }
            else
            {
                label1.Text = "����Է������Ҫ�ѯ�شøҹ�";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.CadetBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label1.Text=textBox2.Text;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            //this.BackColor = Color.FromArgb(r, g, b);
            label1.ForeColor = Color.FromArgb(r, g, b);
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}