
namespace CapaPresentacion
{
    partial class Grilla
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
            this.BtGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewObjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewObjeto
            // 
            this.DataGridViewObjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewObjeto.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewObjeto.Name = "DataGridViewObjeto";
            this.DataGridViewObjeto.RowTemplate.Height = 25;
            this.DataGridViewObjeto.Size = new System.Drawing.Size(641, 274);
            this.DataGridViewObjeto.TabIndex = 0;
            this.DataGridViewObjeto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewObjeto_CellClick);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(431, 318);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtGuardar.TabIndex = 1;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // Grilla
            // 
            this.ClientSize = new System.Drawing.Size(993, 456);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.DataGridViewObjeto);
            this.Name = "Grilla";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewObjeto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewObjeto;
        private System.Windows.Forms.Button BtGuardar;
    }
}

