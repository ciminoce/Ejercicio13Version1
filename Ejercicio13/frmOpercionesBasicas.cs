namespace Ejercicio13
{
    public partial class frmOpercionesBasicas : Form
    {
        public frmOpercionesBasicas()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            var resultado = 0;
            if (ValidarDatos())
            {
                var numero1 = int.Parse(txtNumero1.Text);
                var numero2 = int.Parse(txtNumero2.Text);
                if (rbtSuma.Checked)
                {
                    resultado = CalcularSuma(numero1, numero2);
                }
                else if (rbtResta.Checked)
                {
                    resultado = CalcularResta(numero1, numero2);
                }
                else if (rbtProducto.Checked)
                {
                    resultado = CalcularProducto(numero1, numero2);

                }
                else
                {
                    resultado = CalcularDivision(numero1, numero2);
                }
                MessageBox.Show($"El resultado es {resultado}", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();

            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtNumero1.Text, out int numero1))
            {
                valido = false;
                errorProvider1.SetError(txtNumero1, "Número no válido");
            }
            if (!int.TryParse(txtNumero2.Text, out int numero2))
            {
                valido = false;
                errorProvider1.SetError(txtNumero2, "Número no válido");
            }
            return valido;
        }

        private int CalcularDivision(int numero1, int numero2) => numero1 / numero2;


        private int CalcularProducto(int numero1, int numero2) => numero1 * numero2;

        private int CalcularResta(int numero1, int numero2) => numero1 - numero2;


        private int CalcularSuma(int numero1, int numero2) => numero1 + numero2;


        private static bool ValidarOpcion(int opcion) => opcion >= 1 && opcion <= 4;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            rbtSuma.Checked = true;
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salida del Programa");
            Application.Exit();
        }
    }
}
