namespace PrimeraApp
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
            this.BotonDeSaludar = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BotonDeSaludar
            // 
            this.BotonDeSaludar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonDeSaludar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonDeSaludar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotonDeSaludar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BotonDeSaludar.Location = new System.Drawing.Point(227, 97);
            this.BotonDeSaludar.Name = "BotonDeSaludar";
            this.BotonDeSaludar.Size = new System.Drawing.Size(75, 23);
            this.BotonDeSaludar.TabIndex = 0;
            this.BotonDeSaludar.Text = "Saludar";
            this.BotonDeSaludar.UseVisualStyleBackColor = false;
            this.BotonDeSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(101, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 186);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BotonDeSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonDeSaludar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

