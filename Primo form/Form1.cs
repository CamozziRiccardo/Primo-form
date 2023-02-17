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
            //richiamo la funzione di cancellamento
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


        //funzioni di servizio
        //{

            //funzione di acquisizione
            public void aggiunta(string nome)
            {
                //inserisco il testo nella textbox nell'array
                array[dim] = nome;
                dim++;
            }

            //funzione di stampa
            public void stampa(string nome)
            {
                //se non è stata effettuata una ricerca, semplicemente stampare il valore inserito
                if (pos == 0)
                {
                    this.listView1.Items.Add(nome);
                }
                //nel caso fosse stata effettuata una ricerca, per cancellamento o modifica, ristampare l'intero array...
                else
                {
                    for (int i = 0; i < dim; i++)
                    {
                        this.listView1.Items.Add(array[i]);
                    }
                    //... e resettare la variabile pos per poter decidere se inserire normalmente una stringa singola
                    pos = 0;
                }
            }

            //funzione di cancellamento
            public void canc(string name)
            {
                //richiamo la funzione di ricerca
                ricerca(name);

                //pulisco la listview per poterla ristampare completamante
                this.listView1.Items.Clear();

                //scambio variabili per il cancellamento
                for(int i = pos - 1; i < dim; i++)
                {
                    array[i] = array[i + 1];
                }

                //diminuzione della grandezza dell'array per la cancellazione
                dim--;

                //richiamo la funzione di stampa
                stampa(name);
            }

            //funzione di modifica
            public void mod(string name)
            {
                //pulisco la listview per poterla ristampare completamante
                this.listView1.Items.Clear();

                //sostituisco la parola da modificare nella posizione trovata attraverso la ricerca
                array[pos - 1] = name;

                //richiamo la funzione di stampa
                stampa(name);
            }

            //funzione di ricerca per cancellamento e modifica
            public void ricerca(string name)
            {
                //ciclo di ricerca sequenziale
                for (int i = 0; i < dim; i++)
                {
                    //se la stringa inserita corrisponde con un elemento dell'array, prendo la posizione e rompo il ciclo
                    if (array[i] == name)
                    {
                        pos = i + 1;
                        break;
                    }
                }
            }

        //}
    }
}
