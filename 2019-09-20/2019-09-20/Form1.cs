using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_09_20
{
     public partial class Form1 : Form
    {
        
        List<Szemely> emberek = new List<Szemely>();

        private void Button3_Click(object sender, EventArgs e)
        {
            

            textBox1.AppendText("------------------- \n");

            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i=0;i < emberek.Count; i++)
            {
                textBox1.AppendText(emberek[i].nev + " " + emberek[i].szulEv + "-ben született és most " + emberek[i].eletkor() + " éves \n");
            }
           
        }

      

        public Form1()
        {
            InitializeComponent();
         

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form();
            Form2.Show(this);
            Form2.Text = "Személy hozzáadás";

            Label label1 = new Label();
            Label label2 = new Label();
            TextBox txt1 = new TextBox();
            TextBox txt2 = new TextBox();
            Button btn = new Button();

            label1.Name = "szoveg1";
            label2.Name = "szoveg2";
            txt1.Name = "szNev";
            txt2.Name = "szIdo";
            btn.Name = "mehet";

            label1.Text = "Név: ";
            label2.Text = "Születési év: ";           
            btn.Text = "Mehet";

            Form2.AcceptButton = btn;
            Form2.ClientSize = new Size(300, 150);
            label1.Size = new Size(70, 30);
            label2.Size = new Size(70, 35);
            txt1.Size = new Size(80, 25);
            txt2.Size = new Size(80, 25);
            btn.Size = new Size(50, 25);


            label1.Location = new Point(12, 12);
            label2.Location = new Point(12, 50);
            txt1.Location = new Point(90, 12);
            txt2.Location = new Point(90, 50);
            btn.Location = new Point(120, 75);

            Form2.Controls.Add(label1);
            Form2.Controls.Add(label2);
            Form2.Controls.Add(txt1);
            Form2.Controls.Add(txt2);
            Form2.Controls.Add(btn);

            btn.Click += btn_Click;

            void btn_Click(object sender1, EventArgs e1)
            {
                String nev = Convert.ToString(txt1.Text);
                int ido = Convert.ToInt32(txt2.Text);

                emberek.Add(new Szemely(nev, ido));

                MessageBox.Show("A személyt felvettük az adatbázisba!");
                Form2.Close();
            }


        }
    }
}
