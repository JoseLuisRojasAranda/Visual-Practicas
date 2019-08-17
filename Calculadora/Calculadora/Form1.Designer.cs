namespace Calculadora
{
    partial class Calculadora
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
            this.texto_mensaje = new System.Windows.Forms.Label();
            this.b_num_1 = new System.Windows.Forms.Button();
            this.b_num_2 = new System.Windows.Forms.Button();
            this.b_num_3 = new System.Windows.Forms.Button();
            this.b_num_4 = new System.Windows.Forms.Button();
            this.b_num_5 = new System.Windows.Forms.Button();
            this.b_num_6 = new System.Windows.Forms.Button();
            this.b_num_7 = new System.Windows.Forms.Button();
            this.b_num_8 = new System.Windows.Forms.Button();
            this.b_num_9 = new System.Windows.Forms.Button();
            this.b_num_0 = new System.Windows.Forms.Button();
            this.b_punto = new System.Windows.Forms.Button();
            this.texto_debug = new System.Windows.Forms.Label();
            this.b_equal = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_times = new System.Windows.Forms.Button();
            this.b_div = new System.Windows.Forms.Button();
            this.b_ans = new System.Windows.Forms.Button();
            this.b_sign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto_mensaje
            // 
            this.texto_mensaje.AutoSize = true;
            this.texto_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_mensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.texto_mensaje.Location = new System.Drawing.Point(24, 37);
            this.texto_mensaje.Name = "texto_mensaje";
            this.texto_mensaje.Size = new System.Drawing.Size(24, 25);
            this.texto_mensaje.TabIndex = 0;
            this.texto_mensaje.Text = "0";
            this.texto_mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_num_1
            // 
            this.b_num_1.Location = new System.Drawing.Point(29, 280);
            this.b_num_1.Name = "b_num_1";
            this.b_num_1.Size = new System.Drawing.Size(53, 48);
            this.b_num_1.TabIndex = 1;
            this.b_num_1.Text = "1";
            this.b_num_1.UseVisualStyleBackColor = true;
            this.b_num_1.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_2
            // 
            this.b_num_2.Location = new System.Drawing.Point(104, 280);
            this.b_num_2.Name = "b_num_2";
            this.b_num_2.Size = new System.Drawing.Size(53, 48);
            this.b_num_2.TabIndex = 2;
            this.b_num_2.Text = "2";
            this.b_num_2.UseVisualStyleBackColor = true;
            this.b_num_2.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_3
            // 
            this.b_num_3.Location = new System.Drawing.Point(180, 280);
            this.b_num_3.Name = "b_num_3";
            this.b_num_3.Size = new System.Drawing.Size(53, 48);
            this.b_num_3.TabIndex = 3;
            this.b_num_3.Text = "3";
            this.b_num_3.UseVisualStyleBackColor = true;
            this.b_num_3.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_4
            // 
            this.b_num_4.Location = new System.Drawing.Point(29, 212);
            this.b_num_4.Name = "b_num_4";
            this.b_num_4.Size = new System.Drawing.Size(53, 48);
            this.b_num_4.TabIndex = 4;
            this.b_num_4.Text = "4";
            this.b_num_4.UseVisualStyleBackColor = true;
            this.b_num_4.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_5
            // 
            this.b_num_5.Location = new System.Drawing.Point(104, 212);
            this.b_num_5.Name = "b_num_5";
            this.b_num_5.Size = new System.Drawing.Size(53, 48);
            this.b_num_5.TabIndex = 5;
            this.b_num_5.Text = "5";
            this.b_num_5.UseVisualStyleBackColor = true;
            this.b_num_5.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_6
            // 
            this.b_num_6.Location = new System.Drawing.Point(180, 212);
            this.b_num_6.Name = "b_num_6";
            this.b_num_6.Size = new System.Drawing.Size(53, 48);
            this.b_num_6.TabIndex = 6;
            this.b_num_6.Text = "6";
            this.b_num_6.UseVisualStyleBackColor = true;
            this.b_num_6.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_7
            // 
            this.b_num_7.Location = new System.Drawing.Point(29, 147);
            this.b_num_7.Name = "b_num_7";
            this.b_num_7.Size = new System.Drawing.Size(53, 48);
            this.b_num_7.TabIndex = 7;
            this.b_num_7.Text = "7";
            this.b_num_7.UseVisualStyleBackColor = true;
            this.b_num_7.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_8
            // 
            this.b_num_8.Location = new System.Drawing.Point(104, 147);
            this.b_num_8.Name = "b_num_8";
            this.b_num_8.Size = new System.Drawing.Size(53, 48);
            this.b_num_8.TabIndex = 8;
            this.b_num_8.Text = "8";
            this.b_num_8.UseVisualStyleBackColor = true;
            this.b_num_8.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_9
            // 
            this.b_num_9.Location = new System.Drawing.Point(180, 147);
            this.b_num_9.Name = "b_num_9";
            this.b_num_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_num_9.Size = new System.Drawing.Size(53, 48);
            this.b_num_9.TabIndex = 9;
            this.b_num_9.Text = "9";
            this.b_num_9.UseVisualStyleBackColor = true;
            this.b_num_9.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_num_0
            // 
            this.b_num_0.Location = new System.Drawing.Point(29, 343);
            this.b_num_0.Name = "b_num_0";
            this.b_num_0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_num_0.Size = new System.Drawing.Size(128, 48);
            this.b_num_0.TabIndex = 10;
            this.b_num_0.Text = "0";
            this.b_num_0.UseVisualStyleBackColor = true;
            this.b_num_0.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_punto
            // 
            this.b_punto.Location = new System.Drawing.Point(180, 343);
            this.b_punto.Name = "b_punto";
            this.b_punto.Size = new System.Drawing.Size(53, 48);
            this.b_punto.TabIndex = 11;
            this.b_punto.Text = ".";
            this.b_punto.UseVisualStyleBackColor = true;
            this.b_punto.Click += new System.EventHandler(this.HandleButton);
            // 
            // texto_debug
            // 
            this.texto_debug.AutoSize = true;
            this.texto_debug.Location = new System.Drawing.Point(362, 84);
            this.texto_debug.Name = "texto_debug";
            this.texto_debug.Size = new System.Drawing.Size(35, 13);
            this.texto_debug.TabIndex = 12;
            this.texto_debug.Text = "label1";
            // 
            // b_equal
            // 
            this.b_equal.Location = new System.Drawing.Point(252, 343);
            this.b_equal.Name = "b_equal";
            this.b_equal.Size = new System.Drawing.Size(52, 48);
            this.b_equal.TabIndex = 13;
            this.b_equal.Text = "=";
            this.b_equal.UseVisualStyleBackColor = true;
            this.b_equal.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_plus
            // 
            this.b_plus.Location = new System.Drawing.Point(252, 280);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(52, 48);
            this.b_plus.TabIndex = 14;
            this.b_plus.Text = "+";
            this.b_plus.UseVisualStyleBackColor = true;
            this.b_plus.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_minus
            // 
            this.b_minus.Location = new System.Drawing.Point(252, 212);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(52, 48);
            this.b_minus.TabIndex = 15;
            this.b_minus.Text = "--";
            this.b_minus.UseVisualStyleBackColor = true;
            this.b_minus.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_times
            // 
            this.b_times.Location = new System.Drawing.Point(252, 147);
            this.b_times.Name = "b_times";
            this.b_times.Size = new System.Drawing.Size(52, 48);
            this.b_times.TabIndex = 16;
            this.b_times.Text = "X";
            this.b_times.UseVisualStyleBackColor = true;
            this.b_times.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_div
            // 
            this.b_div.Location = new System.Drawing.Point(252, 84);
            this.b_div.Name = "b_div";
            this.b_div.Size = new System.Drawing.Size(52, 48);
            this.b_div.TabIndex = 17;
            this.b_div.Text = "/";
            this.b_div.UseVisualStyleBackColor = true;
            this.b_div.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_ans
            // 
            this.b_ans.Location = new System.Drawing.Point(29, 84);
            this.b_ans.Name = "b_ans";
            this.b_ans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_ans.Size = new System.Drawing.Size(128, 48);
            this.b_ans.TabIndex = 18;
            this.b_ans.Text = "Ans";
            this.b_ans.UseVisualStyleBackColor = true;
            this.b_ans.Click += new System.EventHandler(this.HandleButton);
            // 
            // b_sign
            // 
            this.b_sign.Location = new System.Drawing.Point(180, 84);
            this.b_sign.Name = "b_sign";
            this.b_sign.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_sign.Size = new System.Drawing.Size(53, 48);
            this.b_sign.TabIndex = 19;
            this.b_sign.Text = "+/-";
            this.b_sign.UseVisualStyleBackColor = true;
            this.b_sign.Click += new System.EventHandler(this.HandleButton);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.b_sign);
            this.Controls.Add(this.b_ans);
            this.Controls.Add(this.b_div);
            this.Controls.Add(this.b_times);
            this.Controls.Add(this.b_minus);
            this.Controls.Add(this.b_plus);
            this.Controls.Add(this.b_equal);
            this.Controls.Add(this.texto_debug);
            this.Controls.Add(this.b_punto);
            this.Controls.Add(this.b_num_0);
            this.Controls.Add(this.b_num_9);
            this.Controls.Add(this.b_num_8);
            this.Controls.Add(this.b_num_7);
            this.Controls.Add(this.b_num_6);
            this.Controls.Add(this.b_num_5);
            this.Controls.Add(this.b_num_4);
            this.Controls.Add(this.b_num_3);
            this.Controls.Add(this.b_num_2);
            this.Controls.Add(this.b_num_1);
            this.Controls.Add(this.texto_mensaje);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto_mensaje;
        private System.Windows.Forms.Button b_num_1;
        private System.Windows.Forms.Button b_num_2;
        private System.Windows.Forms.Button b_num_3;
        private System.Windows.Forms.Button b_num_4;
        private System.Windows.Forms.Button b_num_5;
        private System.Windows.Forms.Button b_num_6;
        private System.Windows.Forms.Button b_num_7;
        private System.Windows.Forms.Button b_num_8;
        private System.Windows.Forms.Button b_num_9;
        private System.Windows.Forms.Button b_num_0;
        private System.Windows.Forms.Button b_punto;
        private System.Windows.Forms.Label texto_debug;
        private System.Windows.Forms.Button b_equal;
        private System.Windows.Forms.Button b_plus;
        private System.Windows.Forms.Button b_minus;
        private System.Windows.Forms.Button b_times;
        private System.Windows.Forms.Button b_div;
        private System.Windows.Forms.Button b_ans;
        private System.Windows.Forms.Button b_sign;
    }
}

