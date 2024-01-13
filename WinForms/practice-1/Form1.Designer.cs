namespace practice_1
{
    partial class wnd1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Moccasin;
            this.btn1.Image = global::practice_1.Properties.Resources.AsgardFull;
            this.btn1.Location = new System.Drawing.Point(229, 207);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(249, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Aceptar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Location = new System.Drawing.Point(121, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "I\'m a label";
            // 
            // wnd1
            // 
            this.AccessibleName = "wnd1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "wnd1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFirstApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btn1_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
    }
}

