using CapaAccesoDatos;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace ParcialArq1
{
    public partial class CapaPresentacion : Form
    {
        // Instanciamos la clase de lógica, inyectándole nuestra conexión a SQL
        LogicaCredito logica = new LogicaCredito(new ConexionSQLServer());

        public CapaPresentacion()
        {
            InitializeComponent();
            cbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoDoc.SelectedIndex = 0;
        }

        private void CapaPresentacion_Load(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNroDoc.Text))
                {
                    MessageBox.Show(this, "El número de documento está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear solicitud con los datos ingresados
                SolicitudCredito solicitud = new SolicitudCredito
                {
                    TipoDoc = cbTipoDoc.Text,
                    NroDoc = txtNroDoc.Text,
                    IngresosTotales = decimal.Parse(txtIngresos.Text),
                    EgresosTotales = decimal.Parse(txtEgresos.Text),
                    MontoSolicitado = decimal.Parse(txtMonto.Text),
                    PlazoSolicitado = int.Parse(txtPlazo.Text)
                };
                    
                // Evaluar la solicitud
                string resultado = logica.Evaluar(solicitud);

                if (resultado == "Aprobado")
                {
                    MessageBox.Show(this, "Crédito Aprobado", "Resultado de la Evaluación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, resultado, "Resultado de la Evaluación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Por favor verifique que todos los números sean válidos. Detalles: " + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
