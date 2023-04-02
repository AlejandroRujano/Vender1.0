namespace Vender
{
    public partial class Form1 : Form
    {
        private int n = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregamos nueva fila
            int n = dtgvVender.Rows.Add();

            //Agregamos Informacion
            dtgvVender.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvVender.Rows[n].Cells[1].Value = txtDescripcion.Text;
            dtgvVender.Rows[n].Cells[2].Value = txtCantidad.Text;
            dtgvVender.Rows[n].Cells[3].Value = txtPrecio.Text;

            //Limpia los cuadros
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

    
        private void dtgvVender_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvVender.Rows.RemoveAt(n);
            }
        }
    }   
}