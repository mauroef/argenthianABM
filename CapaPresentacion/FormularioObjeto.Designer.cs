
namespace CapaPresentacion
{
    partial class FormularioObjeto
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
            this.LbNombre = new System.Windows.Forms.Label();
            this.TxNombre = new System.Windows.Forms.TextBox();
            this.TxPrecio = new System.Windows.Forms.TextBox();
            this.LbPrecio = new System.Windows.Forms.Label();
            this.LbTipo = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            this.CbSonido = new System.Windows.Forms.ComboBox();
            this.LbSonido = new System.Windows.Forms.Label();
            this.CbImagen = new System.Windows.Forms.ComboBox();
            this.LbImagen = new System.Windows.Forms.Label();
            this.CbModelo3d = new System.Windows.Forms.ComboBox();
            this.LbModelo = new System.Windows.Forms.Label();
            this.CbHechizo = new System.Windows.Forms.ComboBox();
            this.LbHechizo = new System.Windows.Forms.Label();
            this.LbDanio = new System.Windows.Forms.Label();
            this.TxMinDanio = new System.Windows.Forms.TextBox();
            this.TxMaxDanio = new System.Windows.Forms.TextBox();
            this.TxMaxDanioMagico = new System.Windows.Forms.TextBox();
            this.LbDanioMagico = new System.Windows.Forms.Label();
            this.TxMinDanioMagico = new System.Windows.Forms.TextBox();
            this.TxMaxDefensaCasco = new System.Windows.Forms.TextBox();
            this.LbDefensaCasco = new System.Windows.Forms.Label();
            this.TxMinDefensaCasco = new System.Windows.Forms.TextBox();
            this.TxMaxDefensaCuerpo = new System.Windows.Forms.TextBox();
            this.LbDefensaCuerpo = new System.Windows.Forms.Label();
            this.TxMinDefensaCuerpo = new System.Windows.Forms.TextBox();
            this.TxMaxDefensaMagica = new System.Windows.Forms.TextBox();
            this.LbDefensaMagica = new System.Windows.Forms.Label();
            this.TxMinDefensaMagica = new System.Windows.Forms.TextBox();
            this.LbSalud = new System.Windows.Forms.Label();
            this.TxSalud = new System.Windows.Forms.TextBox();
            this.LbMana = new System.Windows.Forms.Label();
            this.TxMana = new System.Windows.Forms.TextBox();
            this.LbHambre = new System.Windows.Forms.Label();
            this.TxHambre = new System.Windows.Forms.TextBox();
            this.LbSed = new System.Windows.Forms.Label();
            this.TxSed = new System.Windows.Forms.TextBox();
            this.LbFuerza = new System.Windows.Forms.Label();
            this.TxFuerza = new System.Windows.Forms.TextBox();
            this.LbAgilidad = new System.Windows.Forms.Label();
            this.TxAgilidad = new System.Windows.Forms.TextBox();
            this.LbPeso = new System.Windows.Forms.Label();
            this.TxPeso = new System.Windows.Forms.TextBox();
            this.BtGuardarEquipo = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.GbBase = new System.Windows.Forms.GroupBox();
            this.GbEstadisticas = new System.Windows.Forms.GroupBox();
            this.GbEquipo = new System.Windows.Forms.GroupBox();
            this.LbxClasesNo = new System.Windows.Forms.ListBox();
            this.GbClasesNo = new System.Windows.Forms.GroupBox();
            this.GbBase.SuspendLayout();
            this.GbEstadisticas.SuspendLayout();
            this.GbEquipo.SuspendLayout();
            this.GbClasesNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(6, 29);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(51, 15);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nombre";
            // 
            // TxNombre
            // 
            this.TxNombre.Location = new System.Drawing.Point(63, 25);
            this.TxNombre.Name = "TxNombre";
            this.TxNombre.Size = new System.Drawing.Size(100, 23);
            this.TxNombre.TabIndex = 1;
            // 
            // TxPrecio
            // 
            this.TxPrecio.Location = new System.Drawing.Point(63, 54);
            this.TxPrecio.Name = "TxPrecio";
            this.TxPrecio.Size = new System.Drawing.Size(100, 23);
            this.TxPrecio.TabIndex = 3;
            this.TxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxPrecio_KeyPress);
            // 
            // LbPrecio
            // 
            this.LbPrecio.AutoSize = true;
            this.LbPrecio.Location = new System.Drawing.Point(6, 58);
            this.LbPrecio.Name = "LbPrecio";
            this.LbPrecio.Size = new System.Drawing.Size(40, 15);
            this.LbPrecio.TabIndex = 2;
            this.LbPrecio.Text = "Precio";
            // 
            // LbTipo
            // 
            this.LbTipo.AutoSize = true;
            this.LbTipo.Location = new System.Drawing.Point(6, 91);
            this.LbTipo.Name = "LbTipo";
            this.LbTipo.Size = new System.Drawing.Size(30, 15);
            this.LbTipo.TabIndex = 4;
            this.LbTipo.Text = "Tipo";
            // 
            // CbTipo
            // 
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(63, 87);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(121, 23);
            this.CbTipo.TabIndex = 5;
            // 
            // CbSonido
            // 
            this.CbSonido.FormattingEnabled = true;
            this.CbSonido.Location = new System.Drawing.Point(63, 116);
            this.CbSonido.Name = "CbSonido";
            this.CbSonido.Size = new System.Drawing.Size(121, 23);
            this.CbSonido.TabIndex = 7;
            // 
            // LbSonido
            // 
            this.LbSonido.AutoSize = true;
            this.LbSonido.Location = new System.Drawing.Point(6, 120);
            this.LbSonido.Name = "LbSonido";
            this.LbSonido.Size = new System.Drawing.Size(44, 15);
            this.LbSonido.TabIndex = 6;
            this.LbSonido.Text = "Sonido";
            // 
            // CbImagen
            // 
            this.CbImagen.FormattingEnabled = true;
            this.CbImagen.Location = new System.Drawing.Point(63, 144);
            this.CbImagen.Name = "CbImagen";
            this.CbImagen.Size = new System.Drawing.Size(121, 23);
            this.CbImagen.TabIndex = 9;
            // 
            // LbImagen
            // 
            this.LbImagen.AutoSize = true;
            this.LbImagen.Location = new System.Drawing.Point(6, 148);
            this.LbImagen.Name = "LbImagen";
            this.LbImagen.Size = new System.Drawing.Size(47, 15);
            this.LbImagen.TabIndex = 8;
            this.LbImagen.Text = "Imagen";
            // 
            // CbModelo3d
            // 
            this.CbModelo3d.FormattingEnabled = true;
            this.CbModelo3d.Location = new System.Drawing.Point(63, 174);
            this.CbModelo3d.Name = "CbModelo3d";
            this.CbModelo3d.Size = new System.Drawing.Size(121, 23);
            this.CbModelo3d.TabIndex = 11;
            // 
            // LbModelo
            // 
            this.LbModelo.AutoSize = true;
            this.LbModelo.Location = new System.Drawing.Point(6, 178);
            this.LbModelo.Name = "LbModelo";
            this.LbModelo.Size = new System.Drawing.Size(48, 15);
            this.LbModelo.TabIndex = 10;
            this.LbModelo.Text = "Modelo";
            // 
            // CbHechizo
            // 
            this.CbHechizo.FormattingEnabled = true;
            this.CbHechizo.Location = new System.Drawing.Point(63, 203);
            this.CbHechizo.Name = "CbHechizo";
            this.CbHechizo.Size = new System.Drawing.Size(121, 23);
            this.CbHechizo.TabIndex = 13;
            // 
            // LbHechizo
            // 
            this.LbHechizo.AutoSize = true;
            this.LbHechizo.Location = new System.Drawing.Point(6, 207);
            this.LbHechizo.Name = "LbHechizo";
            this.LbHechizo.Size = new System.Drawing.Size(50, 15);
            this.LbHechizo.TabIndex = 12;
            this.LbHechizo.Text = "Hechizo";
            // 
            // LbDanio
            // 
            this.LbDanio.AutoSize = true;
            this.LbDanio.Location = new System.Drawing.Point(6, 28);
            this.LbDanio.Name = "LbDanio";
            this.LbDanio.Size = new System.Drawing.Size(35, 15);
            this.LbDanio.TabIndex = 15;
            this.LbDanio.Text = "Daño";
            // 
            // TxMinDanio
            // 
            this.TxMinDanio.Location = new System.Drawing.Point(82, 22);
            this.TxMinDanio.Name = "TxMinDanio";
            this.TxMinDanio.Size = new System.Drawing.Size(47, 23);
            this.TxMinDanio.TabIndex = 16;
            // 
            // TxMaxDanio
            // 
            this.TxMaxDanio.Location = new System.Drawing.Point(135, 23);
            this.TxMaxDanio.Name = "TxMaxDanio";
            this.TxMaxDanio.Size = new System.Drawing.Size(47, 23);
            this.TxMaxDanio.TabIndex = 17;
            // 
            // TxMaxDanioMagico
            // 
            this.TxMaxDanioMagico.Location = new System.Drawing.Point(135, 52);
            this.TxMaxDanioMagico.Name = "TxMaxDanioMagico";
            this.TxMaxDanioMagico.Size = new System.Drawing.Size(47, 23);
            this.TxMaxDanioMagico.TabIndex = 20;
            // 
            // LbDanioMagico
            // 
            this.LbDanioMagico.AutoSize = true;
            this.LbDanioMagico.Location = new System.Drawing.Point(6, 56);
            this.LbDanioMagico.Name = "LbDanioMagico";
            this.LbDanioMagico.Size = new System.Drawing.Size(65, 15);
            this.LbDanioMagico.TabIndex = 18;
            this.LbDanioMagico.Text = "Daño Mág.";
            // 
            // TxMinDanioMagico
            // 
            this.TxMinDanioMagico.Location = new System.Drawing.Point(82, 52);
            this.TxMinDanioMagico.Name = "TxMinDanioMagico";
            this.TxMinDanioMagico.Size = new System.Drawing.Size(47, 23);
            this.TxMinDanioMagico.TabIndex = 19;
            // 
            // TxMaxDefensaCasco
            // 
            this.TxMaxDefensaCasco.Location = new System.Drawing.Point(135, 81);
            this.TxMaxDefensaCasco.Name = "TxMaxDefensaCasco";
            this.TxMaxDefensaCasco.Size = new System.Drawing.Size(47, 23);
            this.TxMaxDefensaCasco.TabIndex = 23;
            // 
            // LbDefensaCasco
            // 
            this.LbDefensaCasco.AutoSize = true;
            this.LbDefensaCasco.Location = new System.Drawing.Point(6, 85);
            this.LbDefensaCasco.Name = "LbDefensaCasco";
            this.LbDefensaCasco.Size = new System.Drawing.Size(63, 15);
            this.LbDefensaCasco.TabIndex = 21;
            this.LbDefensaCasco.Text = "Def. Casco";
            // 
            // TxMinDefensaCasco
            // 
            this.TxMinDefensaCasco.Location = new System.Drawing.Point(82, 81);
            this.TxMinDefensaCasco.Name = "TxMinDefensaCasco";
            this.TxMinDefensaCasco.Size = new System.Drawing.Size(47, 23);
            this.TxMinDefensaCasco.TabIndex = 22;
            // 
            // TxMaxDefensaCuerpo
            // 
            this.TxMaxDefensaCuerpo.Location = new System.Drawing.Point(135, 110);
            this.TxMaxDefensaCuerpo.Name = "TxMaxDefensaCuerpo";
            this.TxMaxDefensaCuerpo.Size = new System.Drawing.Size(47, 23);
            this.TxMaxDefensaCuerpo.TabIndex = 26;
            // 
            // LbDefensaCuerpo
            // 
            this.LbDefensaCuerpo.AutoSize = true;
            this.LbDefensaCuerpo.Location = new System.Drawing.Point(6, 114);
            this.LbDefensaCuerpo.Name = "LbDefensaCuerpo";
            this.LbDefensaCuerpo.Size = new System.Drawing.Size(70, 15);
            this.LbDefensaCuerpo.TabIndex = 24;
            this.LbDefensaCuerpo.Text = "Def. Cuerpo";
            // 
            // TxMinDefensaCuerpo
            // 
            this.TxMinDefensaCuerpo.Location = new System.Drawing.Point(82, 110);
            this.TxMinDefensaCuerpo.Name = "TxMinDefensaCuerpo";
            this.TxMinDefensaCuerpo.Size = new System.Drawing.Size(47, 23);
            this.TxMinDefensaCuerpo.TabIndex = 25;
            // 
            // TxMaxDefensaMagica
            // 
            this.TxMaxDefensaMagica.Location = new System.Drawing.Point(135, 139);
            this.TxMaxDefensaMagica.Name = "TxMaxDefensaMagica";
            this.TxMaxDefensaMagica.Size = new System.Drawing.Size(47, 23);
            this.TxMaxDefensaMagica.TabIndex = 29;
            // 
            // LbDefensaMagica
            // 
            this.LbDefensaMagica.AutoSize = true;
            this.LbDefensaMagica.Location = new System.Drawing.Point(6, 143);
            this.LbDefensaMagica.Name = "LbDefensaMagica";
            this.LbDefensaMagica.Size = new System.Drawing.Size(70, 15);
            this.LbDefensaMagica.TabIndex = 27;
            this.LbDefensaMagica.Text = "Def. Mágica";
            // 
            // TxMinDefensaMagica
            // 
            this.TxMinDefensaMagica.Location = new System.Drawing.Point(82, 139);
            this.TxMinDefensaMagica.Name = "TxMinDefensaMagica";
            this.TxMinDefensaMagica.Size = new System.Drawing.Size(47, 23);
            this.TxMinDefensaMagica.TabIndex = 28;
            // 
            // LbSalud
            // 
            this.LbSalud.AutoSize = true;
            this.LbSalud.Location = new System.Drawing.Point(6, 29);
            this.LbSalud.Name = "LbSalud";
            this.LbSalud.Size = new System.Drawing.Size(36, 15);
            this.LbSalud.TabIndex = 14;
            this.LbSalud.Text = "Salud";
            // 
            // TxSalud
            // 
            this.TxSalud.Location = new System.Drawing.Point(62, 25);
            this.TxSalud.Name = "TxSalud";
            this.TxSalud.Size = new System.Drawing.Size(100, 23);
            this.TxSalud.TabIndex = 15;
            // 
            // LbMana
            // 
            this.LbMana.AutoSize = true;
            this.LbMana.Location = new System.Drawing.Point(6, 59);
            this.LbMana.Name = "LbMana";
            this.LbMana.Size = new System.Drawing.Size(37, 15);
            this.LbMana.TabIndex = 30;
            this.LbMana.Text = "Mana";
            // 
            // TxMana
            // 
            this.TxMana.Location = new System.Drawing.Point(62, 55);
            this.TxMana.Name = "TxMana";
            this.TxMana.Size = new System.Drawing.Size(100, 23);
            this.TxMana.TabIndex = 31;
            // 
            // LbHambre
            // 
            this.LbHambre.AutoSize = true;
            this.LbHambre.Location = new System.Drawing.Point(6, 87);
            this.LbHambre.Name = "LbHambre";
            this.LbHambre.Size = new System.Drawing.Size(50, 15);
            this.LbHambre.TabIndex = 32;
            this.LbHambre.Text = "Hambre";
            // 
            // TxHambre
            // 
            this.TxHambre.Location = new System.Drawing.Point(62, 83);
            this.TxHambre.Name = "TxHambre";
            this.TxHambre.Size = new System.Drawing.Size(100, 23);
            this.TxHambre.TabIndex = 33;
            // 
            // LbSed
            // 
            this.LbSed.AutoSize = true;
            this.LbSed.Location = new System.Drawing.Point(6, 116);
            this.LbSed.Name = "LbSed";
            this.LbSed.Size = new System.Drawing.Size(26, 15);
            this.LbSed.TabIndex = 34;
            this.LbSed.Text = "Sed";
            // 
            // TxSed
            // 
            this.TxSed.Location = new System.Drawing.Point(62, 112);
            this.TxSed.Name = "TxSed";
            this.TxSed.Size = new System.Drawing.Size(100, 23);
            this.TxSed.TabIndex = 35;
            // 
            // LbFuerza
            // 
            this.LbFuerza.AutoSize = true;
            this.LbFuerza.Location = new System.Drawing.Point(6, 146);
            this.LbFuerza.Name = "LbFuerza";
            this.LbFuerza.Size = new System.Drawing.Size(41, 15);
            this.LbFuerza.TabIndex = 36;
            this.LbFuerza.Text = "Fuerza";
            // 
            // TxFuerza
            // 
            this.TxFuerza.Location = new System.Drawing.Point(62, 142);
            this.TxFuerza.Name = "TxFuerza";
            this.TxFuerza.Size = new System.Drawing.Size(100, 23);
            this.TxFuerza.TabIndex = 37;
            // 
            // LbAgilidad
            // 
            this.LbAgilidad.AutoSize = true;
            this.LbAgilidad.Location = new System.Drawing.Point(6, 174);
            this.LbAgilidad.Name = "LbAgilidad";
            this.LbAgilidad.Size = new System.Drawing.Size(51, 15);
            this.LbAgilidad.TabIndex = 38;
            this.LbAgilidad.Text = "Agilidad";
            // 
            // TxAgilidad
            // 
            this.TxAgilidad.Location = new System.Drawing.Point(62, 170);
            this.TxAgilidad.Name = "TxAgilidad";
            this.TxAgilidad.Size = new System.Drawing.Size(100, 23);
            this.TxAgilidad.TabIndex = 39;
            // 
            // LbPeso
            // 
            this.LbPeso.AutoSize = true;
            this.LbPeso.Location = new System.Drawing.Point(6, 203);
            this.LbPeso.Name = "LbPeso";
            this.LbPeso.Size = new System.Drawing.Size(32, 15);
            this.LbPeso.TabIndex = 40;
            this.LbPeso.Text = "Peso";
            // 
            // TxPeso
            // 
            this.TxPeso.Location = new System.Drawing.Point(62, 199);
            this.TxPeso.Name = "TxPeso";
            this.TxPeso.Size = new System.Drawing.Size(100, 23);
            this.TxPeso.TabIndex = 41;
            // 
            // BtGuardarEquipo
            // 
            this.BtGuardarEquipo.Location = new System.Drawing.Point(325, 411);
            this.BtGuardarEquipo.Name = "BtGuardarEquipo";
            this.BtGuardarEquipo.Size = new System.Drawing.Size(75, 23);
            this.BtGuardarEquipo.TabIndex = 44;
            this.BtGuardarEquipo.Text = "Guardar";
            this.BtGuardarEquipo.UseVisualStyleBackColor = true;
            this.BtGuardarEquipo.Click += new System.EventHandler(this.BtGuardarEquipo_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(225, 411);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 45;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // GbBase
            // 
            this.GbBase.Controls.Add(this.LbNombre);
            this.GbBase.Controls.Add(this.CbHechizo);
            this.GbBase.Controls.Add(this.CbSonido);
            this.GbBase.Controls.Add(this.TxNombre);
            this.GbBase.Controls.Add(this.LbSonido);
            this.GbBase.Controls.Add(this.LbHechizo);
            this.GbBase.Controls.Add(this.LbImagen);
            this.GbBase.Controls.Add(this.LbPrecio);
            this.GbBase.Controls.Add(this.CbTipo);
            this.GbBase.Controls.Add(this.CbModelo3d);
            this.GbBase.Controls.Add(this.CbImagen);
            this.GbBase.Controls.Add(this.TxPrecio);
            this.GbBase.Controls.Add(this.LbTipo);
            this.GbBase.Controls.Add(this.LbModelo);
            this.GbBase.Location = new System.Drawing.Point(12, 12);
            this.GbBase.Name = "GbBase";
            this.GbBase.Size = new System.Drawing.Size(207, 240);
            this.GbBase.TabIndex = 46;
            this.GbBase.TabStop = false;
            this.GbBase.Text = "Base";
            // 
            // GbEstadisticas
            // 
            this.GbEstadisticas.Controls.Add(this.LbSalud);
            this.GbEstadisticas.Controls.Add(this.LbPeso);
            this.GbEstadisticas.Controls.Add(this.LbSed);
            this.GbEstadisticas.Controls.Add(this.TxSalud);
            this.GbEstadisticas.Controls.Add(this.TxSed);
            this.GbEstadisticas.Controls.Add(this.TxPeso);
            this.GbEstadisticas.Controls.Add(this.TxFuerza);
            this.GbEstadisticas.Controls.Add(this.TxMana);
            this.GbEstadisticas.Controls.Add(this.LbHambre);
            this.GbEstadisticas.Controls.Add(this.LbAgilidad);
            this.GbEstadisticas.Controls.Add(this.LbFuerza);
            this.GbEstadisticas.Controls.Add(this.LbMana);
            this.GbEstadisticas.Controls.Add(this.TxHambre);
            this.GbEstadisticas.Controls.Add(this.TxAgilidad);
            this.GbEstadisticas.Location = new System.Drawing.Point(225, 12);
            this.GbEstadisticas.Name = "GbEstadisticas";
            this.GbEstadisticas.Size = new System.Drawing.Size(175, 240);
            this.GbEstadisticas.TabIndex = 47;
            this.GbEstadisticas.TabStop = false;
            this.GbEstadisticas.Text = "Estadísticas";
            // 
            // GbEquipo
            // 
            this.GbEquipo.Controls.Add(this.LbDanio);
            this.GbEquipo.Controls.Add(this.TxMinDanio);
            this.GbEquipo.Controls.Add(this.TxMaxDefensaCasco);
            this.GbEquipo.Controls.Add(this.TxMaxDefensaMagica);
            this.GbEquipo.Controls.Add(this.LbDefensaCasco);
            this.GbEquipo.Controls.Add(this.TxMaxDanio);
            this.GbEquipo.Controls.Add(this.TxMinDefensaCuerpo);
            this.GbEquipo.Controls.Add(this.LbDefensaMagica);
            this.GbEquipo.Controls.Add(this.TxMinDefensaCasco);
            this.GbEquipo.Controls.Add(this.TxMinDanioMagico);
            this.GbEquipo.Controls.Add(this.LbDefensaCuerpo);
            this.GbEquipo.Controls.Add(this.TxMinDefensaMagica);
            this.GbEquipo.Controls.Add(this.TxMaxDanioMagico);
            this.GbEquipo.Controls.Add(this.LbDanioMagico);
            this.GbEquipo.Controls.Add(this.TxMaxDefensaCuerpo);
            this.GbEquipo.Location = new System.Drawing.Point(12, 258);
            this.GbEquipo.Name = "GbEquipo";
            this.GbEquipo.Size = new System.Drawing.Size(207, 176);
            this.GbEquipo.TabIndex = 48;
            this.GbEquipo.TabStop = false;
            this.GbEquipo.Text = "Equipo";
            // 
            // LbxClasesNo
            // 
            this.LbxClasesNo.FormattingEnabled = true;
            this.LbxClasesNo.ItemHeight = 15;
            this.LbxClasesNo.Location = new System.Drawing.Point(6, 23);
            this.LbxClasesNo.Name = "LbxClasesNo";
            this.LbxClasesNo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbxClasesNo.Size = new System.Drawing.Size(156, 109);
            this.LbxClasesNo.TabIndex = 49;
            // 
            // GbClasesNo
            // 
            this.GbClasesNo.Controls.Add(this.LbxClasesNo);
            this.GbClasesNo.Location = new System.Drawing.Point(225, 258);
            this.GbClasesNo.Name = "GbClasesNo";
            this.GbClasesNo.Size = new System.Drawing.Size(175, 147);
            this.GbClasesNo.TabIndex = 50;
            this.GbClasesNo.TabStop = false;
            this.GbClasesNo.Text = "Clases No Permitidas";
            // 
            // FormularioObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 444);
            this.Controls.Add(this.GbClasesNo);
            this.Controls.Add(this.GbEquipo);
            this.Controls.Add(this.GbEstadisticas);
            this.Controls.Add(this.GbBase);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtGuardarEquipo);
            this.Name = "FormularioObjeto";
            this.Text = "Nuevo Objeto";
            this.GbBase.ResumeLayout(false);
            this.GbBase.PerformLayout();
            this.GbEstadisticas.ResumeLayout(false);
            this.GbEstadisticas.PerformLayout();
            this.GbEquipo.ResumeLayout(false);
            this.GbEquipo.PerformLayout();
            this.GbClasesNo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.TextBox TxNombre;
        private System.Windows.Forms.TextBox TxPrecio;
        private System.Windows.Forms.Label LbPrecio;
        private System.Windows.Forms.Label LbTipo;
        private System.Windows.Forms.ComboBox CbTipo;
        private System.Windows.Forms.ComboBox CbSonido;
        private System.Windows.Forms.Label LbSonido;
        private System.Windows.Forms.ComboBox CbImagen;
        private System.Windows.Forms.Label LbImagen;
        private System.Windows.Forms.ComboBox CbModelo3d;
        private System.Windows.Forms.Label LbModelo;
        private System.Windows.Forms.ComboBox CbHechizo;
        private System.Windows.Forms.Label LbHechizo;
        private System.Windows.Forms.Label LbDanio;
        private System.Windows.Forms.TextBox TxMinDanio;
        private System.Windows.Forms.TextBox TxMaxDanio;
        private System.Windows.Forms.TextBox TxMaxDanioMagico;
        private System.Windows.Forms.Label LbDanioMagico;
        private System.Windows.Forms.TextBox TxMinDanioMagico;
        private System.Windows.Forms.TextBox TxMaxDefensaCasco;
        private System.Windows.Forms.Label LbDefensaCasco;
        private System.Windows.Forms.TextBox TxMinDefensaCasco;
        private System.Windows.Forms.TextBox TxMaxDefensaCuerpo;
        private System.Windows.Forms.Label LbDefensaCuerpo;
        private System.Windows.Forms.TextBox TxMinDefensaCuerpo;
        private System.Windows.Forms.TextBox TxMaxDefensaMagica;
        private System.Windows.Forms.Label LbDefensaMagica;
        private System.Windows.Forms.TextBox TxMinDefensaMagica;
        private System.Windows.Forms.Label LbSalud;
        private System.Windows.Forms.TextBox TxSalud;
        private System.Windows.Forms.Label LbMana;
        private System.Windows.Forms.TextBox TxMana;
        private System.Windows.Forms.Label LbHambre;
        private System.Windows.Forms.TextBox TxHambre;
        private System.Windows.Forms.Label LbSed;
        private System.Windows.Forms.TextBox TxSed;
        private System.Windows.Forms.Label LbFuerza;
        private System.Windows.Forms.TextBox TxFuerza;
        private System.Windows.Forms.Label LbAgilidad;
        private System.Windows.Forms.TextBox TxAgilidad;
        private System.Windows.Forms.Label LbPeso;
        private System.Windows.Forms.TextBox TxPeso;
        private System.Windows.Forms.Button BtGuardarEquipo;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.GroupBox GbBase;
        private System.Windows.Forms.GroupBox GbEstadisticas;
        private System.Windows.Forms.GroupBox GbEquipo;
        private System.Windows.Forms.ListBox LbxClasesNo;
        private System.Windows.Forms.GroupBox GbClasesNo;
    }
}