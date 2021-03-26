
namespace CapaPresentacion
{
    partial class GrillaCarpinteria
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
            this.DataGridViewCarpinteria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarpinteria)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(12, 415);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(473, 415);
            // 
            // DataGridViewCarpinteria
            // 
            this.DataGridViewCarpinteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCarpinteria.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewCarpinteria.Name = "DataGridViewCarpinteria";
            this.DataGridViewCarpinteria.RowTemplate.Height = 25;
            this.DataGridViewCarpinteria.Size = new System.Drawing.Size(536, 397);
            this.DataGridViewCarpinteria.TabIndex = 6;
            this.DataGridViewCarpinteria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCarpinteria_CellClick);
            // 
            // GrillaCarpinteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.DataGridViewCarpinteria);
            this.Name = "GrillaCarpinteria";
            this.Text = "Carpinteria";
            this.Controls.SetChildIndex(this.BtCerrar, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.DataGridViewCarpinteria, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarpinteria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewCarpinteria;
    }
}