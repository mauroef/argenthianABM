
namespace CapaPresentacion
{
    partial class FormularioCiudad
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
            this.GbCiudad = new System.Windows.Forms.GroupBox();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.GbCiudad.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(12, 70);
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(114, 70);
            // 
            // GbCiudad
            // 
            this.GbCiudad.Controls.Add(this.TxNombre);
            this.GbCiudad.Controls.Add(this.LbNombre);
            this.GbCiudad.Location = new System.Drawing.Point(12, 12);
            this.GbCiudad.Name = "GbCiudad";
            this.GbCiudad.Size = new System.Drawing.Size(177, 52);
            this.GbCiudad.TabIndex = 0;
            this.GbCiudad.TabStop = false;
            this.GbCiudad.Text = "Ciudad";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(63, 20);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(100, 23);
            this.TxNombre.TabIndex = 48;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(6, 23);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(51, 15);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nombre";
            // 
            // FormularioCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 112);
            this.Controls.Add(this.GbCiudad);
            this.Name = "FormularioCiudad";
            this.Text = "Nuevo / Editar";
            this.Controls.SetChildIndex(this.GbCiudad, 0);
            this.Controls.SetChildIndex(this.BtCancelar, 0);
            this.Controls.SetChildIndex(this.BtGuardar, 0);
            this.GbCiudad.ResumeLayout(false);
            this.GbCiudad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCiudad;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label LbNombre;
    }
}