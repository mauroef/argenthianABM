
namespace CapaPresentacion
{
    partial class GrillaHabilidad
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
            this.DataGridViewHabilidad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHabilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(12, 168);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(431, 168);
            // 
            // DataGridViewHabilidad
            // 
            this.DataGridViewHabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHabilidad.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewHabilidad.Name = "DataGridViewHabilidad";
            this.DataGridViewHabilidad.RowTemplate.Height = 25;
            this.DataGridViewHabilidad.Size = new System.Drawing.Size(494, 150);
            this.DataGridViewHabilidad.TabIndex = 6;
            this.DataGridViewHabilidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHabilidad_CellClick);
            // 
            // GrillaHabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 202);
            this.Controls.Add(this.DataGridViewHabilidad);
            this.Name = "GrillaHabilidad";
            this.Text = "Habilidad";
            this.Controls.SetChildIndex(this.BtCerrar, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.DataGridViewHabilidad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHabilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewHabilidad;
    }
}