using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шава_мейкер_2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //кнопка выхода из приложения
        public void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //кнопка повтора
        public void button_one_more_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); //для обращения к первой форме
            this.Close();
            f1.Show();
        }

        //корректное закрытие
        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //загрузка формы и данных
        public void Form2_Load(object sender, EventArgs e)
        {
            this.label_symmShava.Text = $"{Data.Summ} руб.";
            this.label_callories.Text = $"{Data.Callories} cl.";
            this.label_ost.Text = $"{Data.Ost}";
            if (Data.Ost == 1)
            {
                this.pictureBox_1.Visible = true;
            }
            if (Data.Ost == 2)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
            }
            if (Data.Ost == 3)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
            }
            if (Data.Ost == 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
            }
            if (Data.Ost > 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = true;
            }

        }
    }
}
