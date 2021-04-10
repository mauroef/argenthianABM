
namespace CapaPresentacion
{
    partial class FormularioHabilidad
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
            this.GbHabilidad = new System.Windows.Forms.GroupBox();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.GbHabilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(12, 92);
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(116, 92);
            // 
            // GbHabilidad
            // 
            this.GbHabilidad.Controls.Add(this.TxNombre);
            this.GbHabilidad.Controls.Add(this.LbNombre);
            this.GbHabilidad.Location = new System.Drawing.Point(12, 12);
            this.GbHabilidad.Name = "GbHabilidad";
            this.GbHabilidad.Size = new System.Drawing.Size(179, 74);
            this.GbHabilidad.TabIndex = 48;
            this.GbHabilidad.TabStop = false;
            this.GbHabilidad.Text = "Habilidad";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(63, 31);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(100, 23);
            this.TxNombre.TabIndex = 1;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(6, 34);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(51, 15);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nombre";
            // 
            // FormularioHabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 130);
            this.Controls.Add(this.GbHabilidad);
            this.Name = "FormularioHabilidad";
            this.Text = "Nuevo / Editar";
            this.Controls.SetChildIndex(this.BtCancelar, 0);
            this.Controls.SetChildIndex(this.BtGuardar, 0);
            this.Controls.SetChildIndex(this.GbHabilidad, 0);
            this.GbHabilidad.ResumeLayout(false);
            this.GbHabilidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbHabilidad;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label LbNombre;
    }
}