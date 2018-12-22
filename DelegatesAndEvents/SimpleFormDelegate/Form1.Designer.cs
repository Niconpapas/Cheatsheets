namespace SimpleFormDelegate
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
            this.btn_Super = new System.Windows.Forms.Button();
            this.lbl_Video = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Super
            // 
            this.btn_Super.Location = new System.Drawing.Point(12, 81);
            this.btn_Super.Name = "btn_Super";
            this.btn_Super.Size = new System.Drawing.Size(75, 23);
            this.btn_Super.TabIndex = 0;
            this.btn_Super.Text = "SuperBoton";
            this.btn_Super.UseVisualStyleBackColor = true;
            this.btn_Super.Click += new System.EventHandler(this.btn_Super_Click);
            // 
            // lbl_Video
            // 
            this.lbl_Video.AutoSize = true;
            this.lbl_Video.Location = new System.Drawing.Point(94, 90);
            this.lbl_Video.Name = "lbl_Video";
            this.lbl_Video.Size = new System.Drawing.Size(0, 13);
            this.lbl_Video.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Video);
            this.Controls.Add(this.btn_Super);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Super;
        private System.Windows.Forms.Label lbl_Video;
    }
}

