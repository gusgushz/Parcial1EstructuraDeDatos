using System.Collections.Generic;
using System.Windows.Forms;
using static Parcial1.Form1;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Paciente> Pacientes = new List<Paciente>();
        RegistroPacientes FaroDelMayab = new RegistroPacientes();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            labelNombre.Visible = true;
            labelEdad.Visible = true;
            labelGenero.Visible = true;
            labelTelefono.Visible = true;
            labelDiagnostico.Visible = true;
            textBoxNombre.Visible = true;
            textBoxEdad.Visible = true;
            textBoxGenero.Visible = true;
            textBoxTelefono.Visible = true;
            textBoxDiagnostico.Visible = true;
            buttonEnviarAgr.Visible = true;

            btnListado.Visible = false;
            btnBuscador.Visible = false;
            btnEliminar.Visible = false;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = false;

            buttonSalir.Visible = true;
        }
        private void buttonEnviarAgr_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            int edad = int.Parse(textBoxEdad.Text);
            string genero = textBoxGenero.Text;
            string telefono = textBoxTelefono.Text;
            string diagnostico = textBoxDiagnostico.Text;
            FaroDelMayab.AgregarPacientes(Pacientes, nombre, edad, genero, telefono, diagnostico);
            textBoxNombre.Clear();
            textBoxEdad.Clear();
            textBoxGenero.Clear();
            textBoxTelefono.Clear();
            textBoxDiagnostico.Clear();
            btnAgregar.Visible = true;
            labelNombre.Visible = false;
            labelEdad.Visible = false;
            labelGenero.Visible = false;
            labelTelefono.Visible = false;
            labelDiagnostico.Visible = false;
            textBoxNombre.Visible = false;
            textBoxEdad.Visible = false;
            textBoxGenero.Visible = false;
            textBoxTelefono.Visible = false;
            textBoxDiagnostico.Visible = false;
            buttonEnviarAgr.Visible = false;

            btnListado.Visible = true;
            btnBuscador.Visible = true;
            btnEliminar.Visible = true;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = true;

            buttonSalir.Visible = false;
        }
        private void btnListado_Click(object sender, EventArgs e)
        {
            btnListado.Visible = false;
            listBox1.Items.Clear();
            listBox1.Visible = true;

            FaroDelMayab.MostrarPacientes(Pacientes, listBox1);
            buttonCerrarList.Visible = true;

            btnAgregar.Visible = false;
            btnBuscador.Visible = false;
            btnEliminar.Visible = false;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = false;
        }
        private void buttonCerrarList_Click(object sender, EventArgs e)
        {
            btnListado.Visible = true;
            listBox1.Items.Clear();
            listBox1.Visible = false;
            buttonCerrarList.Visible = false;

            btnAgregar.Visible = true;
            btnBuscador.Visible = true;
            btnEliminar.Visible = true;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = true;
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnListado.Visible = false;
            btnBuscador.Visible = false;
            btnEliminar.Visible = false;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = false;

            buttonBuscarN.Visible = true;
            buttonBuscarD.Visible = true;

            labelNombre.Visible = true;
            labelDiagnostico.Visible = true;
            textBoxNombre.Visible = true;
            textBoxDiagnostico.Visible = true;

            buttonSalir.Visible = true;
        }

        private void buttonBuscarN_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            listBox1.Visible = true;
            List<Paciente> pacientesEncontrados = FaroDelMayab.BuscarPacientesNombre(Pacientes, nombre);
            foreach (Paciente paciente in pacientesEncontrados)
            {
                listBox1.Items.Add($"ID:{paciente.Id} | Nombre: {paciente.Nombre} | Edad: {paciente.Edad} | Género: {paciente.Genero} | Teléfono: {paciente.Telefono} | Diagnóstico: {paciente.Diagnostico}");
            }

            buttonBuscarN.Visible = false;
            buttonBuscarD.Visible = false;

            labelNombre.Visible = false;
            labelDiagnostico.Visible = false;
            textBoxNombre.Clear();
            textBoxNombre.Visible = false;
            textBoxDiagnostico.Clear();
            textBoxDiagnostico.Visible = false;

            buttonCerrarList.Visible = true;

            btnListado.Visible = false;
            btnBuscador.Visible = false;
            btnEliminar.Visible = false;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = false;

            buttonSalir.Visible = true;
        }
        private void buttonBuscarD_Click(object sender, EventArgs e)
        {
            string diagnostico = textBoxDiagnostico.Text;
            listBox1.Visible = true;
            List<Paciente> pacientesEncontrados = FaroDelMayab.BuscarPacientesDiagnostico(Pacientes, diagnostico);
            foreach (Paciente paciente in pacientesEncontrados)
            {
                listBox1.Items.Add($"ID:{paciente.Id} | Nombre: {paciente.Nombre} | Edad: {paciente.Edad} | Género: {paciente.Genero} | Teléfono: {paciente.Telefono} | Diagnóstico: {paciente.Diagnostico}");
            }

            buttonBuscarN.Visible = false;
            buttonBuscarD.Visible = false;

            labelNombre.Visible = false;
            labelDiagnostico.Visible = false;
            textBoxNombre.Clear();
            textBoxNombre.Visible = false;
            textBoxDiagnostico.Clear();
            textBoxDiagnostico.Visible = false;

            buttonCerrarList.Visible = true;

            btnListado.Visible = false;
            btnBuscador.Visible = false;
            btnEliminar.Visible = false;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = false;

            buttonSalir.Visible = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            labelEdad.Visible = true;
            labelEdad.Text = "ID";
            textBoxID.Visible = true;
            btnAgregar.Visible = false;
            btnBuscador.Visible = false;
            btnListado.Visible = false;
            btnEliminar.Visible = false;
            buttonEnviarElim.Visible = true;
            buttonEstad.Visible = false;

            buttonSalir.Visible = true;
        }
        private void buttonEnviarElim_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            FaroDelMayab.EliminarPaciente(Pacientes, id);

            labelEdad.Visible = false;
            labelEdad.Text = "Edad";
            textBoxID.Visible = false;

            textBoxID.Clear();

            btnAgregar.Visible = true;
            btnBuscador.Visible = true;
            btnListado.Visible = true;
            btnEliminar.Visible = true;
            buttonEnviarElim.Visible = false;
            buttonEstad.Visible = true;

            buttonSalir.Visible = false;
        }
        private void buttonEstad_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnListado.Visible = false;
            btnBuscador.Visible = false;
            btnEliminar.Visible = false;
            buttonEstad.Visible = false;
            listBox1.Visible = true;
            buttonSalir.Visible = true;
            double[] Estadisticas = FaroDelMayab.CalcularEstadisticasPacientes(Pacientes);
            listBox1.Items.Add($"Total de pacientes: {Estadisticas[0]} | Promedio de edad de pacientes: {Estadisticas[1]}");
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;
            btnListado.Visible = true;
            btnBuscador.Visible = true;
            btnEliminar.Visible = true;
            buttonEstad.Visible = true;
            listBox1.Visible = false;
            listBox1.Items.Clear();
            textBoxNombre.Visible = false;
            textBoxNombre.Clear();
            textBoxEdad.Visible = false;
            textBoxEdad.Clear();
            textBoxGenero.Visible = false;
            textBoxGenero.Clear();
            textBoxTelefono.Visible = false;
            textBoxTelefono.Clear();
            textBoxDiagnostico.Visible = false;
            textBoxDiagnostico.Clear();
            labelNombre.Visible = false;
            labelEdad.Visible = false;
            labelEdad.Text = "Edad";
            labelGenero.Visible = false;
            labelTelefono.Visible = false;
            labelDiagnostico.Visible = false;
            buttonEnviarAgr.Visible = false;
            buttonCerrarList.Visible = false;
            buttonEnviarElim.Visible = false;
            textBoxID.Visible = false;
            textBoxID.Clear();
            buttonSalir.Visible = false;
            buttonBuscarN.Visible = false;
            buttonBuscarD.Visible = false;
        }
        public class Paciente
        {
            private static int proximoId = 1;
            public int Id { get; private set; } = 0;
            public string Nombre { get; set; } = null!;
            public int Edad { get; set; }
            public string Genero { get; set; } = null!;
            public string Telefono { get; set; } = null!;
            public string Diagnostico { get; set; } = null!;

            public Paciente()
            {
                Id = proximoId;
                proximoId++;
            }
        }
        public class RegistroPacientes
        {
            public void AgregarPacientes(List<Paciente> Pacientes, string nombre, int edad, string genero, string telefono, string diagnostico)
            {
                Pacientes.Add(new Paciente { Nombre = nombre, Edad = edad, Genero = genero, Telefono = telefono, Diagnostico = diagnostico });
            }

            public List<Paciente> BuscarPacientesNombre(List<Paciente> Pacientes, string nombre)
            {
                List<Paciente> pacientesEncontrados = new List<Paciente>();
                foreach (Paciente paciente in Pacientes)
                {
                    if (paciente.Nombre.ToLower().Contains(nombre.ToLower()))
                    {
                        pacientesEncontrados.Add(paciente);
                    }
                }
                return pacientesEncontrados;
            }

            public List<Paciente> BuscarPacientesDiagnostico(List<Paciente> Pacientes, string diagnostico)
            {
                List<Paciente> pacientesEncontrados = new List<Paciente>();
                foreach (Paciente paciente in Pacientes)
                {
                    if (paciente.Diagnostico.ToLower().Contains(diagnostico.ToLower()))
                    {
                        pacientesEncontrados.Add(paciente);
                    }
                }
                return pacientesEncontrados;
            }

            public void MostrarPacientes(List<Paciente> Pacientes, ListBox listBox1)
            {
                foreach (Paciente paciente in Pacientes)
                {
                    listBox1.Items.Add($"ID:{paciente.Id} | Nombre: {paciente.Nombre} | Edad: {paciente.Edad} | Género: {paciente.Genero} | Teléfono: {paciente.Telefono} | Diagnóstico: {paciente.Diagnostico}");
                }
            }

            public void EliminarPaciente(List<Paciente> Pacientes, int id)
            {
                Paciente pacienteEntrado = Pacientes.Find(p => p.Id == id)!;
                if (pacienteEntrado == null)
                {
                    MessageBox.Show("No se encontro un paciente con ese ID");
                    return;
                }
                else
                {
                    Pacientes.Remove(pacienteEntrado);
                }
            }
            public double[] CalcularEstadisticasPacientes(List<Paciente> Pacientes)
            {
                double totalPacientes = Pacientes.Count();
                double edadPromedioPacientes = 0;
                foreach (Paciente paciente in Pacientes)
                {
                    edadPromedioPacientes += paciente.Edad;
                }
                edadPromedioPacientes /= totalPacientes;

                double[] Resultados = { totalPacientes, edadPromedioPacientes };
                return Resultados;
            }
        }
    }
}