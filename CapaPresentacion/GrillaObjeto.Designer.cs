
namespace CapaPresentacion
{
    partial class GrillaObjeto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewObjeto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewObjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(12, 421);
            // 
            // BtNuevo
            // 
            this.BtNuevo.Location = new System.Drawing.Point(885, 421);
            // 
            // DataGridViewObjeto
            // 
            this.DataGridViewObjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewObjeto.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewObjeto.Name = "DataGridViewObjeto";
            this.DataGridViewObjeto.RowTemplate.Height = 25;
            this.DataGridViewObjeto.Size = new System.Drawing.Size(948, 403);
            this.DataGridViewObjeto.TabIndex = 0;
            this.DataGridViewObjeto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewObjeto_CellClick);
            // 
            // GrillaObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(972, 456);
            this.Controls.Add(this.DataGridViewObjeto);
            this.Name = "GrillaObjeto";
            this.Text = "Objetos";
            this.Controls.SetChildIndex(this.DataGridViewObjeto, 0);
            this.Controls.SetChildIndex(this.BtNuevo, 0);
            this.Controls.SetChildIndex(this.BtCerrar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewObjeto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewObjeto;
    }
}

