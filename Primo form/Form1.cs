using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Primo_form
{
    public partial class Form1 : Form
    {

        public int dim = 0;
        public int pos = 0;
        public string[] array;

        public Form1()
        {
            InitializeComponent();
            array = new string[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richiamo la funzione di acquisizione
            aggiunta(textBox1.Text);

            //aggiunta degli elementi nella listview attraverso una funzione
            stampa(textBox1.Text);

            //una volta premuto il pulsante pulisco la textbox per poter inserire una nuova stringa
            this.textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canc(textBox2.Text);
            this.textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ricerca(textBox3.Text);
            this.textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mod(textBox4.Text);
            this.textBox4.Text = "";
        }

            public void aggiunta(string nome)
                {
                    array[dim] = nome;
                    dim++;
                }

            public void stampa(string nome)
            {
                if (pos == 0)
                {
                    this.listView1.Items.Add(nome);
                }
                else
                {
                    for (int i = 0; i < dim; i++)
                    {
                        this.listView1.Items.Add(array[i]);
                    }
                    pos = 0;
                }
            }

            public void canc(string name)
            {
                ricerca(name);
                this.listView1.Items.Clear();
                for(int i = pos - 1; i < dim; i++)
                {
                    array[i] = array[i + 1];
                }
                dim--;
                stampa(name);
            }

            public void mod(string name)
            {
                this.listView1.Items.Clear();
                stampa(name);
                array[pos - 1] = name;
            }

            public void ricerca(string name)
                {
                    for (int i = 0; i < dim; i++)
                    {
                        if (array[i] == name)
                        {
                            pos = i + 1;
                            break;
                        }
                    }
                }

    }
}
