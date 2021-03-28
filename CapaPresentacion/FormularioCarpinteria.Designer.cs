
namespace CapaPresentacion
{
    partial class FormularioCarpinteria
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
            this.LbObjeto = new System.Windows.Forms.Label();
            this.LbSkills = new System.Windows.Forms.Label();
            this.LbMadera = new System.Windows.Forms.Label();
            this.CbObjeto = new System.Windows.Forms.ComboBox();
            this.TxSkills = new System.Windows.Forms.TextBox();
            this.TxMadera = new System.Windows.Forms.TextBox();
            this.GbCarpinteria = new System.Windows.Forms.GroupBox();
            this.GbCarpinteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(12, 147);
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(120, 147);
            // 
            // LbObjeto
            // 
            this.LbObjeto.AutoSize = true;
            this.LbObjeto.Location = new System.Drawing.Point(6, 36);
            this.LbObjeto.Name = "LbObjeto";
            this.LbObjeto.Size = new System.Drawing.Size(43, 15);
            this.LbObjeto.TabIndex = 48;
            this.LbObjeto.Text = "Objeto";
            // 
            // LbSkills
            // 
            this.LbSkills.AutoSize = true;
            this.LbSkills.Location = new System.Drawing.Point(6, 65);
            this.LbSkills.Name = "LbSkills";
            this.LbSkills.Size = new System.Drawing.Size(33, 15);
            this.LbSkills.TabIndex = 49;
            this.LbSkills.Text = "Skills";
            // 
            // LbMadera
            // 
            this.LbMadera.AutoSize = true;
            this.LbMadera.Location = new System.Drawing.Point(6, 94);
            this.LbMadera.Name = "LbMadera";
            this.LbMadera.Size = new System.Drawing.Size(47, 15);
            this.LbMadera.TabIndex = 50;
            this.LbMadera.Text = "Madera";
            // 
            // CbObjeto
            // 
            this.CbObjeto.FormattingEnabled = true;
            this.CbObjeto.Location = new System.Drawing.Point(59, 33);
            this.CbObjeto.Name = "CbObjeto";
            this.CbObjeto.Size = new System.Drawing.Size(100, 23);
            this.CbObjeto.TabIndex = 51;
            // 
            // TxSkills
            // 
            this.TxSkills.Location = new System.Drawing.Point(59, 62);
            this.TxSkills.Name = "TxSkills";
            this.TxSkills.Size = new System.Drawing.Size(100, 23);
            this.TxSkills.TabIndex = 52;
            // 
            // TxMadera
            // 
            this.TxMadera.Location = new System.Drawing.Point(59, 91);
            this.TxMadera.Name = "TxMadera";
            this.TxMadera.Size = new System.Drawing.Size(100, 23);
            this.TxMadera.TabIndex = 53;
            // 
            // GbCarpinteria
            // 
            this.GbCarpinteria.Controls.Add(this.LbObjeto);
            this.GbCarpinteria.Controls.Add(this.TxMadera);
            this.GbCarpinteria.Controls.Add(this.CbObjeto);
            this.GbCarpinteria.Controls.Add(this.LbSkills);
            this.GbCarpinteria.Controls.Add(this.LbMadera);
            this.GbCarpinteria.Controls.Add(this.TxSkills);
            this.GbCarpinteria.Location = new System.Drawing.Point(12, 12);
            this.GbCarpinteria.Name = "GbCarpinteria";
            this.GbCarpinteria.Size = new System.Drawing.Size(183, 129);
            this.GbCarpinteria.TabIndex = 54;
            this.GbCarpinteria.TabStop = false;
            this.GbCarpinteria.Text = "Carpintería";
            // 
            // FormularioCarpinteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 187);
            this.Controls.Add(this.GbCarpinteria);
            this.Name = "FormularioCarpinteria";
            this.Text = "Nuevo / Editar ";
            this.Controls.SetChildIndex(this.BtCancelar, 0);
            this.Controls.SetChildIndex(this.BtGuardar, 0);
            this.Controls.SetChildIndex(this.GbCarpinteria, 0);
            this.GbCarpinteria.ResumeLayout(false);
            this.GbCarpinteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbObjeto;
        private System.Windows.Forms.Label LbSkills;
        private System.Windows.Forms.Label LbMadera;
        private System.Windows.Forms.ComboBox CbObjeto;
        private System.Windows.Forms.TextBox TxSkills;
        private System.Windows.Forms.TextBox TxMadera;
        private System.Windows.Forms.GroupBox GbCarpinteria;
    }
}