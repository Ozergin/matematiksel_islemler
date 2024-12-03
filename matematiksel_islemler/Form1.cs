namespace matematiksel_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Abs(sayi).ToString();  // abs = mutlak

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Ceiling(sayi).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Floor(sayi).ToString();  //floor = alta yuvarla
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Pow(sayi, 3).ToString(); // pow(girilen sayi , alýnmasýný istenen üs)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Sqrt(sayi).ToString(); //sqrt kafrekök alma
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi=Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Cos(sayi).ToString();    
        }
    }
}
