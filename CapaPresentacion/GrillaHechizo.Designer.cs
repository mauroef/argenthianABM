
namespace CapaPresentacion
{
    partial class GrillaHechizo
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
            this.DataGridViewHechizo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHechizo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(12, 415);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(997, 415);
            // 
            // DataGridViewHechizo
            // 
            this.DataGridViewHechizo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHechizo.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewHechizo.Name = "DataGridViewHechizo";
            this.DataGridViewHechizo.RowTemplate.Height = 25;
            this.DataGridViewHechizo.Size = new System.Drawing.Size(1060, 397);
            this.DataGridViewHechizo.TabIndex = 6;
            // 
            // GrillaHechizo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.DataGridViewHechizo);
            this.Name = "GrillaHechizo";
            this.Text = "Hechizo";
            this.Controls.SetChildIndex(this.BtCerrar, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.DataGridViewHechizo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHechizo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewHechizo;
    }
}