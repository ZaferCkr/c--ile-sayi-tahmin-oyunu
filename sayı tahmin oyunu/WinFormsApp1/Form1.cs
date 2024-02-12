using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zaman = 3;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            Random rastgele = new Random();
            int sayi;
            sayi = rastgele.Next(1, 10);

            // dönüþtürme
            int metin = Convert.ToInt32(textBox1.Text);
            if (sayi == metin)
            {
                MessageBox.Show("bildiniz tebrik ederim");

            }
            else
            {
                MessageBox.Show("bilemediniz tekrar dene.sayi=" + sayi);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            timer1.Enabled = true;
            label2.Text = zaman.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--; 
            label2.Text = zaman.ToString();
            label2.Text=zaman.ToString();

            if (zaman == 0)
            {
                timer1.Enabled=false;
                button1.Enabled = true;
                textBox1.Enabled = true;
            }

        }


       
    }
}
