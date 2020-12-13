using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Produttore_consumatore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------NOTE----------------------------------------------------------------------------
        //RICORDARSI I CONTROLLI DI QUALUNQUE GENERE --> ANCHE PER CAMBIARE LA TABELLA
        //--------------------------------------------------------------------------------------------------------------------------------------
        public int[] elecasuali;
        public int numeritot;
        private void btn_crea_Click(object sender, EventArgs e)
        {
            /* long number1 = 0;
             bool canConvert = long.TryParse(txt_produttore.Text, out number1);
             if (canConvert == true)
                 return;
             else
             {
                 MessageBox.Show("Errore.");
             }*/

            // bool cambia = false;
            try
            {
                label7.Visible = false;
                if (txt_consumatore.Text != "" && txt_produttore.Text != "")
                {
                    int colonne = int.Parse(txt_consumatore.Text);
                    int righe = int.Parse(txt_produttore.Text);
                    dtv_tabella.RowCount = righe + 1; //max 65000
                    dtv_tabella.ColumnCount = colonne + 1; //max 65000
                    for (int i = 0; i < colonne; i++)
                    {
                        dtv_tabella.Columns[i].HeaderCell.Value = "Consum. " + (i + 1);
                        dtv_tabella.Columns[i].ReadOnly.ToString(); //disabilitare la scrittura

                    }
                    for (int i = 0; i < righe; i++)
                    {
                        dtv_tabella.Rows[i].HeaderCell.Value = "Produtt. " + (i + 1);
                        dtv_tabella.Rows[i].ReadOnly.ToString();//disabilitare la scrittura
                    }
                    dtv_tabella.RowHeadersWidth = 300;
                    dtv_tabella.ColumnHeadersHeight = 300;
                    dtv_tabella.Rows[righe].HeaderCell.Value = "Fabbisogno";
                    dtv_tabella.Columns[colonne].HeaderCell.Value = "Produzione";
                }
            }
            catch
            {
                label7.Visible = true;
                txt_consumatore.Clear();
                txt_produttore.Clear();
                return;
            }
            /*if (cambia==true)
            {
             MessageBox.Show("Perdita dati");
            }
            cambia = true;*/
            int numeritot = int.Parse(txt_consumatore.Text) * int.Parse(txt_produttore.Text);
           
        }


        private void txt_consumatore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //bastava cambiare la funzione utilizzata
            {
                e.Handled = true;
                //txt_produttore.Clear();
            }
        }

        private void btn_crea_casual_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_consumatore.Text);
            for (int i = 0; i < int.Parse(txt_produttore.Text); i++)
            {
               
            }

            if (txt_consumatore.Text != "" && txt_produttore.Text != "")
            {
                int colonne = int.Parse(txt_consumatore.Text);
                int righe = int.Parse(txt_produttore.Text);
                dtv_tabella.RowCount = righe + 1; //max 65000
                dtv_tabella.ColumnCount = colonne + 1; //max 65000
                for (int i = 0; i < colonne; i++)
                {
                    dtv_tabella.Columns[i].HeaderCell.Value = "Consum. " + (i + 1);
                    dtv_tabella.Columns[i].ReadOnly.ToString(); //disabilitare la scrittura
                    Random r1 = new Random();
                    int numero = r1.Next(int.Parse(txt_costo1.Text), int.Parse(txt_costo2.Text));
                    dtv_tabella.Rows[int.Parse(txt_produttore.Text)].Cells[colonne].Value = numero;
                }
                for (int i = 0; i < righe; i++)
                {
                    dtv_tabella.Rows[i].HeaderCell.Value = "Produtt. " + (i + 1);
                    dtv_tabella.Rows[i].ReadOnly.ToString();//disabilitare la scrittura
                    Random r1 = new Random();
                    int numero = r1.Next(int.Parse(txt_costo1.Text), int.Parse(txt_costo2.Text));
                    dtv_tabella.Rows[int.Parse(txt_produttore.Text)].Cells[i].Value = numero;
                }
                dtv_tabella.RowHeadersWidth = 300;
                dtv_tabella.ColumnHeadersHeight = 300;
                dtv_tabella.Rows[righe].HeaderCell.Value = "Fabbisogno";
                dtv_tabella.Columns[colonne].HeaderCell.Value = "Produzione";
            }
            /* try
             {
                 label8.Visible = false;
                 if (txt_costo1.Text != "" && txt_costo2.Text != "" && txt_pro1.Text != "" && txt_pro2.Text != "")
                 {
                     Random r1 = new Random();
                     Random r2 = new Random();
                     int righe = r1.Next(int.Parse(txt_costo1.Text), int.Parse(txt_costo2.Text));
                     int colonne = r2.Next(int.Parse(txt_pro1.Text), int.Parse(txt_pro2.Text));
                     dtv_tabella.RowCount = righe + 1;
                     dtv_tabella.ColumnCount = colonne + 1;
                     for (int i = 0; i < colonne; i++)
                     {
                         dtv_tabella.Columns[i].HeaderCell.Value = "Consum. " + (i + 1);
                         dtv_tabella.Columns[i].ReadOnly.ToString(); //disabilitare la scrittura
                     }
                     for (int i = 0; i < righe; i++)
                     {
                         dtv_tabella.Rows[i].HeaderCell.Value = "Produtt. " + (i + 1);
                         dtv_tabella.Rows[i].ReadOnly.ToString();//disabilitare la scrittura
                     }
                     dtv_tabella.Rows[righe].HeaderCell.Value = "Fabbisogno";
                     dtv_tabella.Columns[colonne].HeaderCell.Value = "Produzione";
                 }
             }
             catch
             {
                 label8.Visible = true;
                 txt_costo1.Clear();
                 txt_costo2.Clear();
                 txt_pro1.Clear();
                 txt_pro2.Clear();
                 return;
             }*/
        }

        private void txt_costo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //bastava cambiare la funzione utilizzata
            {
                e.Handled = true;
                //txt_produttore.Clear();
            }
        }

        private void txt_costo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //bastava cambiare la funzione utilizzata
            {
                e.Handled = true;
                //txt_produttore.Clear();
            }
        }

        private void txt_pro1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //bastava cambiare la funzione utilizzata
            {
                e.Handled = true;
                //txt_produttore.Clear();
            }
        }

        private void txt_pro2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //bastava cambiare la funzione utilizzata
            {
                e.Handled = true;
                //txt_produttore.Clear();
            }
        }

        private void txt_produttore_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) //bastava cambiare la funzione utilizzata
            {
                e.Handled = true;
                //txt_produttore.Clear();
            }
        }

    }
}
