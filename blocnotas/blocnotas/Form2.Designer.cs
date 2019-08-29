namespace blocnotas
{
    partial class f_siguiente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.f_label = new System.Windows.Forms.Label();
            this.f_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(224, 27);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 2;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.Boton_buscar_Click);
            // 
            // f_label
            // 
            this.f_label.AutoSize = true;
            this.f_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_label.Location = new System.Drawing.Point(31, 78);
            this.f_label.Name = "f_label";
            this.f_label.Size = new System.Drawing.Size(0, 20);
            this.f_label.TabIndex = 3;
            // 
            // f_button
            // 
            this.f_button.Enabled = false;
            this.f_button.Location = new System.Drawing.Point(224, 74);
            this.f_button.Name = "f_button";
            this.f_button.Size = new System.Drawing.Size(75, 23);
            this.f_button.TabIndex = 4;
            this.f_button.Text = "siguiente";
            this.f_button.UseVisualStyleBackColor = true;
            this.f_button.UseWaitCursor = true;
            this.f_button.Click += new System.EventHandler(this.F_button_Click);
            // 
            // f_siguiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 121);
            this.Controls.Add(this.f_button);
            this.Controls.Add(this.f_label);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "f_siguiente";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Label f_label;
        private System.Windows.Forms.Button f_button;
    }
}