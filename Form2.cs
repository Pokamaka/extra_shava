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
        string promokod;
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
            this.ControlBox = false; //убрали крестик

            promokod = ""; //обнулили промокод для повторного использования

            this.label_symmShava.Text = $"{Data.Summ} руб."; //вывели сумму шавермы
            this.label_callories.Text = $"{Data.Callories} cl."; //вывели калорийность шавермы
            this.label_ost.Text = $"{Data.Ost}"; //вывели остроту шавы
            
            //обработка шкалы остроты
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

            this.label6.Visible = false; //обнуляем для повтороного использования
            this.label7.Visible = false; //обнуляем
            this.textBox1.Enabled = true; //обнуляем

        }

        //обрабатываем промокод
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (promokod == "sale")
                {
                    if (Data.Summ > 150)
                    {
                        this.label6.Visible = false;
                        Data.Summ = Data.Summ - 150;
                        this.label_symmShava.Text = $"{Data.Summ} руб.";
                        this.textBox1.Enabled = false;
                        this.label6.Text = "Промокод применён!";
                        this.label6.ForeColor = Color.Green;
                        this.label6.Visible = true;
                        this.label7.Visible = true;
                    }
                    else
                    {
                        this.label6.Text = "Сумма покупки меньше 150";
                        this.label6.ForeColor = Color.Red;
                        this.label6.Visible = true;
                    }
                }
                else 
                {
                    this.label6.Text = "Не верный промокод";
                    this.label6.ForeColor = Color.Red;
                    this.label6.Visible = true;
                }
            }
            else
            {
                this.label_symmShava.Text = $"{Data.Summ} руб.";
                this.label6.Visible = false;
            }
        }

        //получаем промокод
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            promokod = textBox1.Text;
        }

    }
}
