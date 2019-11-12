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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Form2 f2 = new Form2(); //для обращения ко второй форме

        //буфер для значения numeric
        double[] znach = { 0, 0, 0 }; 
        double[] znach_2 = { 0, 0, 0 };
        double[] znach_3 = { 0, 0, 0 };
        double[] znach_4 = { 0, 0, 0 };
        double[] znach_5 = { 0, 0, 0 };
        double[] znach_6 = { 0, 0, 0 };
        double[] znach_7 = { 0, 0, 0 };
        double[] znach_8 = { 0, 0, 0 };
        double[] znach_9 = { 0, 0, 0 };
        double[] znach_10 = { 0, 0, 0 };


        //выбор основы
        public void radioButton_lavash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_lavash.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Callories = Data.Callories + 20;
                this.pictureBox_lavash.Visible = true;                             
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Callories = Data.Callories - 20;
                this.pictureBox_lavash.Visible = false;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //лаваш
        public void radioButton_pita_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pita.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Callories = Data.Callories + 25;
                this.pictureBox_pita.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Callories = Data.Callories - 25;
                this.pictureBox_pita.Visible = false;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //пита
        public void radioButton_tarelka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_tarelka.Checked == true)
            {
                Data.Summ = Data.Summ + 50;
                this.pictureBox_tarelka.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 50;
                this.pictureBox_tarelka.Visible = false;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //тарелка

        //выбор мяса
        public void radioButton_chiken_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_chiken.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Callories = Data.Callories + 200;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Callories = Data.Callories - 200;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //курица
        public void radioButton_pork_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pork.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Callories = Data.Callories + 220;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Callories = Data.Callories - 220;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //свинина
        public void radioButton_mutton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_mutton.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Callories = Data.Callories + 210;
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Callories = Data.Callories - 210;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //баранина


        //выбор соуса
        public void radioButton__calssic_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__calssic.Checked == true)
            {
                Data.Summ = Data.Summ + 25;
                Data.Callories = Data.Callories + 20;
            }
            else
            {
                Data.Summ = Data.Summ - 25;
                Data.Callories = Data.Callories - 20;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //классический 
        public void radioButton__bbq_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__bbq.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Callories = Data.Callories + 25;
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Callories = Data.Callories - 25;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //bbq
        public void radioButton__cheesy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__cheesy.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Callories = Data.Callories + 25;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Callories = Data.Callories - 25;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //сырный
        public void radioButton__super_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__super.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Callories = Data.Callories + 25;
                this.groupBox_hotly.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Callories = Data.Callories - 25;
                this.groupBox_hotly.Visible = false;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //острый
        public void radioButton_adjika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_adjika.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Callories = Data.Callories + 25;
                this.groupBox_hotly.Visible = true;
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Callories = Data.Callories - 25;
                this.groupBox_hotly.Visible = false;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //аджика
        public void radioButton__1000island_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__1000island.Checked == true)
            {
                Data.Summ = Data.Summ + 35;
                Data.Callories = Data.Callories + 20;
            }
            else
            {
                Data.Summ = Data.Summ - 35;
                Data.Callories = Data.Callories - 20;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //1000 островов


        //острота соуса
        public void radioButton__min_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__min.Checked == true)
            {
                Data.Summ = Data.Summ + 5;
                Data.Ost = Data.Ost + 1;
            }
            else
            {
                Data.Summ = Data.Summ - 5;
                Data.Ost = Data.Ost - 1;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            if (Data.Ost == 1)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = false;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 2)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 3)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost > 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = true;
            }
        } //минималка
        public void radioButton__middel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__middel.Checked == true)
            {
                Data.Summ = Data.Summ + 10;
                Data.Ost = Data.Ost + 2;
            }
            else
            {
                Data.Summ = Data.Summ - 10;
                Data.Ost = Data.Ost - 2;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            if (Data.Ost == 1)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = false;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 2)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 3)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost > 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = true;
            }
        } //норм
        public void radioButton__high_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__high.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Ost = Data.Ost + 3;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Ost = Data.Ost - 3;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            if (Data.Ost == 1)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = false;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 2)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 3)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost > 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = true;
            }
        } //остренько
        public void radioButton__vhot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__vhot.Checked == true)
            {
                Data.Summ = Data.Summ + 20;
                Data.Ost = Data.Ost + 4;
            }
            else
            {
                Data.Summ = Data.Summ - 20;
                Data.Ost = Data.Ost - 4;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            if (Data.Ost == 1)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = false;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 2)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 3)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost > 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = true;
            }
        } //пожар
   
        
        //выбор допинга
        public void checkBox_cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cucumber.Checked == true)
            {
                this.numeric_cucumber.Visible = true;
                this.pictureBox_cucumber.Visible = true;
                this.label_cucumber.Visible = true;
            }
            else
            {
                this.numeric_cucumber.Visible = false;
                this.pictureBox_cucumber.Visible = false;
                this.label_cucumber.Visible = false;
            }
        } //огурцы
        public void checkBox_mar_cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mar_cucumber.Checked == true)
            {
                this.numeric_mar_cucumber.Visible = true;
                this.pictureBox_mar_cucumber.Visible = true;
            }
            else
            {
                this.numeric_mar_cucumber.Visible = false;
                this.pictureBox_mar_cucumber.Visible = false;
            }
        } //маринованые огурцы
        public void checkBox_tomato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tomato.Checked == true)
            {
                this.numeric_tomato.Visible = true;
                this.pictureBox_tomato.Visible = true;
            }
            else
            {
                this.numeric_tomato.Visible = false;
                this.pictureBox_tomato.Visible = false;
            }
        } //помидоры
        public void checkBox_carrot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_carrot.Checked == true)
            {
                this.numeric_carrot.Visible = true;
                this.pictureBox_carrot.Visible = true;
            }
            else
            {
                this.numeric_carrot.Visible = false;
                this.pictureBox_carrot.Visible = false;
            }
        } //марковка
        public void checkBox_pepper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pepper.Checked == true)
            {
                this.numeric_pepper.Visible = true;
                this.pictureBox_pepper.Visible = true;
            }
            else
            {
                this.numeric_pepper.Visible = false;
                this.pictureBox_pepper.Visible = false;
            }
        } //болгарский перец
        public void checkBox_salad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_salad.Checked == true)
            {
                this.numeric_salad.Visible = true;
                this.pictureBox_salad.Visible = true;
            }
            else
            {
                this.numeric_salad.Visible = false;
                this.pictureBox_salad.Visible = false;
            }
        } //салатный лист
        public void checkBox_mar_capusta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mar_capusta.Checked == true)
            {
                this.numeric_mar_capusta.Visible = true;
                this.pictureBox_mar_capusta.Visible = true;
            }
            else
            {
                this.numeric_mar_capusta.Visible = false;
                this.pictureBox_mar_capusta.Visible = false;
            }
        } //квашенная капуста
        public void checkBox_xalapen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_xalapen.Checked == true)
            {
                this.numeric_xalapen.Visible = true;
                this.pictureBox_xalapen.Visible = true;
                Data.Ost = Data.Ost + 1;
            }
            else
            {
                this.numeric_xalapen.Visible = false;
                this.pictureBox_xalapen.Visible = false;
                Data.Ost = Data.Ost - 1;
            }
            if (Data.Ost == 1)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = false;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 2)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = false;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 3)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = false;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost == 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = false;
            }
            if (Data.Ost > 4)
            {
                this.pictureBox_1.Visible = true;
                this.pictureBox_2.Visible = true;
                this.pictureBox_3.Visible = true;
                this.pictureBox_4.Visible = true;
                this.pictureBox_5.Visible = true;
            }
        } //халапенью
        public void checkBox_bill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bill.Checked == true)
            {
                this.numeric_dill.Visible = true;
                this.pictureBox_dill.Visible = true;
            }
            else
            {
                this.numeric_dill.Visible = false;
                this.pictureBox_dill.Visible = false;
            }
        } //укров
        public void checkBox_onion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_onion.Checked == true)
            {
                this.numeric_onion.Visible = true;
                this.pictureBox_onion.Visible = true;
            }
            else
            {
                this.numeric_onion.Visible = false;
                this.pictureBox_onion.Visible = false;
            }
        } //лук


        //готовые рецепты
        public void radioButton_ready_classic_CheckedChanged(object sender, EventArgs e)
        {

        } //класика
        public void radioButton_ready_cheesy_CheckedChanged(object sender, EventArgs e)
        {

        } //сырная
        public void radioButton_ready_bbq_CheckedChanged(object sender, EventArgs e)
        {

        } //bbq
        public void radioButton_ready_no_CheckedChanged(object sender, EventArgs e)
        {

        } //сам шеф


        //выбор колличества допинга
        public void numeric_cucumber_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach[a]) 
            { 
                Data.Summ = Data.Summ + 10;
                znach[a] = b; 
            }
            else if (b < znach[a])
            {
                Data.Summ = Data.Summ - 10;
                znach[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_cucumber.Text = $"x{Convert.ToString((int)this.numeric_cucumber.Value)}";        
        } //огурцы
        public void numeric_mar_cucumber_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_2[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_2[a] = b;
            }
            else if (b < znach_2[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_2[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_mar_cucumber.Text = $"x{Convert.ToString((int)this.numeric_mar_cucumber.Value)}";
        } //маринованые огурцы
        public void numeric_tomato_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_3[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_3[a] = b;
            }
            else if (b < znach_3[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_3[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_tomato.Text = $"x{Convert.ToString((int)this.numeric_tomato.Value)}";
        } //помидоры
        public void numeric_carrot_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_4[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_4[a] = b;
            }
            else if (b < znach_4[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_4[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_carrot.Text = $"x{Convert.ToString((int)this.numeric_carrot.Value)}";
        } //марковка
        public void numeric_pepper_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_5[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_5[a] = b;
            }
            else if (b < znach_5[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_5[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_pepper.Text = $"x{Convert.ToString((int)this.numeric_pepper.Value)}";
        } //болгарский перец
        public void numeric_salad_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_6[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_6[a] = b;
            }
            else if (b < znach_6[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_6[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_salad.Text = $"x{Convert.ToString((int)this.numeric_salad.Value)}";
        } //салатный лист
        public void numeric_mar_capusta_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_7[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_7[a] = b;
            }
            else if (b < znach_7[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_7[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_mar_capusta.Text = $"x{Convert.ToString((int)this.numeric_mar_capusta.Value)}";
        } //квашенная капуста
        public void numeric_xalapen_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_8[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_8[a] = b;
            }
            else if (b < znach_8[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_8[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_xalapen.Text = $"x{Convert.ToString((int)this.numeric_xalapen.Value)}";
        } //халапенью
        public void numeric_dill_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_9[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_9[a] = b;
            }
            else if (b < znach_9[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_9[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_dill.Text = $"x{Convert.ToString((int)this.numeric_dill.Value)}";
        } //укров
        public void numeric_onion_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(((NumericUpDown)sender).Tag);
            double b = (double)((NumericUpDown)sender).Value;
            if (b > znach_10[a])
            {
                Data.Summ = Data.Summ + 10;
                znach_10[a] = b;
            }
            else if (b < znach_10[a])
            {
                Data.Summ = Data.Summ - 10;
                znach_10[a] = b;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
            this.label_onion.Text = $"x{Convert.ToString((int)this.numeric_onion.Value)}";
        } //лук

        //кнопка "Скрутить шавуху"
        public void button_go_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //для обращения ко второй форме
            this.Hide();
            f2.Show();
        }

        //тут подсказки и подгрузка эллементов
        public void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(radioButton_lavash, "Свежий, хрустящий лаваш");
            t.SetToolTip(radioButton_pita, "Вкусаная, магкая, пита блитсящая");
            t.SetToolTip(radioButton_tarelka, "Тарелка, только для самых богатых");

            t.SetToolTip(radioButton_chiken, "Ко-ко-ко");
            t.SetToolTip(radioButton_pork, "Хрю-Хрю-Хрю");
            t.SetToolTip(radioButton_mutton, "Бе-бе-бе");

            t.SetToolTip(radioButton__calssic, "Классический, чесночно-сливочный соус, самое то!");
            t.SetToolTip(radioButton__cheesy, "Мощныйший сырный соус, идеально подходит для любителей сыра");
            t.SetToolTip(radioButton__bbq, "Соус барбекю, идеально подходит к свинине");
            t.SetToolTip(radioButton_adjika, "Домашняя, выдерженная острая аджика, идеально дополнит любое блюдо");
            t.SetToolTip(radioButton__1000island, "Пикантный соус 1000 островов, для любителей лёгкой заправки");
            t.SetToolTip(radioButton__super, "Для любителей острой кухни!");
            t.SetToolTip(radioButton__no, "Ну и странный Вы человек!");

            t.SetToolTip(radioButton__min, "Чуть-чуть пощекочет Ваш язык");
            t.SetToolTip(radioButton__middel, "Самое то если хочеться чего-нибдь остренького");
            t.SetToolTip(radioButton__high, "Будет остро, но терпимо. Рекомендую!");
            t.SetToolTip(radioButton__super, "Яркое пламя, пронзит Ваш язык. Возьмите еще молоко!");

            t.SetToolTip(checkBox_cucumber, "Огурцы с нашей грядки, только свежие и вкусные");
            t.SetToolTip(checkBox_mar_cucumber, "Мариновыные огурчики, изящно поддчеркнут вкус Вашего блюда");
            t.SetToolTip(checkBox_tomato, "Помидорка добавит сочности к шаверме и непердоваемый вкус");
            t.SetToolTip(checkBox_mar_capusta, "Бабушкина, квашеная капуста, ни кого не оставен равнодушним");
            t.SetToolTip(checkBox_carrot, "Оранжевая марковка, никогда не будет лишней!");
            t.SetToolTip(checkBox_xalapen, "Халапенью, добавит капельку остроты в Ваше блюдо");
            t.SetToolTip(checkBox_salad, "Без него просто ни куда!");
            t.SetToolTip(checkBox_bill, "Просто вкусно");
            t.SetToolTip(checkBox_onion, "Вкусее, только с луком!");

            t.SetToolTip(radioButton_ready_classic, "Лаваш, курица, класический соус, огурцы, салатный лист, помидоры, лук, маринованые огурчики");
            t.SetToolTip(radioButton_ready_bbq, "Лаваш, курица, соус BBQ, огурцы, салат, помидоры, лук, маринованый огурцы, болгарский перец, халапенью");
            t.SetToolTip(radioButton_ready_cheesy, "Лаваш, курица, сырный соус, огурцы, салат, помидоры, лук, мариновыный огурчики, болгарский перец");
            t.SetToolTip(radioButton_ready_no, "Сам себе барин");
        }

        //для коретного выхода
        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    } 
}
