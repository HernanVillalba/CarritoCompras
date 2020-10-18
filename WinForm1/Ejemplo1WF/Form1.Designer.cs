namespace Ejemplo1WF
{
    partial class Hola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hola));
            this.BotonSaludar = new System.Windows.Forms.Button();
            this.BotonNoSaludar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BotonSaludar
            // 
            this.BotonSaludar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BotonSaludar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BotonSaludar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonSaludar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonSaludar.Location = new System.Drawing.Point(135, 84);
            this.BotonSaludar.Name = "BotonSaludar";
            this.BotonSaludar.Size = new System.Drawing.Size(109, 51);
            this.BotonSaludar.TabIndex = 0;
            this.BotonSaludar.Text = "Saludar";
            this.BotonSaludar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonSaludar.UseMnemonic = false;
            this.BotonSaludar.UseVisualStyleBackColor = false;
            this.BotonSaludar.Click += new System.EventHandler(this.BotonSaludar_Click);
            // 
            // BotonNoSaludar
            // 
            this.BotonNoSaludar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BotonNoSaludar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BotonNoSaludar.Location = new System.Drawing.Point(329, 84);
            this.BotonNoSaludar.Name = "BotonNoSaludar";
            this.BotonNoSaludar.Size = new System.Drawing.Size(75, 23);
            this.BotonNoSaludar.TabIndex = 1;
            this.BotonNoSaludar.Text = "No saludar";
            this.BotonNoSaludar.UseVisualStyleBackColor = false;
            this.BotonNoSaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.No;
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Youtube";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Hola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(508, 238);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonNoSaludar);
            this.Controls.Add(this.BotonSaludar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hola";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonSaludar;
        private System.Windows.Forms.Button BotonNoSaludar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

