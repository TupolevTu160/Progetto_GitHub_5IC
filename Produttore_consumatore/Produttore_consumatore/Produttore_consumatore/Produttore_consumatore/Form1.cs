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
        public bool cambiato = false; //controllo il contenuto delle textbox
        public int primocambio = 0; //per evitare mi chieda la domanda di update textbox la prima volta
        public string testocambiocons; //copio qui i numeri, in caso di richiesta di update = false (consumatore)
        public string testocambioprod; //copio qui i numeri, in caso di richiesta di update = false (produttore)
        public int numeritot;

        private void btn_crea_Click(object sender, EventArgs e)
        {
            if (cambiato == true && primocambio==1)
            {
                var result= MessageBox.Show("Cambio tabella rilevato, le modifiche attuali verranno perse", "Richiesta aggiornamento tabella", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    btn_no.Visible = false;
                    dtv_tabella.Rows.Clear();
                    try
                    {
                        label7.Visible = false;
                        if (txt_consumatore.Text != "" && txt_produttore.Text != "")
                        {
                            testocambioprod = txt_produttore.Text;
                            testocambiocons = txt_consumatore.Text;

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
                    if (txt_consumatore.Text != "" && txt_produttore.Text != "")
                    {
                        int numeritot = int.Parse(txt_consumatore.Text) * int.Parse(txt_produttore.Text);
                    }
                    else
                    {
                        label7.Visible = true;
                    }
                    cambiato = false;
                }

                if (result == DialogResult.No)
                {
                    txt_produttore.Text= testocambioprod;
                     txt_consumatore.Text= testocambiocons;
                    cambiato = false;
                    return;
                }

        } //-----------------------------------FINE cambio=true e la seconda volta di creazione
            if (cambiato == true)
            {
                primocambio = 1;
                try
                {
                    label7.Visible = false;
                    if (txt_consumatore.Text != "" && txt_produttore.Text != "")
                    {
                        testocambioprod = txt_produttore.Text;
                        testocambiocons = txt_consumatore.Text;
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
                if (txt_consumatore.Text != "" && txt_produttore.Text != "")
                {
                    int numeritot = int.Parse(txt_consumatore.Text) * int.Parse(txt_produttore.Text);
                }
                else
                {
                    label7.Visible = true;
                }
                cambiato = false;
            }
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

            try
            {
                if (txt_costo1.Text != "" && txt_costo2.Text != "" && txt_pro1.Text != "" && txt_pro2.Text != "")
                {
                    label8.Visible = false;
                    int colonne = int.Parse(txt_consumatore.Text);
                    int righe = int.Parse(txt_produttore.Text);
                    int sommafinale = 0; //indica il valore dell'ultima posizione colonna-riga
                    int somma = 0;//indica solo il valore dell'ultima colonna
                    Random r1 = new Random();
                    for (int i = 0; i < righe; i++)
                    {
                        //dtv_tabella.Columns[i].ReadOnly.ToString(); //disabilitare la scrittura
                        for (int j = 0; j < colonne; j++)
                        {
                            int numero = r1.Next(int.Parse(txt_costo1.Text), int.Parse(txt_costo2.Text));
                            dtv_tabella.Rows[i].Cells[j].Value = numero;
                           
                        }

                        //dtv_tabella.Rows[righe].Cells[colonne].Value = numero;
                    }
                    Random r2 = new Random();
                    for (int i = 0; i < righe; i++)
                    {
                        //dtv_tabella.Columns[i].ReadOnly.ToString(); //disabilitare la scrittura
                        for (int j = 0; j < colonne; j++)
                        {
                            int numero2 = r2.Next(int.Parse(txt_pro1.Text), int.Parse(txt_pro2.Text));
                            dtv_tabella.Rows[righe].Cells[j].Value = numero2;
                        }

                        //dtv_tabella.Rows[righe].Cells[colonne].Value = numero;
                    }

                    for (int i = 0; i < colonne; i++)
                    {
                        //dtv_tabella.Columns[i].ReadOnly.ToString(); //disabilitare la scrittura
                        for (int j = 0; j < righe-1; j++)
                        {
                            int numero2 = r2.Next(int.Parse(txt_pro1.Text), int.Parse(txt_pro2.Text));
                            dtv_tabella.Rows[j].Cells[colonne].Value = numero2;
                        }
                        //dtv_tabella.Rows[righe].Cells[colonne].Value = numero;
                    }

//-------------------------------------------------------------TOTALE -----------------------------------------------
                        for(int j=0; j < colonne; j++)
                        {
                            sommafinale += Convert.ToInt32(dtv_tabella.Rows[righe].Cells[j].Value);
                        }
                    for (int i = 0; i < colonne; i++)
                    {
                        for (int j = 0; j < righe - 1; j++)
                        {
                            dtv_tabella.Rows[righe].Cells[colonne].Value = sommafinale;
                        }
                    }
//-------------------------------------------------------------SOMMA -----------------------------------------------
                    
                        for (int j = 0; j < righe-1; j++)
                        {
                           somma+= Convert.ToInt32(dtv_tabella.Rows[j].Cells[colonne].Value);
                        }
                    for (int i = 0; i < righe; i++)
                    {
                        for (int j = 0; j < colonne - 1; j++)
                        {
                            if (sommafinale - somma >= 0)
                            {
                                dtv_tabella.Rows[righe - 1].Cells[colonne].Value = sommafinale - somma;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    //------------------------------------------NORD-OVEST-------------------------------------------------------------------------------------
                    btn_no.Visible = true;
                }
            }
            catch {
                    label8.Visible = true;
                    return;
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



//----------------------------------------------EVENTI PER I CONTROLLI--------------------------------------------------
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

        private void txt_produttore_TextChanged(object sender, EventArgs e)
        {
            cambiato = true;
        }

        private void txt_consumatore_TextChanged(object sender, EventArgs e)
        {
            cambiato = true;
        }

        private void dtv_tabella_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
        //**************************metodo del NORD OVEST************************************
        private void btn_no_Click(object sender, EventArgs e)
        {
            int colonne = int.Parse(txt_consumatore.Text);
            int righe = int.Parse(txt_produttore.Text);
            //int num_riga;
                
            //for (int i=0;i<colonne;i++) 
            //{
                for (int j = 0; j < righe-1; j++)
                {
                    while (Convert.ToInt32(dtv_tabella.Rows[righe].Cells[j].Value) < Convert.ToInt32(dtv_tabella.Rows[0].Cells[colonne].Value))
                    {
                        /*num_riga = Convert.ToInt32(dtv_tabella.Rows[0].Cells[colonne-j].Value) - Convert.ToInt32(dtv_tabella.Rows[righe].Cells[0].Value);
                        dtv_tabella.Rows[0].Cells[colonne-j].Value = num_riga;*/
                        dtv_tabella.Columns.Remove(dtv_tabella.Columns[j]);
                    colonne -= 1;
                }
                /*else if (Convert.ToInt32(dtv_tabella.Rows[righe].Cells[0+j].Value) > Convert.ToInt32(dtv_tabella.Rows[0].Cells[colonne].Value))
                {
                    num_riga = Convert.ToInt32(dtv_tabella.Rows[righe-i].Cells[0+j].Value) - Convert.ToInt32(dtv_tabella.Rows[0+i].Cells[colonne-j].Value);
                    dtv_tabella.Rows[righe-i].Cells[0+j].Value = num_riga;
                    dtv_tabella.Rows.Remove(dtv_tabella.Rows[0+i]);
                    righe -= i;
                }
                else if (Convert.ToInt32(dtv_tabella.Rows[righe].Cells[0+j].Value) == Convert.ToInt32(dtv_tabella.Rows[0+i].Cells[colonne].Value))
                {
                    dtv_tabella.Columns.Remove(dtv_tabella.Columns[0+j]);
                    dtv_tabella.Rows.Remove(dtv_tabella.Rows[0+i]);
                    righe -= i;
                    colonne -= j;
                }*/
                //}
            }
        }
    }
}
