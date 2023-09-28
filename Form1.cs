using System.Threading;

namespace K26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if 
                (listBox1.Items[i].ToString() == "HOPARLÖR" ||
                listBox1.Items[i].ToString() == "MÝKROFON" ||
                listBox1.Items[i].ToString() == "MONÝTÖR")
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                else
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
            }
        }
    }
}