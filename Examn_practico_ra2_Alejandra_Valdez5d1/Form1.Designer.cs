namespace Examn_practico_ra2_Alejandra_Valdez5d1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Nuevo = new Button();
            btn_Guardar = new Button();
            btn_Salir = new Button();
            btn_Agregar = new Button();
            label1 = new Label();
            cbo_Area_tecnica = new ComboBox();
            rbo_Femenino = new RadioButton();
            lbl_Matricula = new Label();
            lbl_Nombre = new Label();
            lbl_Dirección = new Label();
            txt_Matricula = new TextBox();
            txt_Nombre = new TextBox();
            txt_Dirección = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbl_Telefono = new Label();
            lbl_Email = new Label();
            txt_Telefono = new TextBox();
            txt_Email = new TextBox();
            lbl_area_tecnica = new Label();
            lbl_Curso = new Label();
            cbo_Curso = new ComboBox();
            cbo_Sección = new ComboBox();
            lbl_Sección = new Label();
            rbo_Maculino = new RadioButton();
            lbl_Genero = new Label();
            btn_Eliminar = new Button();
            lbl_Maestro = new Label();
            txt_Maestro_Titular = new TextBox();
            dgv_Datos = new DataGridView();
            Matricula = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Maestro_Titular = new DataGridViewTextBoxColumn();
            Area_Tecnica = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            Sección = new DataGridViewTextBoxColumn();
            dlg_Guardar = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgv_Datos).BeginInit();
            SuspendLayout();
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.BackColor = Color.Moccasin;
            btn_Nuevo.Font = new Font("Century", 10.2F);
            btn_Nuevo.Location = new Point(1211, 93);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(115, 42);
            btn_Nuevo.TabIndex = 0;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.UseVisualStyleBackColor = false;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.Moccasin;
            btn_Guardar.Font = new Font("Century", 10.2F);
            btn_Guardar.Location = new Point(1211, 286);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(115, 42);
            btn_Guardar.TabIndex = 1;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Moccasin;
            btn_Salir.Font = new Font("Century", 10.2F);
            btn_Salir.Location = new Point(1211, 376);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(115, 42);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.Moccasin;
            btn_Agregar.Font = new Font("Century", 10.2F);
            btn_Agregar.Location = new Point(1211, 191);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(115, 42);
            btn_Agregar.TabIndex = 3;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(452, 9);
            label1.Name = "label1";
            label1.Size = new Size(554, 60);
            label1.TabIndex = 4;
            label1.Text = "Datos del estudiante";
            // 
            // cbo_Area_tecnica
            // 
            cbo_Area_tecnica.FormattingEnabled = true;
            cbo_Area_tecnica.Items.AddRange(new object[] { "Informatica ", "Gastronomia", "Enfermeria", "Contabilidad", "Eletricidad ", "" });
            cbo_Area_tecnica.Location = new Point(635, 414);
            cbo_Area_tecnica.Name = "cbo_Area_tecnica";
            cbo_Area_tecnica.Size = new Size(151, 28);
            cbo_Area_tecnica.TabIndex = 14;
            // 
            // rbo_Femenino
            // 
            rbo_Femenino.AutoSize = true;
            rbo_Femenino.BackColor = Color.Transparent;
            rbo_Femenino.Location = new Point(597, 518);
            rbo_Femenino.Name = "rbo_Femenino";
            rbo_Femenino.Size = new Size(95, 24);
            rbo_Femenino.TabIndex = 15;
            rbo_Femenino.TabStop = true;
            rbo_Femenino.Text = "Femenino";
            rbo_Femenino.UseVisualStyleBackColor = false;
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.AutoSize = true;
            lbl_Matricula.BackColor = Color.Transparent;
            lbl_Matricula.Font = new Font("Century", 10.8F);
            lbl_Matricula.Location = new Point(332, 139);
            lbl_Matricula.Name = "lbl_Matricula";
            lbl_Matricula.Size = new Size(93, 22);
            lbl_Matricula.TabIndex = 16;
            lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.Transparent;
            lbl_Nombre.Font = new Font("Century", 10.8F);
            lbl_Nombre.Location = new Point(332, 207);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(77, 22);
            lbl_Nombre.TabIndex = 17;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Dirección
            // 
            lbl_Dirección.AutoSize = true;
            lbl_Dirección.BackColor = Color.Transparent;
            lbl_Dirección.Font = new Font("Century", 10.8F);
            lbl_Dirección.Location = new Point(331, 276);
            lbl_Dirección.Name = "lbl_Dirección";
            lbl_Dirección.Size = new Size(89, 22);
            lbl_Dirección.TabIndex = 18;
            lbl_Dirección.Text = "Dirección";
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(427, 139);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(164, 27);
            txt_Matricula.TabIndex = 19;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(427, 207);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(139, 27);
            txt_Nombre.TabIndex = 20;
            // 
            // txt_Dirección
            // 
            txt_Dirección.Location = new Point(423, 273);
            txt_Dirección.Name = "txt_Dirección";
            txt_Dirección.Size = new Size(168, 27);
            txt_Dirección.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 251);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 300);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 23;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.BackColor = Color.Transparent;
            lbl_Telefono.Font = new Font("Century", 10.8F);
            lbl_Telefono.Location = new Point(765, 146);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(81, 22);
            lbl_Telefono.TabIndex = 24;
            lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.Transparent;
            lbl_Email.Font = new Font("Century", 10.8F);
            lbl_Email.Location = new Point(765, 215);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(61, 22);
            lbl_Email.TabIndex = 25;
            lbl_Email.Text = "Email";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(852, 138);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(162, 27);
            txt_Telefono.TabIndex = 27;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(852, 215);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(183, 27);
            txt_Email.TabIndex = 28;
            // 
            // lbl_area_tecnica
            // 
            lbl_area_tecnica.AutoSize = true;
            lbl_area_tecnica.BackColor = Color.Transparent;
            lbl_area_tecnica.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_area_tecnica.Location = new Point(657, 376);
            lbl_area_tecnica.Name = "lbl_area_tecnica";
            lbl_area_tecnica.Size = new Size(113, 21);
            lbl_area_tecnica.TabIndex = 29;
            lbl_area_tecnica.Text = "Area Tecnica";
            // 
            // lbl_Curso
            // 
            lbl_Curso.AutoSize = true;
            lbl_Curso.BackColor = Color.Transparent;
            lbl_Curso.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Curso.Location = new Point(415, 442);
            lbl_Curso.Name = "lbl_Curso";
            lbl_Curso.Size = new Size(54, 23);
            lbl_Curso.TabIndex = 30;
            lbl_Curso.Text = "Curso";
            // 
            // cbo_Curso
            // 
            cbo_Curso.FormattingEnabled = true;
            cbo_Curso.Items.AddRange(new object[] { "4to", "5to", "6to" });
            cbo_Curso.Location = new Point(364, 480);
            cbo_Curso.Name = "cbo_Curso";
            cbo_Curso.Size = new Size(151, 28);
            cbo_Curso.TabIndex = 31;
            // 
            // cbo_Sección
            // 
            cbo_Sección.FormattingEnabled = true;
            cbo_Sección.Items.AddRange(new object[] { "D1", "D2", "C1", "C2", "A1", "A2", "A3", "A4", "E1", "E2", "B1", "B2" });
            cbo_Sección.Location = new Point(928, 480);
            cbo_Sección.Name = "cbo_Sección";
            cbo_Sección.Size = new Size(151, 28);
            cbo_Sección.TabIndex = 32;
            // 
            // lbl_Sección
            // 
            lbl_Sección.AutoSize = true;
            lbl_Sección.BackColor = Color.Transparent;
            lbl_Sección.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Sección.Location = new Point(961, 444);
            lbl_Sección.Name = "lbl_Sección";
            lbl_Sección.Size = new Size(68, 23);
            lbl_Sección.TabIndex = 33;
            lbl_Sección.Text = "Sección";
            // 
            // rbo_Maculino
            // 
            rbo_Maculino.AutoSize = true;
            rbo_Maculino.BackColor = Color.Transparent;
            rbo_Maculino.Location = new Point(731, 518);
            rbo_Maculino.Name = "rbo_Maculino";
            rbo_Maculino.Size = new Size(97, 24);
            rbo_Maculino.TabIndex = 34;
            rbo_Maculino.TabStop = true;
            rbo_Maculino.Text = "Masculino";
            rbo_Maculino.UseVisualStyleBackColor = false;
            // 
            // lbl_Genero
            // 
            lbl_Genero.AutoSize = true;
            lbl_Genero.BackColor = Color.Transparent;
            lbl_Genero.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Genero.Location = new Point(677, 480);
            lbl_Genero.Name = "lbl_Genero";
            lbl_Genero.Size = new Size(66, 23);
            lbl_Genero.TabIndex = 35;
            lbl_Genero.Text = "Genero";
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.Moccasin;
            btn_Eliminar.Font = new Font("Century", 10.2F);
            btn_Eliminar.Location = new Point(1212, 463);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(114, 38);
            btn_Eliminar.TabIndex = 36;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // lbl_Maestro
            // 
            lbl_Maestro.AutoSize = true;
            lbl_Maestro.BackColor = Color.Transparent;
            lbl_Maestro.Font = new Font("Century", 10.8F);
            lbl_Maestro.Location = new Point(703, 284);
            lbl_Maestro.Name = "lbl_Maestro";
            lbl_Maestro.Size = new Size(143, 22);
            lbl_Maestro.TabIndex = 38;
            lbl_Maestro.Text = "Maestro Titular";
            // 
            // txt_Maestro_Titular
            // 
            txt_Maestro_Titular.Location = new Point(852, 284);
            txt_Maestro_Titular.Name = "txt_Maestro_Titular";
            txt_Maestro_Titular.Size = new Size(183, 27);
            txt_Maestro_Titular.TabIndex = 39;
            // 
            // dgv_Datos
            // 
            dgv_Datos.BackgroundColor = Color.Moccasin;
            dgv_Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Datos.Columns.AddRange(new DataGridViewColumn[] { Matricula, Nombre, Genero, Dirección, Telefono, Email, Maestro_Titular, Area_Tecnica, Curso, Sección });
            dgv_Datos.Location = new Point(33, 602);
            dgv_Datos.Name = "dgv_Datos";
            dgv_Datos.RowHeadersWidth = 51;
            dgv_Datos.Size = new Size(1303, 188);
            dgv_Datos.TabIndex = 40;
            // 
            // Matricula
            // 
            Matricula.HeaderText = "Matricula";
            Matricula.MinimumWidth = 6;
            Matricula.Name = "Matricula";
            Matricula.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.Width = 125;
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.MinimumWidth = 6;
            Dirección.Name = "Dirección";
            Dirección.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Maestro_Titular
            // 
            Maestro_Titular.HeaderText = "Maestro Titular";
            Maestro_Titular.MinimumWidth = 6;
            Maestro_Titular.Name = "Maestro_Titular";
            Maestro_Titular.Width = 125;
            // 
            // Area_Tecnica
            // 
            Area_Tecnica.HeaderText = "Area Tecnica";
            Area_Tecnica.MinimumWidth = 6;
            Area_Tecnica.Name = "Area_Tecnica";
            Area_Tecnica.Width = 125;
            // 
            // Curso
            // 
            Curso.HeaderText = "Curso";
            Curso.MinimumWidth = 6;
            Curso.Name = "Curso";
            Curso.Width = 125;
            // 
            // Sección
            // 
            Sección.HeaderText = "Sección";
            Sección.MinimumWidth = 6;
            Sección.Name = "Sección";
            Sección.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1469, 802);
            Controls.Add(dgv_Datos);
            Controls.Add(txt_Maestro_Titular);
            Controls.Add(lbl_Maestro);
            Controls.Add(btn_Eliminar);
            Controls.Add(lbl_Genero);
            Controls.Add(rbo_Maculino);
            Controls.Add(lbl_Sección);
            Controls.Add(cbo_Sección);
            Controls.Add(cbo_Curso);
            Controls.Add(lbl_Curso);
            Controls.Add(lbl_area_tecnica);
            Controls.Add(txt_Email);
            Controls.Add(txt_Telefono);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Telefono);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Dirección);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Matricula);
            Controls.Add(lbl_Dirección);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Matricula);
            Controls.Add(rbo_Femenino);
            Controls.Add(cbo_Area_tecnica);
            Controls.Add(label1);
            Controls.Add(btn_Agregar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_Nuevo);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Nuevo;
        private Button btn_Guardar;
        private Button btn_Salir;
        private Button btn_Agregar;
        private Label label1;
        private ComboBox cbo_Area_tecnica;
        private RadioButton rbo_Femenino;
        private Label lbl_Matricula;
        private Label lbl_Nombre;
        private Label lbl_Dirección;
        private TextBox txt_Matricula;
        private TextBox txt_Nombre;
        private TextBox txt_Dirección;
        private Label label2;
        private Label label3;
        private Label lbl_Telefono;
        private Label lbl_Email;
        private TextBox txt_Telefono;
        private TextBox txt_Email;
        private Label lbl_area_tecnica;
        private Label lbl_Curso;
        private ComboBox cbo_Curso;
        private ComboBox cbo_Sección;
        private Label lbl_Sección;
        private RadioButton rbo_Maculino;
        private Label lbl_Genero;
        private Button btn_Eliminar;
        private Label lbl_Maestro;
        private TextBox txt_Maestro_Titular;
        private DataGridView dgv_Datos;
        private DataGridViewTextBoxColumn Matricula;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Maestro_Titular;
        private DataGridViewTextBoxColumn Area_Tecnica;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Sección;
        private SaveFileDialog dlg_Guardar;
    }
}
