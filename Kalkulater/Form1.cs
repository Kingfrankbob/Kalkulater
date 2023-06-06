using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulater
{
    public partial class Form1 : Form
    {
        private double? _numberTotal = null;
        private string _noomba;
        private char _previousOperation;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyPresss(object sender, KeyPressEventArgs e)
        {

        }
        private void pass(int number)
        {
            _noomba += number.ToString();
            updateText(1);
        }
        private void pass(char operater)
        {
            if(operater == '.')
            {
                _noomba += ".";
                updateText(1);
            }
            else if(_numberTotal != null && _noomba != "")
            {
                switch(operater)
                {
                    case '+':
                        _numberTotal += Double.Parse(_noomba);
                        _noomba = "";
                        updateText(1);
                        updateText(2);
                        break;
                    case '-':
                        _numberTotal -= Double.Parse(_noomba);
                        _noomba = "";
                        updateText(1);
                        updateText(2);
                        break;
                    case '*':
                        _numberTotal *= Double.Parse(_noomba);
                        _noomba = "";
                        updateText(1);
                        updateText(2);
                        break;
                    case '/':
                        _numberTotal /= Double.Parse(_noomba);
                        _noomba = "";
                        updateText(1);
                        updateText(2);
                        break;
                }
            }
            else if(_numberTotal == null && operater == ':')
            {
                _numberTotal = Double.Parse(_noomba);
                _noomba = "";
                updateText(1);
                updateText(2);
            }
            
        }
        private void updateText(int i)
        {
            if(i == 1)
                textBox1.Text = _noomba;
            if (i == 2)
                Total.Text = _numberTotal.ToString();
        }
        private void one_Click(object sender, EventArgs e)
        {
            pass(1);
        }
        private void two_Click(object sender, EventArgs e)
        {
            pass(2);
        }
        private void three_Click(object sender, EventArgs e)
        {
            pass(3);
        }
        private void four_Click(object sender, EventArgs e)
        {
            pass(4);
        }
        private void five_Click(object sender, EventArgs e)
        {
            pass(5);
        }
        private void six_Click(object sender, EventArgs e)
        {
            pass(6);
        }
        private void seven_Click(object sender, EventArgs e)
        {
            pass(7);
        }
        private void eight_Click(object sender, EventArgs e)
        {
            pass(8);
        }
        private void nine_Click(object sender, EventArgs e)
        {
            pass(9);
        }
        private void zero_Click(object sender, EventArgs e)
        {
            pass(0);
        }
        private void dec_Click(object sender, EventArgs e)
        {
            pass('.');
        }
        private void enter_Click(object sender, EventArgs e)
        {
            pass(':');
            updateText(2);
        }
        private void mult_Click(object sender, EventArgs e)
        {
            pass('*');
        }
        private void divide_Click(object sender, EventArgs e)
        {
            pass('/');
        }
        private void plus_Click(object sender, EventArgs e)
        {
            pass('+');
        }
        private void minus_Click(object sender, EventArgs e)
        {
            pass('-');
        }
        private void AllClear_Click(object sender, EventArgs e)
        {
            _numberTotal = 0;
            _noomba = "";
            updateText(1);
            updateText(2);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            _noomba = "";
            updateText(1);
        }
        private void power_Click(object sender, EventArgs e)
        {
            var power = _numberTotal ?? 0;
            power = Math.Pow(power, Double.Parse(_noomba));
            _numberTotal = power;
            updateText(2);
            _noomba = "";
            updateText(1);
        }
    }
}
