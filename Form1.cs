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

        double[] znach = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }; //буфер для значения numeric
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
                
            }
            else
            {

            }
        } //лаваш
        private void radioButton_pita_CheckedChanged(object sender, EventArgs e)
        {

        } //пита
        private void radioButton_tarelka_CheckedChanged(object sender, EventArgs e)
        {

        } //тарелка

        //выбор мяса
        private void radioButton_chiken_CheckedChanged(object sender, EventArgs e)
        {

        } //курица
        private void radioButton_pork_CheckedChanged(object sender, EventArgs e)
        {

        } //свинина
        private void radioButton_mutton_CheckedChanged(object sender, EventArgs e)
        {

        } //баранина


        //выбор соуса
        private void radioButton__calssic_CheckedChanged(object sender, EventArgs e)
        {

        } //классический 
        private void radioButton__bbq_CheckedChanged(object sender, EventArgs e)
        {

        } //bbq
        private void radioButton__cheesy_CheckedChanged(object sender, EventArgs e)
        {

        } //сырный
        private void radioButton__super_CheckedChanged(object sender, EventArgs e)
        {

        } //острый
        private void radioButton_adjika_CheckedChanged(object sender, EventArgs e)
        {

        } //аджика


        //острота соуса
        private void radioButton__min_CheckedChanged(object sender, EventArgs e)
        {

        } //минималка
        private void radioButton__middel_CheckedChanged(object sender, EventArgs e)
        {

        } //норм
        private void radioButton__high_CheckedChanged(object sender, EventArgs e)
        {

        } //остренько
        private void radioButton__vhot_CheckedChanged(object sender, EventArgs e)
        {

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
