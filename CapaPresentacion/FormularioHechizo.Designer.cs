
namespace CapaPresentacion
{
    partial class FormularioHechizo
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
            this.GbBase = new System.Windows.Forms.GroupBox();
            this.TxPalabrasMagicas = new System.Windows.Forms.TextBox();
            this.LbPalabrasMagicas = new System.Windows.Forms.Label();
            this.TxDescripcion = new System.Windows.Forms.TextBox();
            this.LbDescripcion = new System.Windows.Forms.Label();
            this.CbSonido = new System.Windows.Forms.ComboBox();
            this.LbSonido = new System.Windows.Forms.Label();
            this.CbEfecto = new System.Windows.Forms.ComboBox();
            this.LbEfecto = new System.Windows.Forms.Label();
            this.CbImagen = new System.Windows.Forms.ComboBox();
            this.LbImagen = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbTipo = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.GbConsum = new System.Windows.Forms.GroupBox();
            this.TxMinEnergia = new System.Windows.Forms.TextBox();
            this.LbMinEnergia = new System.Windows.Forms.Label();
            this.TxMaxEnergia = new System.Windows.Forms.TextBox();
            this.LbMaxEnergia = new System.Windows.Forms.Label();
            this.TxMinMana = new System.Windows.Forms.TextBox();
            this.LbMinMana = new System.Windows.Forms.Label();
            this.TxMaxMana = new System.Windows.Forms.TextBox();
            this.LbMaxMana = new System.Windows.Forms.Label();
            this.GbTemporales = new System.Windows.Forms.GroupBox();
            this.TxCongelar = new System.Windows.Forms.TextBox();
            this.LbCongelar = new System.Windows.Forms.Label();
            this.TxInmovilizar = new System.Windows.Forms.TextBox();
            this.LbInmovilizar = new System.Windows.Forms.Label();
            this.TxParalizar = new System.Windows.Forms.TextBox();
            this.LbParalizar = new System.Windows.Forms.Label();
            this.GbAtaque = new System.Windows.Forms.GroupBox();
            this.CbEnvenar = new System.Windows.Forms.CheckBox();
            this.TxMinDaño = new System.Windows.Forms.TextBox();
            this.LbMinDaño = new System.Windows.Forms.Label();
            this.TxMaxDaño = new System.Windows.Forms.TextBox();
            this.LbMaxDaño = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.GbBase.SuspendLayout();
            this.GbConsum.SuspendLayout();
            this.GbTemporales.SuspendLayout();
            this.GbAtaque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(267, 374);
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.Location = new System.Drawing.Point(390, 374);            
            // 
            // GbBase
            // 
            this.GbBase.Controls.Add(this.TxPalabrasMagicas);
            this.GbBase.Controls.Add(this.LbPalabrasMagicas);
            this.GbBase.Controls.Add(this.TxDescripcion);
            this.GbBase.Controls.Add(this.LbDescripcion);
            this.GbBase.Controls.Add(this.CbSonido);
            this.GbBase.Controls.Add(this.LbSonido);
            this.GbBase.Controls.Add(this.CbEfecto);
            this.GbBase.Controls.Add(this.LbEfecto);
            this.GbBase.Controls.Add(this.CbImagen);
            this.GbBase.Controls.Add(this.LbImagen);
            this.GbBase.Controls.Add(this.TxNombre);
            this.GbBase.Controls.Add(this.LbNombre);
            this.GbBase.Controls.Add(this.LbTipo);
            this.GbBase.Controls.Add(this.CbTipo);
            this.GbBase.Location = new System.Drawing.Point(28, 31);
            this.GbBase.Name = "GbBase";
            this.GbBase.Size = new System.Drawing.Size(223, 230);
            this.GbBase.TabIndex = 48;
            this.GbBase.TabStop = false;
            this.GbBase.Text = "Base";
            // 
            // TxPalabrasMagicas
            // 
            this.TxPalabrasMagicas.Location = new System.Drawing.Point(110, 195);
            this.TxPalabrasMagicas.Name = "TxPalabrasMagicas";
            this.TxPalabrasMagicas.Size = new System.Drawing.Size(100, 23);
            this.TxPalabrasMagicas.TabIndex = 13;
            // 
            // LbPalabrasMagicas
            // 
            this.LbPalabrasMagicas.AutoSize = true;
            this.LbPalabrasMagicas.Location = new System.Drawing.Point(6, 198);
            this.LbPalabrasMagicas.Name = "LbPalabrasMagicas";
            this.LbPalabrasMagicas.Size = new System.Drawing.Size(98, 15);
            this.LbPalabrasMagicas.TabIndex = 12;
            this.LbPalabrasMagicas.Text = "Palabras Mágicas";
            // 
            // TxDescripcion
            // 
            this.TxDescripcion.Location = new System.Drawing.Point(110, 166);
            this.TxDescripcion.Name = "TxDescripcion";
            this.TxDescripcion.Size = new System.Drawing.Size(100, 23);
            this.TxDescripcion.TabIndex = 11;
            // 
            // LbDescripcion
            // 
            this.LbDescripcion.AutoSize = true;
            this.LbDescripcion.Location = new System.Drawing.Point(6, 169);
            this.LbDescripcion.Name = "LbDescripcion";
            this.LbDescripcion.Size = new System.Drawing.Size(69, 15);
            this.LbDescripcion.TabIndex = 10;
            this.LbDescripcion.Text = "Descripción";
            // 
            // CbSonido
            // 
            this.CbSonido.FormattingEnabled = true;
            this.CbSonido.Location = new System.Drawing.Point(110, 137);
            this.CbSonido.Name = "CbSonido";
            this.CbSonido.Size = new System.Drawing.Size(100, 23);
            this.CbSonido.TabIndex = 9;
            // 
            // LbSonido
            // 
            this.LbSonido.AutoSize = true;
            this.LbSonido.Location = new System.Drawing.Point(6, 140);
            this.LbSonido.Name = "LbSonido";
            this.LbSonido.Size = new System.Drawing.Size(44, 15);
            this.LbSonido.TabIndex = 8;
            this.LbSonido.Text = "Sonido";
            // 
            // CbEfecto
            // 
            this.CbEfecto.FormattingEnabled = true;
            this.CbEfecto.Location = new System.Drawing.Point(110, 108);
            this.CbEfecto.Name = "CbEfecto";
            this.CbEfecto.Size = new System.Drawing.Size(100, 23);
            this.CbEfecto.TabIndex = 7;
            // 
            // LbEfecto
            // 
            this.LbEfecto.AutoSize = true;
            this.LbEfecto.Location = new System.Drawing.Point(6, 111);
            this.LbEfecto.Name = "LbEfecto";
            this.LbEfecto.Size = new System.Drawing.Size(40, 15);
            this.LbEfecto.TabIndex = 6;
            this.LbEfecto.Text = "Efecto";
            // 
            // CbImagen
            // 
            this.CbImagen.FormattingEnabled = true;
            this.CbImagen.Location = new System.Drawing.Point(110, 79);
            this.CbImagen.Name = "CbImagen";
            this.CbImagen.Size = new System.Drawing.Size(100, 23);
            this.CbImagen.TabIndex = 5;
            // 
            // LbImagen
            // 
            this.LbImagen.AutoSize = true;
            this.LbImagen.Location = new System.Drawing.Point(6, 82);
            this.LbImagen.Name = "LbImagen";
            this.LbImagen.Size = new System.Drawing.Size(47, 15);
            this.LbImagen.TabIndex = 4;
            this.LbImagen.Text = "Imagen";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(110, 50);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(100, 23);
            this.TxNombre.TabIndex = 3;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(6, 53);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(51, 15);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "Nombre";
            // 
            // LbTipo
            // 
            this.LbTipo.AutoSize = true;
            this.LbTipo.Location = new System.Drawing.Point(6, 24);
            this.LbTipo.Name = "LbTipo";
            this.LbTipo.Size = new System.Drawing.Size(30, 15);
            this.LbTipo.TabIndex = 1;
            this.LbTipo.Text = "Tipo";
            // 
            // CbTipo
            // 
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(110, 21);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(100, 23);
            this.CbTipo.TabIndex = 0;
            // 
            // GbConsum
            // 
            this.GbConsum.Controls.Add(this.TxMinEnergia);
            this.GbConsum.Controls.Add(this.LbMinEnergia);
            this.GbConsum.Controls.Add(this.TxMaxEnergia);
            this.GbConsum.Controls.Add(this.LbMaxEnergia);
            this.GbConsum.Controls.Add(this.TxMinMana);
            this.GbConsum.Controls.Add(this.LbMinMana);
            this.GbConsum.Controls.Add(this.TxMaxMana);
            this.GbConsum.Controls.Add(this.LbMaxMana);
            this.GbConsum.Location = new System.Drawing.Point(267, 31);
            this.GbConsum.Name = "GbConsum";
            this.GbConsum.Size = new System.Drawing.Size(198, 160);
            this.GbConsum.TabIndex = 49;
            this.GbConsum.TabStop = false;
            this.GbConsum.Text = "Consumo";
            // 
            // TxMinEnergia
            // 
            this.TxMinEnergia.Location = new System.Drawing.Point(87, 108);
            this.TxMinEnergia.Name = "TxMinEnergia";
            this.TxMinEnergia.Size = new System.Drawing.Size(100, 23);
            this.TxMinEnergia.TabIndex = 11;
            // 
            // LbMinEnergia
            // 
            this.LbMinEnergia.AutoSize = true;
            this.LbMinEnergia.Location = new System.Drawing.Point(6, 111);
            this.LbMinEnergia.Name = "LbMinEnergia";
            this.LbMinEnergia.Size = new System.Drawing.Size(73, 15);
            this.LbMinEnergia.TabIndex = 10;
            this.LbMinEnergia.Text = "Min. Energía";
            // 
            // TxMaxEnergia
            // 
            this.TxMaxEnergia.Location = new System.Drawing.Point(87, 79);
            this.TxMaxEnergia.Name = "TxMaxEnergia";
            this.TxMaxEnergia.Size = new System.Drawing.Size(100, 23);
            this.TxMaxEnergia.TabIndex = 9;
            // 
            // LbMaxEnergia
            // 
            this.LbMaxEnergia.AutoSize = true;
            this.LbMaxEnergia.Location = new System.Drawing.Point(6, 82);
            this.LbMaxEnergia.Name = "LbMaxEnergia";
            this.LbMaxEnergia.Size = new System.Drawing.Size(75, 15);
            this.LbMaxEnergia.TabIndex = 8;
            this.LbMaxEnergia.Text = "Max. Energía";
            // 
            // TxMinMana
            // 
            this.TxMinMana.Location = new System.Drawing.Point(87, 50);
            this.TxMinMana.Name = "TxMinMana";
            this.TxMinMana.Size = new System.Drawing.Size(100, 23);
            this.TxMinMana.TabIndex = 7;
            // 
            // LbMinMana
            // 
            this.LbMinMana.AutoSize = true;
            this.LbMinMana.Location = new System.Drawing.Point(6, 53);
            this.LbMinMana.Name = "LbMinMana";
            this.LbMinMana.Size = new System.Drawing.Size(64, 15);
            this.LbMinMana.TabIndex = 6;
            this.LbMinMana.Text = "Min. Mana";
            // 
            // TxMaxMana
            // 
            this.TxMaxMana.Location = new System.Drawing.Point(87, 21);
            this.TxMaxMana.Name = "TxMaxMana";
            this.TxMaxMana.Size = new System.Drawing.Size(100, 23);
            this.TxMaxMana.TabIndex = 5;
            // 
            // LbMaxMana
            // 
            this.LbMaxMana.AutoSize = true;
            this.LbMaxMana.Location = new System.Drawing.Point(6, 24);
            this.LbMaxMana.Name = "LbMaxMana";
            this.LbMaxMana.Size = new System.Drawing.Size(66, 15);
            this.LbMaxMana.TabIndex = 4;
            this.LbMaxMana.Text = "Max. Mana";
            // 
            // GbTemporales
            // 
            this.GbTemporales.Controls.Add(this.TxCongelar);
            this.GbTemporales.Controls.Add(this.LbCongelar);
            this.GbTemporales.Controls.Add(this.TxInmovilizar);
            this.GbTemporales.Controls.Add(this.LbInmovilizar);
            this.GbTemporales.Controls.Add(this.TxParalizar);
            this.GbTemporales.Controls.Add(this.LbParalizar);
            this.GbTemporales.Location = new System.Drawing.Point(28, 277);
            this.GbTemporales.Name = "GbTemporales";
            this.GbTemporales.Size = new System.Drawing.Size(223, 120);
            this.GbTemporales.TabIndex = 50;
            this.GbTemporales.TabStop = false;
            this.GbTemporales.Text = "Temporales";
            // 
            // TxCongelar
            // 
            this.TxCongelar.Location = new System.Drawing.Point(83, 84);
            this.TxCongelar.Name = "TxCongelar";
            this.TxCongelar.Size = new System.Drawing.Size(100, 23);
            this.TxCongelar.TabIndex = 15;
            // 
            // LbCongelar
            // 
            this.LbCongelar.AutoSize = true;
            this.LbCongelar.Location = new System.Drawing.Point(2, 87);
            this.LbCongelar.Name = "LbCongelar";
            this.LbCongelar.Size = new System.Drawing.Size(55, 15);
            this.LbCongelar.TabIndex = 14;
            this.LbCongelar.Text = "Congelar";
            // 
            // TxInmovilizar
            // 
            this.TxInmovilizar.Location = new System.Drawing.Point(83, 55);
            this.TxInmovilizar.Name = "TxInmovilizar";
            this.TxInmovilizar.Size = new System.Drawing.Size(100, 23);
            this.TxInmovilizar.TabIndex = 13;
            // 
            // LbInmovilizar
            // 
            this.LbInmovilizar.AutoSize = true;
            this.LbInmovilizar.Location = new System.Drawing.Point(2, 58);
            this.LbInmovilizar.Name = "LbInmovilizar";
            this.LbInmovilizar.Size = new System.Drawing.Size(65, 15);
            this.LbInmovilizar.TabIndex = 12;
            this.LbInmovilizar.Text = "Inmovilizar";
            // 
            // TxParalizar
            // 
            this.TxParalizar.Location = new System.Drawing.Point(83, 26);
            this.TxParalizar.Name = "TxParalizar";
            this.TxParalizar.Size = new System.Drawing.Size(100, 23);
            this.TxParalizar.TabIndex = 11;
            // 
            // LbParalizar
            // 
            this.LbParalizar.AutoSize = true;
            this.LbParalizar.Location = new System.Drawing.Point(2, 29);
            this.LbParalizar.Name = "LbParalizar";
            this.LbParalizar.Size = new System.Drawing.Size(51, 15);
            this.LbParalizar.TabIndex = 10;
            this.LbParalizar.Text = "Paralizar";
            // 
            // GbAtaque
            // 
            this.GbAtaque.Controls.Add(this.CbEnvenar);
            this.GbAtaque.Controls.Add(this.TxMinDaño);
            this.GbAtaque.Controls.Add(this.LbMinDaño);
            this.GbAtaque.Controls.Add(this.TxMaxDaño);
            this.GbAtaque.Controls.Add(this.LbMaxDaño);
            this.GbAtaque.Location = new System.Drawing.Point(267, 226);
            this.GbAtaque.Name = "GbAtaque";
            this.GbAtaque.Size = new System.Drawing.Size(198, 129);
            this.GbAtaque.TabIndex = 51;
            this.GbAtaque.TabStop = false;
            this.GbAtaque.Text = "Ataque";
            // 
            // CbEnvenar
            // 
            this.CbEnvenar.AutoSize = true;
            this.CbEnvenar.Location = new System.Drawing.Point(106, 84);
            this.CbEnvenar.Name = "CbEnvenar";
            this.CbEnvenar.Size = new System.Drawing.Size(81, 19);
            this.CbEnvenar.TabIndex = 20;
            this.CbEnvenar.Text = "Envenenar";
            this.CbEnvenar.UseVisualStyleBackColor = true;
            // 
            // TxMinDaño
            // 
            this.TxMinDaño.Location = new System.Drawing.Point(87, 55);
            this.TxMinDaño.Name = "TxMinDaño";
            this.TxMinDaño.Size = new System.Drawing.Size(100, 23);
            this.TxMinDaño.TabIndex = 19;
            // 
            // LbMinDaño
            // 
            this.LbMinDaño.AutoSize = true;
            this.LbMinDaño.Location = new System.Drawing.Point(6, 58);
            this.LbMinDaño.Name = "LbMinDaño";
            this.LbMinDaño.Size = new System.Drawing.Size(62, 15);
            this.LbMinDaño.TabIndex = 18;
            this.LbMinDaño.Text = "Min. Daño";
            // 
            // TxMaxDaño
            // 
            this.TxMaxDaño.Location = new System.Drawing.Point(87, 26);
            this.TxMaxDaño.Name = "TxMaxDaño";
            this.TxMaxDaño.Size = new System.Drawing.Size(100, 23);
            this.TxMaxDaño.TabIndex = 17;
            // 
            // LbMaxDaño
            // 
            this.LbMaxDaño.AutoSize = true;
            this.LbMaxDaño.Location = new System.Drawing.Point(6, 29);
            this.LbMaxDaño.Name = "LbMaxDaño";
            this.LbMaxDaño.Size = new System.Drawing.Size(64, 15);
            this.LbMaxDaño.TabIndex = 16;
            this.LbMaxDaño.Text = "Max. Daño";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 419);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripcion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sonido";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(102, 129);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Efecto";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(100, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Imagen";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(102, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 0;
            // 
            // FormularioHechizo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 410);
            this.Controls.Add(this.GbAtaque);
            this.Controls.Add(this.GbTemporales);
            this.Controls.Add(this.GbConsum);
            this.Controls.Add(this.GbBase);
            this.Name = "FormularioHechizo";
            this.Text = "Nuevo / Editar";
            this.Controls.SetChildIndex(this.GbBase, 0);
            this.Controls.SetChildIndex(this.GbConsum, 0);
            this.Controls.SetChildIndex(this.GbTemporales, 0);
            this.Controls.SetChildIndex(this.GbAtaque, 0);
            this.Controls.SetChildIndex(this.BtCancelar, 0);
            this.Controls.SetChildIndex(this.BtGuardar, 0);
            this.GbBase.ResumeLayout(false);
            this.GbBase.PerformLayout();
            this.GbConsum.ResumeLayout(false);
            this.GbConsum.PerformLayout();
            this.GbTemporales.ResumeLayout(false);
            this.GbTemporales.PerformLayout();
            this.GbAtaque.ResumeLayout(false);
            this.GbAtaque.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbBase;
        private System.Windows.Forms.GroupBox GbConsum;
        private System.Windows.Forms.GroupBox GbTemporales;
        private System.Windows.Forms.GroupBox GbAtaque;
        private System.Windows.Forms.Label LbImagen;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbTipo;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.TextBox TxPalabrasMagicas;
        private System.Windows.Forms.Label LbPalabrasMagicas;
        private System.Windows.Forms.TextBox TxDescripcion;
        private System.Windows.Forms.Label LbDescripcion;
        private System.Windows.Forms.ComboBox CbSonido;
        private System.Windows.Forms.Label LbSonido;
        private System.Windows.Forms.ComboBox CbEfecto;
        private System.Windows.Forms.Label LbEfecto;
        private System.Windows.Forms.ComboBox CbImagen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox TxMinEnergia;
        private System.Windows.Forms.Label LbMinEnergia;
        private System.Windows.Forms.TextBox TxMaxEnergia;
        private System.Windows.Forms.Label LbMaxEnergia;
        private System.Windows.Forms.TextBox TxMinMana;
        private System.Windows.Forms.Label LbMinMana;
        private System.Windows.Forms.TextBox TxMaxMana;
        private System.Windows.Forms.Label LbMaxMana;
        private System.Windows.Forms.TextBox TxInmovilizar;
        private System.Windows.Forms.Label LbInmovilizar;
        private System.Windows.Forms.TextBox TxParalizar;
        private System.Windows.Forms.Label LbParalizar;
        private System.Windows.Forms.TextBox TxCongelar;
        private System.Windows.Forms.Label LbCongelar;
        private System.Windows.Forms.CheckBox CbEnvenar;
        private System.Windows.Forms.TextBox TxMinDaño;
        private System.Windows.Forms.Label LbMinDaño;
        private System.Windows.Forms.TextBox TxMaxDaño;
        private System.Windows.Forms.Label LbMaxDaño;
    }
}