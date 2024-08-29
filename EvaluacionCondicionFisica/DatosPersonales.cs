using DatosPersona;
using System.Reflection.Metadata.Ecma335;

namespace EvaluacionCondicionFisica
{
    public partial class DatosPersonales : Form
    {
        public ToolTipIcon ToolTipIcon { get; private set; }

        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {

        }

        private void btnPasaFormulario_Click(object sender, EventArgs e)
        {
            var form = new PruebasFisicas();
            form.Show();
            Hide();
        }

        private void EPStxt_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            {
                ToolTipIcon = ToolTipIcon.Info;
            }
            t.SetToolTip(this.EPStxt, "Escriba el nombre de su EPS");
        }

        private void NumeroDocumentotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 37) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros");
                e.Handled = true;
                return;
            }

        }

        private void PrmierNombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
                return;
            }


        }

        private void SegundoNombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
                return;
            }
        }

        private void PriemerApellidotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriemerApellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
                return;
            }
        }

        private void SegundoApellidotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SegundoApellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
                return;
            }
        }

        private void DepartamentoResidenciatxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MunicipioResidenciatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MunicipioResidenciatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
                return;
            }
        }

        private void PrmierNombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generobox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Generobox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
