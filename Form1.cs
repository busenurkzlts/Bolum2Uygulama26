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
                (listBox1.Items[i].ToString() == "HOPARL�R" ||
                listBox1.Items[i].ToString() == "M�KROFON" ||
                listBox1.Items[i].ToString() == "MON�T�R")
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