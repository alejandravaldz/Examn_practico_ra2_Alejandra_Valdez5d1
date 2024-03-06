namespace Examn_practico_ra2_Alejandra_Valdez5d1
{
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();

        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            string nombre, maestroTitular, direccion, email;
            double telefono, matricula;

            matricula = Double.Parse(txt_Matricula.Text);
            telefono = Double.Parse(txt_Telefono.Text);
            nombre = txt_Nombre.Text;
            maestroTitular = txt_Maestro_Titular.Text;
            direccion = txt_Dirección.Text;
            email = txt_Email.Text;

            string genero;

            if (rbo_Maculino.Checked)
            {
                genero = "Maculino";
            }
            else
            {
                genero = "Femenino";
            }

            {
                dgv_Datos.Rows.Add(txt_Matricula.Text, txt_Nombre.Text, genero, txt_Dirección.Text, txt_Telefono.Text, txt_Email.Text, txt_Maestro_Titular.Text, cbo_Area_tecnica.Text, cbo_Curso.Text, cbo_Sección.Text);


            }
            txt_Telefono.Clear();
            txt_Email.Clear();
            txt_Dirección.Clear();
            txt_Maestro_Titular.Clear();
            txt_Nombre.Clear();
            txt_Matricula.Clear();
            txt_Maestro_Titular.Clear();
            cbo_Area_tecnica.Items.Clear();
            cbo_Curso.Items.Clear();
            cbo_Sección.Items.Clear();


            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton)
                {
                    rbo_Maculino.Checked = false;
                    rbo_Femenino.Checked = false;
                }
            }
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {


            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Agregar.Enabled = false;
            btn_Salir.Enabled = true;


        }




        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Guardar.Enabled = true;

            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = true;
            btn_Agregar.Enabled = true;
            btn_Nuevo.Enabled = true;

            if (dlg_Guardar.ShowDialog() == DialogResult.OK)
            {

                DialogResult resultado = dlg_Guardar.ShowDialog();

                // Verificarción si el usuario presionó el botón Guardar
                if (resultado == DialogResult.OK)
                {

                    string ruta_archivo = dlg_Guardar.FileName;
                    string crea_texto = ruta_archivo;
                    using (StreamWriter archivo = File.CreateText(ruta_archivo))
                    {
                        archivo.WriteLine(txt_Matricula.Text); archivo.WriteLine(txt_Nombre.Text); archivo.WriteLine(cbo_Area_tecnica.Text); archivo.WriteLine(cbo_Curso.Text); archivo.WriteLine(cbo_Sección.Text);
                        foreach (DataGridViewRow fila in dgv_Datos.Rows)
                        {
                            // valores de las celdas 
                            string valorColumna1 = fila.Cells[0].Value?.ToString() ?? "";
                            string valorColumna2 = fila.Cells[1].Value?.ToString() ?? "";
                            string valorColumna3 = fila.Cells[5].Value?.ToString() ?? "";
                            string valorColumna4 = fila.Cells[6].Value?.ToString() ?? "";
                            string valorColumna5 = fila.Cells[7].Value?.ToString() ?? "";

                            // valores en el archivo de texto
                            archivo.WriteLine($"{valorColumna1}, {valorColumna2}, {valorColumna3},{valorColumna4},{valorColumna5}");

                        }

                    }

                }
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int fila;
            fila = dgv_Datos.CurrentRow.Index;

            DialogResult Respuesta = default;
            DialogResult = Respuesta;

            Respuesta = MessageBox.Show("¿Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {

                dgv_Datos.Rows.RemoveAt(fila);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }




}

