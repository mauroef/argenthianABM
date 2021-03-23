using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }

        #region UI

        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return cp;
            }
        }

        #endregion

        #region Eventos

        public virtual void BtCancelar_Click(object sender, EventArgs e) { }

        public virtual void BtGuardar_Click(object sender, EventArgs e) { }

        #endregion
    }
}
