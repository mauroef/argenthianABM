
namespace CapaPresentacion
{
    partial class FormularioBase
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
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(12, 242);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 46;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(262, 242);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtGuardar.TabIndex = 47;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = true;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // FormularioBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 277);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.BtCancelar);
            this.Name = "FormularioBase";
            this.Text = "FormularioBase";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtCancelar;
        public System.Windows.Forms.Button BtGuardar;
    }
}