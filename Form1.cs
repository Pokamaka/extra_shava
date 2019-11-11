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

        //буфер для значения numeric
        double[] znach = { 0, 0, 0, 0 }; 
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
        private void radioButton_lavash_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_lavash.Checked == true)
            {
                Data.Summ = Data.Summ + 30;
                Data.Callories = Data.Callories + 20;
            }
            else
            {
                Data.Summ = Data.Summ - 30;
                Data.Callories = Data.Callories - 20;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //лаваш
        private void radioButton_pita_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pita.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
                Data.Callories = Data.Callories + 25;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
                Data.Callories = Data.Callories - 25;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //пита
        private void radioButton_tarelka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_tarelka.Checked == true)
            {
                Data.Summ = Data.Summ + 50;
            }
            else
            {
                Data.Summ = Data.Summ - 50;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //тарелка

        //выбор мяса
        private void radioButton_chiken_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton_pork_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton_mutton_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton__calssic_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton__bbq_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton__cheesy_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton__super_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__super.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Callories = Data.Callories + 25;
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Callories = Data.Callories - 25;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //острый
        private void radioButton_adjika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_adjika.Checked == true)
            {
                Data.Summ = Data.Summ + 40;
                Data.Callories = Data.Callories + 25;
            }
            else
            {
                Data.Summ = Data.Summ - 40;
                Data.Callories = Data.Callories - 25;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //аджика
        private void radioButton__1000island_CheckedChanged(object sender, EventArgs e)
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
        private void radioButton__min_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__min.Checked == true)
            {
                Data.Summ = Data.Summ + 5;
            }
            else
            {
                Data.Summ = Data.Summ - 5;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //минималка
        private void radioButton__middel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__middel.Checked == true)
            {
                Data.Summ = Data.Summ + 10;
            }
            else
            {
                Data.Summ = Data.Summ - 10;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //норм
        private void radioButton__high_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__high.Checked == true)
            {
                Data.Summ = Data.Summ + 15;
            }
            else
            {
                Data.Summ = Data.Summ - 15;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //остренько
        private void radioButton__vhot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton__vhot.Checked == true)
            {
                Data.Summ = Data.Summ + 20;
            }
            else
            {
                Data.Summ = Data.Summ - 20;
            }
            this.label__SummShava.Text = $"{Data.Summ} руб.";
        } //пожар
   
        
        //выбор допинга
        private void checkBox_cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cucumber.Checked == true)
            {
                this.numeric_cucumber.Visible = true;
            }
            else
            {
                this.numeric_cucumber.Visible = false;
            }
        } //огурцы
        private void checkBox_mar_cucumber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mar_cucumber.Checked == true)
            {
                this.numeric_mar_cucumber.Visible = true;
            }
            else
            {
                this.numeric_mar_cucumber.Visible = false;
            }
        } //маринованые огурцы
        private void checkBox_tomato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tomato.Checked == true)
            {
                this.numeric_tomato.Visible = true;
            }
            else
            {
                this.numeric_tomato.Visible = false;
            }
        } //помидоры
        private void checkBox_carrot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_carrot.Checked == true)
            {
                this.numeric_carrot.Visible = true;
            }
            else
            {
                this.numeric_carrot.Visible = false;
            }
        } //марковка
        private void checkBox_pepper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pepper.Checked == true)
            {
                this.numeric_pepper.Visible = true;
            }
            else
            {
                this.numeric_pepper.Visible = false;
            }
        } //болгарский перец
        private void checkBox_salad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_salad.Checked == true)
            {
                this.numeric_salad.Visible = true;
            }
            else
            {
                this.numeric_salad.Visible = false;
            }
        } //салатный лист
        private void checkBox_mar_capusta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mar_capusta.Checked == true)
            {
                this.numeric_mar_capusta.Visible = true;
            }
            else
            {
                this.numeric_mar_capusta.Visible = false;
            }
        } //квашенная капуста
        private void checkBox_xalapen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_xalapen.Checked == true)
            {
                this.numeric_xalapen.Visible = true;
            }
            else
            {
                this.numeric_xalapen.Visible = false;
            }
        } //халапенью
        private void checkBox_bill_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bill.Checked == true)
            {
                this.numeric_dill.Visible = true;
            }
            else
            {
                this.numeric_dill.Visible = false;
            }
        } //укров
        private void checkBox_onion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_onion.Checked == true)
            {
                this.numeric_onion.Visible = true;
            }
            else
            {
                this.numeric_onion.Visible = false;
            }
        } //лук


        //готовые рецепты
        private void radioButton_ready_classic_CheckedChanged(object sender, EventArgs e)
        {

        } //класика
        private void radioButton_ready_cheesy_CheckedChanged(object sender, EventArgs e)
        {

        } //сырная
        private void radioButton_ready_bbq_CheckedChanged(object sender, EventArgs e)
        {

        } //bbq
        private void radioButton_ready_no_CheckedChanged(object sender, EventArgs e)
        {

        } //сам шеф


        //выбор колличества допинга
        private void numeric_cucumber_ValueChanged(object sender, EventArgs e)
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

        } //огурцы
        private void numeric_mar_cucumber_ValueChanged(object sender, EventArgs e)
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
        } //маринованые огурцы
        private void numeric_tomato_ValueChanged(object sender, EventArgs e)
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
        } //помидоры
        private void numeric_carrot_ValueChanged(object sender, EventArgs e)
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
        } //марковка
        private void numeric_pepper_ValueChanged(object sender, EventArgs e)
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
        } //болгарский перец
        private void numeric_salad_ValueChanged(object sender, EventArgs e)
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
        } //салатный лист
        private void numeric_mar_capusta_ValueChanged(object sender, EventArgs e)
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
        } //квашенная капуста
        private void numeric_xalapen_ValueChanged(object sender, EventArgs e)
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
        } //халапенью
        private void numeric_dill_ValueChanged(object sender, EventArgs e)
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
        } //укров
        private void numeric_onion_ValueChanged(object sender, EventArgs e)
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
        } //лук

        
    } 
}
