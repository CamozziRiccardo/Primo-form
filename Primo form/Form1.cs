using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primo_form
{
    public partial class Form1 : Form
    {
        //dichiarazione variabili
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
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


        //funzioni di servizio
        //{

            //funzione di acquisizione
            public void aggiunta(string nome)
            {
                //aggiungere all'array il valore inserito nella textbox
                array[dim] = nome;
                dim++;
            }

            //funzione di stampa
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
                        if (i + 1 != pos)
                        {
                            this.listView1.Items.Add(array[i]);
                        }
                    }
                }
            }

            //funzione di cancellamento
            public void canc(string name)
            {
                ricerca(name);
                this.listView1.Items.Clear();
                stampa(name);
            }

            //funzione di ricerca per cancellamento e modifica
            public int ricerca(string name)
            {
                for(int i = 0; i < dim; i++)
                {
                    if (array[i] == name)
                    {
                        pos = i + 1;
                        return 0;
                    }
                }

                return 0;
            }

        //}
    }
}
