namespace JuegoAhorcado
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
            this.intentos_label = new System.Windows.Forms.Label();
            this.palabra_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adivinar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intentos_label
            // 
            this.intentos_label.AutoSize = true;
            this.intentos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intentos_label.Location = new System.Drawing.Point(36, 48);
            this.intentos_label.Name = "intentos_label";
            this.intentos_label.Size = new System.Drawing.Size(136, 25);
            this.intentos_label.TabIndex = 0;
            this.intentos_label.Text = "Intentos: * * *";
            // 
            // palabra_label
            // 
            this.palabra_label.AutoSize = true;
            this.palabra_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palabra_label.Location = new System.Drawing.Point(41, 110);
            this.palabra_label.Name = "palabra_label";
            this.palabra_label.Size = new System.Drawing.Size(165, 25);
            this.palabra_label.TabIndex = 1;
            this.palabra_label.Text = "Palabra: V_I___";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 2;
            // 
            // adivinar_button
            // 
            this.adivinar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adivinar_button.Location = new System.Drawing.Point(74, 229);
            this.adivinar_button.Name = "adivinar_button";
            this.adivinar_button.Size = new System.Drawing.Size(123, 40);
            this.adivinar_button.TabIndex = 3;
            this.adivinar_button.Text = "Adivinar";
            this.adivinar_button.UseVisualStyleBackColor = true;
            this.adivinar_button.Click += new System.EventHandler(this.Adivinar_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.adivinar_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.palabra_label);
            this.Controls.Add(this.intentos_label);
            this.Name = "Form1";
            this.Text = "Juego Ahorcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intentos_label;
        private System.Windows.Forms.Label palabra_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button adivinar_button;
    }
}

