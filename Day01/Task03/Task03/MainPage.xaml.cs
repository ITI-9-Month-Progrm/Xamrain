using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Task03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void btn0_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn0.Text;
            this.lbl1.Text = newVal;
        }
        public void btn1_clilck(object sender, EventArgs args)
           {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn1.Text;
            this.lbl1.Text = newVal;
           }
        public void btn2_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn2.Text;
            this.lbl1.Text = newVal;
        }
        public void btn3_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn3.Text;
            this.lbl1.Text = newVal;
        }
        public void btn4_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn4.Text;
            this.lbl1.Text = newVal;
        }
        public void btn5_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn5.Text;
            this.lbl1.Text = newVal;
        }
        public void btn6_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn6.Text;
            this.lbl1.Text = newVal;
        }
        public void btn7_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn7.Text;
            this.lbl1.Text = newVal;
        }
        public void btn8_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn8.Text;
            this.lbl1.Text = newVal;
        }
        public void btn9_clilck(object sender, EventArgs args)
        {
            string oldVal, newVal;
            oldVal = this.lbl1.Text;
            newVal = oldVal + this.btn9.Text;
            this.lbl1.Text = newVal;
        }
    }
}
