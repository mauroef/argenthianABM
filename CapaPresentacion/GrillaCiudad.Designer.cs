
namespace CapaPresentacion
{
    partial class GrillaCiudad
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
            this.DataGridViewCiudad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(12, 172);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(409, 172);
            // 
            // DataGridViewCiudad
            // 
            this.DataGridViewCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCiudad.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewCiudad.Name = "DataGridViewCiudad";
            this.DataGridViewCiudad.RowTemplate.Height = 25;
            this.DataGridViewCiudad.Size = new System.Drawing.Size(472, 150);
            this.DataGridViewCiudad.TabIndex = 6;
            this.DataGridViewCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCarpinteria_CellClick);
            // 
            // GrillaCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 207);
            this.Controls.Add(this.DataGridViewCiudad);
            this.Name = "GrillaCiudad";
            this.Text = "Ciudad";
            this.Controls.SetChildIndex(this.BtCerrar, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.DataGridViewCiudad, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCiudad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewCiudad;
    }
}