namespace app_filtros
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b_open = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_qrojo = new System.Windows.Forms.Button();
            this.b_qverde = new System.Windows.Forms.Button();
            this.b_qazul = new System.Windows.Forms.Button();
            this.b_trojo = new System.Windows.Forms.Button();
            this.b_tverde = new System.Windows.Forms.Button();
            this.b_tazul = new System.Windows.Forms.Button();
            this.b_grises = new System.Windows.Forms.Button();
            this.b_blancoNegro = new System.Windows.Forms.Button();
            this.b_negativo = new System.Windows.Forms.Button();
            this.b_sepia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(492, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(80, 316);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(12, 25);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(78, 39);
            this.b_open.TabIndex = 1;
            this.b_open.Text = "Abrir";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.B_open_Click);
            // 
            // b_reset
            // 
            this.b_reset.Enabled = false;
            this.b_reset.Location = new System.Drawing.Point(107, 25);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(78, 39);
            this.b_reset.TabIndex = 2;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.B_reset_Click);
            // 
            // b_qrojo
            // 
            this.b_qrojo.Enabled = false;
            this.b_qrojo.Location = new System.Drawing.Point(392, 63);
            this.b_qrojo.Name = "b_qrojo";
            this.b_qrojo.Size = new System.Drawing.Size(75, 23);
            this.b_qrojo.TabIndex = 3;
            this.b_qrojo.Text = "Quitar Rojo";
            this.b_qrojo.UseVisualStyleBackColor = true;
            this.b_qrojo.Click += new System.EventHandler(this.B_qrojo_Click);
            // 
            // b_qverde
            // 
            this.b_qverde.Enabled = false;
            this.b_qverde.Location = new System.Drawing.Point(392, 92);
            this.b_qverde.Name = "b_qverde";
            this.b_qverde.Size = new System.Drawing.Size(75, 23);
            this.b_qverde.TabIndex = 4;
            this.b_qverde.Text = "Quitar Verde";
            this.b_qverde.UseVisualStyleBackColor = true;
            this.b_qverde.Click += new System.EventHandler(this.B_qverde_Click);
            // 
            // b_qazul
            // 
            this.b_qazul.Enabled = false;
            this.b_qazul.Location = new System.Drawing.Point(392, 121);
            this.b_qazul.Name = "b_qazul";
            this.b_qazul.Size = new System.Drawing.Size(75, 23);
            this.b_qazul.TabIndex = 5;
            this.b_qazul.Text = "Quitar Azul";
            this.b_qazul.UseVisualStyleBackColor = true;
            this.b_qazul.Click += new System.EventHandler(this.B_qazul_Click);
            // 
            // b_trojo
            // 
            this.b_trojo.Enabled = false;
            this.b_trojo.Location = new System.Drawing.Point(392, 150);
            this.b_trojo.Name = "b_trojo";
            this.b_trojo.Size = new System.Drawing.Size(75, 23);
            this.b_trojo.TabIndex = 6;
            this.b_trojo.Text = "Todo Rojo";
            this.b_trojo.UseVisualStyleBackColor = true;
            this.b_trojo.Click += new System.EventHandler(this.B_trojo_Click);
            // 
            // b_tverde
            // 
            this.b_tverde.Enabled = false;
            this.b_tverde.Location = new System.Drawing.Point(392, 180);
            this.b_tverde.Name = "b_tverde";
            this.b_tverde.Size = new System.Drawing.Size(75, 23);
            this.b_tverde.TabIndex = 7;
            this.b_tverde.Text = "Todo Verde";
            this.b_tverde.UseVisualStyleBackColor = true;
            this.b_tverde.Click += new System.EventHandler(this.B_tverde_Click);
            // 
            // b_tazul
            // 
            this.b_tazul.Enabled = false;
            this.b_tazul.Location = new System.Drawing.Point(392, 210);
            this.b_tazul.Name = "b_tazul";
            this.b_tazul.Size = new System.Drawing.Size(75, 23);
            this.b_tazul.TabIndex = 8;
            this.b_tazul.Text = "Todo Azul";
            this.b_tazul.UseVisualStyleBackColor = true;
            this.b_tazul.Click += new System.EventHandler(this.B_tazul_Click);
            // 
            // b_grises
            // 
            this.b_grises.Enabled = false;
            this.b_grises.Location = new System.Drawing.Point(392, 240);
            this.b_grises.Name = "b_grises";
            this.b_grises.Size = new System.Drawing.Size(75, 34);
            this.b_grises.TabIndex = 9;
            this.b_grises.Text = "Escala Grises.";
            this.b_grises.UseVisualStyleBackColor = true;
            this.b_grises.Click += new System.EventHandler(this.B_grises_Click);
            // 
            // b_blancoNegro
            // 
            this.b_blancoNegro.Enabled = false;
            this.b_blancoNegro.Location = new System.Drawing.Point(392, 280);
            this.b_blancoNegro.Name = "b_blancoNegro";
            this.b_blancoNegro.Size = new System.Drawing.Size(75, 34);
            this.b_blancoNegro.TabIndex = 10;
            this.b_blancoNegro.Text = "Blanco y Negro";
            this.b_blancoNegro.UseVisualStyleBackColor = true;
            this.b_blancoNegro.Click += new System.EventHandler(this.B_blancoNegro_Click);
            // 
            // b_negativo
            // 
            this.b_negativo.Enabled = false;
            this.b_negativo.Location = new System.Drawing.Point(392, 321);
            this.b_negativo.Name = "b_negativo";
            this.b_negativo.Size = new System.Drawing.Size(75, 23);
            this.b_negativo.TabIndex = 11;
            this.b_negativo.Text = "Negativo";
            this.b_negativo.UseVisualStyleBackColor = true;
            this.b_negativo.Click += new System.EventHandler(this.B_negativo_Click);
            // 
            // b_sepia
            // 
            this.b_sepia.Enabled = false;
            this.b_sepia.Location = new System.Drawing.Point(392, 351);
            this.b_sepia.Name = "b_sepia";
            this.b_sepia.Size = new System.Drawing.Size(75, 23);
            this.b_sepia.TabIndex = 12;
            this.b_sepia.Text = "Sepia";
            this.b_sepia.UseVisualStyleBackColor = true;
            this.b_sepia.Click += new System.EventHandler(this.B_sepia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 474);
            this.Controls.Add(this.b_sepia);
            this.Controls.Add(this.b_negativo);
            this.Controls.Add(this.b_blancoNegro);
            this.Controls.Add(this.b_grises);
            this.Controls.Add(this.b_tazul);
            this.Controls.Add(this.b_tverde);
            this.Controls.Add(this.b_trojo);
            this.Controls.Add(this.b_qazul);
            this.Controls.Add(this.b_qverde);
            this.Controls.Add(this.b_qrojo);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_qrojo;
        private System.Windows.Forms.Button b_qverde;
        private System.Windows.Forms.Button b_qazul;
        private System.Windows.Forms.Button b_trojo;
        private System.Windows.Forms.Button b_tverde;
        private System.Windows.Forms.Button b_tazul;
        private System.Windows.Forms.Button b_grises;
        private System.Windows.Forms.Button b_blancoNegro;
        private System.Windows.Forms.Button b_negativo;
        private System.Windows.Forms.Button b_sepia;
    }
}

