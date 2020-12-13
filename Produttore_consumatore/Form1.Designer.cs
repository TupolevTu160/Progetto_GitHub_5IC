namespace Produttore_consumatore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtv_tabella = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_consumatore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_produttore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_crea = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_crea_casual = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pro2 = new System.Windows.Forms.TextBox();
            this.txt_pro1 = new System.Windows.Forms.TextBox();
            this.txt_costo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_costo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_tabella)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtv_tabella
            // 
            this.dtv_tabella.BackgroundColor = System.Drawing.Color.Gold;
            this.dtv_tabella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtv_tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_tabella.GridColor = System.Drawing.Color.Gold;
            this.dtv_tabella.Location = new System.Drawing.Point(12, 223);
            this.dtv_tabella.Name = "dtv_tabella";
            this.dtv_tabella.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtv_tabella.RowTemplate.Height = 24;
            this.dtv_tabella.Size = new System.Drawing.Size(1210, 368);
            this.dtv_tabella.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_consumatore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_produttore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_crea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crea Matrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(356, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Errore, riprova!";
            this.label7.Visible = false;
            // 
            // txt_consumatore
            // 
            this.txt_consumatore.Location = new System.Drawing.Point(262, 118);
            this.txt_consumatore.Name = "txt_consumatore";
            this.txt_consumatore.Size = new System.Drawing.Size(48, 28);
            this.txt_consumatore.TabIndex = 3;
            this.txt_consumatore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_consumatore_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero Consumatori";
            // 
            // txt_produttore
            // 
            this.txt_produttore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_produttore.Location = new System.Drawing.Point(262, 54);
            this.txt_produttore.Name = "txt_produttore";
            this.txt_produttore.Size = new System.Drawing.Size(48, 28);
            this.txt_produttore.TabIndex = 2;
            this.txt_produttore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_produttore_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Produttori";
            // 
            // btn_crea
            // 
            this.btn_crea.BackColor = System.Drawing.Color.LightGreen;
            this.btn_crea.Location = new System.Drawing.Point(360, 77);
            this.btn_crea.Name = "btn_crea";
            this.btn_crea.Size = new System.Drawing.Size(144, 48);
            this.btn_crea.TabIndex = 0;
            this.btn_crea.Text = "Crea";
            this.btn_crea.UseVisualStyleBackColor = false;
            this.btn_crea.Click += new System.EventHandler(this.btn_crea_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_crea_casual);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_pro2);
            this.groupBox2.Controls.Add(this.txt_pro1);
            this.groupBox2.Controls.Add(this.txt_costo2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_costo1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(541, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genera casuali";
            // 
            // btn_crea_casual
            // 
            this.btn_crea_casual.BackColor = System.Drawing.Color.LightGreen;
            this.btn_crea_casual.Location = new System.Drawing.Point(486, 77);
            this.btn_crea_casual.Name = "btn_crea_casual";
            this.btn_crea_casual.Size = new System.Drawing.Size(144, 48);
            this.btn_crea_casual.TabIndex = 3;
            this.btn_crea_casual.Text = "Crea";
            this.btn_crea_casual.UseVisualStyleBackColor = false;
            this.btn_crea_casual.Click += new System.EventHandler(this.btn_crea_casual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "-";
            // 
            // txt_pro2
            // 
            this.txt_pro2.Location = new System.Drawing.Point(405, 118);
            this.txt_pro2.Name = "txt_pro2";
            this.txt_pro2.Size = new System.Drawing.Size(48, 28);
            this.txt_pro2.TabIndex = 5;
            this.txt_pro2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pro2_KeyPress);
            // 
            // txt_pro1
            // 
            this.txt_pro1.Location = new System.Drawing.Point(308, 118);
            this.txt_pro1.Name = "txt_pro1";
            this.txt_pro1.Size = new System.Drawing.Size(48, 28);
            this.txt_pro1.TabIndex = 4;
            this.txt_pro1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pro1_KeyPress);
            // 
            // txt_costo2
            // 
            this.txt_costo2.Location = new System.Drawing.Point(405, 57);
            this.txt_costo2.Name = "txt_costo2";
            this.txt_costo2.Size = new System.Drawing.Size(48, 28);
            this.txt_costo2.TabIndex = 3;
            this.txt_costo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Range produzione/fabbisogni";
            // 
            // txt_costo1
            // 
            this.txt_costo1.Location = new System.Drawing.Point(308, 57);
            this.txt_costo1.Name = "txt_costo1";
            this.txt_costo1.Size = new System.Drawing.Size(48, 28);
            this.txt_costo1.TabIndex = 2;
            this.txt_costo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Range di costi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(482, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Errore, riprova!";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1234, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtv_tabella);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Produttore-Consumatore";
            ((System.ComponentModel.ISupportInitialize)(this.dtv_tabella)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_tabella;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_consumatore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_produttore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_crea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_costo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_costo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_crea_casual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pro2;
        private System.Windows.Forms.TextBox txt_pro1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

