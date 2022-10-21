using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZenitPolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tam = textBox1.Text.Length;
            char[] ent = textBox1.Text.ToCharArray();
            textBox2.Clear();

            for (int i = 0; i < tam; i++)
            {
                switch (ent[i])
                {
                    case ('Z' or 'z'):
                        if (ent[i] == 'Z')
                            textBox2.Text = textBox2.Text + 'P';
                        else
                            textBox2.Text = textBox2.Text + 'p';
                        break;
                    case ('E' or 'e'):
                        if (ent[i] == 'E')
                            textBox2.Text = textBox2.Text + 'O';
                        else
                            textBox2.Text = textBox2.Text + 'o';
                        break;
                    case ('N' or 'n'):
                        if (ent[i] == 'N')
                            textBox2.Text = textBox2.Text + 'L';
                        else
                            textBox2.Text = textBox2.Text + 'l';
                        break;
                    case ('I' or 'i'):
                        if (ent[i] == 'I')
                            textBox2.Text = textBox2.Text + 'A';
                        else
                            textBox2.Text = textBox2.Text + 'a';
                        break;
                    case ('T' or 't'):
                        if (ent[i] == 'T')
                            textBox2.Text = textBox2.Text + 'R';
                        else
                            textBox2.Text = textBox2.Text + 'r';
                        break;
                    case ('P' or 'p'):
                        if (ent[i] == 'P')
                            textBox2.Text = textBox2.Text + 'Z';
                        else
                            textBox2.Text = textBox2.Text + 'z';
                        break;
                    case ('O' or 'o'):
                        if (ent[i] == 'O')
                            textBox2.Text = textBox2.Text + 'E';
                        else
                            textBox2.Text = textBox2.Text + 'e';
                        break;
                    case ('L' or 'l'):
                        if (ent[i] == 'L')
                            textBox2.Text = textBox2.Text + 'L';
                        else
                            textBox2.Text = textBox2.Text + 'n';
                        break;
                    case ('A' or 'a'):
                        if (ent[i] == 'A')
                            textBox2.Text = textBox2.Text + 'I';
                        else
                            textBox2.Text = textBox2.Text + 'i';
                        break;
                    case ('R' or 'r'):
                        if (ent[i] == 'R')
                            textBox2.Text = textBox2.Text + 'T';
                        else
                            textBox2.Text = textBox2.Text + 't';
                        break;
                    default:
                        textBox2.Text = textBox2.Text + textBox1.Text[i];
                        break;
                }
            }
        }

    }
}

