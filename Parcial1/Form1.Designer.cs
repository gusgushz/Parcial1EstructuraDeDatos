namespace Parcial1
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
            btnAgregar = new Button();
            btnListado = new Button();
            btnBuscador = new Button();
            btnEliminar = new Button();
            listBox1 = new ListBox();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            textBoxGenero = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxDiagnostico = new TextBox();
            labelNombre = new Label();
            labelEdad = new Label();
            labelGenero = new Label();
            labelTelefono = new Label();
            labelDiagnostico = new Label();
            buttonEnviarAgr = new Button();
            buttonCerrarList = new Button();
            buttonEstad = new Button();
            buttonEnviarElim = new Button();
            textBoxID = new TextBox();
            buttonSalir = new Button();
            buttonBuscarN = new Button();
            buttonBuscarD = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(82, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 50);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Pacientes";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnListado
            // 
            btnListado.Location = new Point(280, 44);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(94, 54);
            btnListado.TabIndex = 1;
            btnListado.Text = "Listado de Pacientes";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnBuscador
            // 
            btnBuscador.Location = new Point(453, 48);
            btnBuscador.Name = "btnBuscador";
            btnBuscador.Size = new Size(94, 55);
            btnBuscador.TabIndex = 2;
            btnBuscador.Text = "Buscar Paciente";
            btnBuscador.UseVisualStyleBackColor = true;
            btnBuscador.Click += btnBuscador_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(627, 45);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 53);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Paciente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(78, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(643, 164);
            listBox1.TabIndex = 4;
            listBox1.Visible = false;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(218, 141);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(410, 27);
            textBoxNombre.TabIndex = 5;
            textBoxNombre.Visible = false;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(218, 190);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(410, 27);
            textBoxEdad.TabIndex = 6;
            textBoxEdad.Visible = false;
            // 
            // textBoxGenero
            // 
            textBoxGenero.Location = new Point(219, 346);
            textBoxGenero.Name = "textBoxGenero";
            textBoxGenero.Size = new Size(410, 27);
            textBoxGenero.TabIndex = 9;
            textBoxGenero.Visible = false;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(219, 295);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(410, 27);
            textBoxTelefono.TabIndex = 8;
            textBoxTelefono.Visible = false;
            // 
            // textBoxDiagnostico
            // 
            textBoxDiagnostico.Location = new Point(215, 241);
            textBoxDiagnostico.Name = "textBoxDiagnostico";
            textBoxDiagnostico.Size = new Size(410, 27);
            textBoxDiagnostico.TabIndex = 7;
            textBoxDiagnostico.Visible = false;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(215, 111);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre";
            labelNombre.Visible = false;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(218, 172);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 11;
            labelEdad.Text = "Edad";
            labelEdad.Visible = false;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(221, 325);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(57, 20);
            labelGenero.TabIndex = 12;
            labelGenero.Text = "Género";
            labelGenero.Visible = false;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(215, 271);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 13;
            labelTelefono.Text = "Teléfono";
            labelTelefono.Visible = false;
            // 
            // labelDiagnostico
            // 
            labelDiagnostico.AutoSize = true;
            labelDiagnostico.Location = new Point(216, 218);
            labelDiagnostico.Name = "labelDiagnostico";
            labelDiagnostico.Size = new Size(89, 20);
            labelDiagnostico.TabIndex = 14;
            labelDiagnostico.Text = "Diagnóstico";
            labelDiagnostico.Visible = false;
            // 
            // buttonEnviarAgr
            // 
            buttonEnviarAgr.Location = new Point(289, 393);
            buttonEnviarAgr.Name = "buttonEnviarAgr";
            buttonEnviarAgr.Size = new Size(258, 36);
            buttonEnviarAgr.TabIndex = 15;
            buttonEnviarAgr.Text = "Agregar";
            buttonEnviarAgr.UseVisualStyleBackColor = true;
            buttonEnviarAgr.Visible = false;
            buttonEnviarAgr.Click += buttonEnviarAgr_Click;
            // 
            // buttonCerrarList
            // 
            buttonCerrarList.Location = new Point(280, 68);
            buttonCerrarList.Name = "buttonCerrarList";
            buttonCerrarList.Size = new Size(267, 45);
            buttonCerrarList.TabIndex = 16;
            buttonCerrarList.Text = "Cerrar Listado";
            buttonCerrarList.UseVisualStyleBackColor = true;
            buttonCerrarList.Visible = false;
            buttonCerrarList.Click += buttonCerrarList_Click;
            // 
            // buttonEstad
            // 
            buttonEstad.Location = new Point(347, 193);
            buttonEstad.Name = "buttonEstad";
            buttonEstad.Size = new Size(147, 42);
            buttonEstad.TabIndex = 17;
            buttonEstad.Text = "Estadísticas";
            buttonEstad.UseVisualStyleBackColor = true;
            buttonEstad.Click += buttonEstad_Click;
            // 
            // buttonEnviarElim
            // 
            buttonEnviarElim.Location = new Point(284, 379);
            buttonEnviarElim.Name = "buttonEnviarElim";
            buttonEnviarElim.Size = new Size(265, 34);
            buttonEnviarElim.TabIndex = 18;
            buttonEnviarElim.Text = "Eliminar";
            buttonEnviarElim.UseVisualStyleBackColor = true;
            buttonEnviarElim.Visible = false;
            buttonEnviarElim.Click += buttonEnviarElim_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(219, 190);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(408, 27);
            textBoxID.TabIndex = 20;
            textBoxID.Visible = false;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(679, 400);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(94, 29);
            buttonSalir.TabIndex = 21;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonBuscarN
            // 
            buttonBuscarN.Location = new Point(311, 174);
            buttonBuscarN.Name = "buttonBuscarN";
            buttonBuscarN.Size = new Size(204, 46);
            buttonBuscarN.TabIndex = 22;
            buttonBuscarN.Text = "Buscar con Nombre";
            buttonBuscarN.UseVisualStyleBackColor = true;
            buttonBuscarN.Visible = false;
            buttonBuscarN.Click += buttonBuscarN_Click;
            // 
            // buttonBuscarD
            // 
            buttonBuscarD.Location = new Point(311, 273);
            buttonBuscarD.Name = "buttonBuscarD";
            buttonBuscarD.Size = new Size(204, 49);
            buttonBuscarD.TabIndex = 23;
            buttonBuscarD.Text = "Buscar con Diagnóstico";
            buttonBuscarD.UseVisualStyleBackColor = true;
            buttonBuscarD.Visible = false;
            buttonBuscarD.Click += buttonBuscarD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuscarD);
            Controls.Add(buttonBuscarN);
            Controls.Add(buttonSalir);
            Controls.Add(textBoxID);
            Controls.Add(buttonEnviarElim);
            Controls.Add(buttonEstad);
            Controls.Add(buttonCerrarList);
            Controls.Add(buttonEnviarAgr);
            Controls.Add(labelDiagnostico);
            Controls.Add(labelTelefono);
            Controls.Add(labelGenero);
            Controls.Add(labelEdad);
            Controls.Add(labelNombre);
            Controls.Add(textBoxDiagnostico);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxGenero);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Controls.Add(listBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscador);
            Controls.Add(btnListado);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnListado;
        private Button btnBuscador;
        private Button btnEliminar;
        private ListBox listBox1;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private TextBox textBoxGenero;
        private TextBox textBoxTelefono;
        private TextBox textBoxDiagnostico;
        private Label labelNombre;
        private Label labelEdad;
        private Label labelGenero;
        private Label labelTelefono;
        private Label labelDiagnostico;
        private Button buttonEnviarAgr;
        private Button buttonCerrarList;
        private Button buttonEstad;
        private Button buttonEnviarElim;
        private TextBox textBoxID;
        private Button buttonSalir;
        private Button buttonBuscarN;
        private Button buttonBuscarD;
    }
}