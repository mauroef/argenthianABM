
namespace CapaPresentacion
{
    partial class GrillaBase
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
            this.BtCerrar = new System.Windows.Forms.Button();
            this.BtNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(12, 234);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtCerrar.TabIndex = 4;
            this.BtCerrar.Text = "Cerrar";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(294, 234);
            this.BtNuevo.Name = "BtNuevo";
            this.BtNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtNuevo.TabIndex = 5;
            this.BtNuevo.Text = "Nuevo";
            this.BtNuevo.UseVisualStyleBackColor = true;
            this.BtNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // GrillaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 269);
            this.Controls.Add(this.BtNuevo);
            this.Controls.Add(this.BtCerrar);
            this.Name = "GrillaBase";
            this.Text = "GrillaBase";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button BtCerrar;
        protected System.Windows.Forms.Button BtNuevo;
    }
}