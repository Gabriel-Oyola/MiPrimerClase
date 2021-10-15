using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerClase
{
    public partial class Form1 : Form
    {
        Persona PersonaAMostrar = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            
            PersonaAMostrar.Nombre = txtNombre.Text;
            PersonaAMostrar.Apellido = txtApellido.Text;

            lblPersonas.Text = PersonaAMostrar.NombreCompleto();
        }

        private void btInscribir_Click(object sender, EventArgs e)
        {
            Materia MateriaInsripta = new Materia();
            MateriaInsripta.NombreMateria = txtMateria.Text;
            MateriaInsripta.Año = Convert.ToInt32(txtAño.Text);
            //PersonaAMostrar.MateriaCursando = MateriaInsripta;
            PersonaAMostrar.Inscribir(MateriaInsripta);

            //lblMostrarIns.Text = PersonaAMostrar.MateriaCursando.NombreMateria
            //    + "Año: "
            //    + PersonaAMostrar.MateriaCursando.Año.ToString();


            lblMostrarIns.Text = PersonaAMostrar.NombreCompletoMateria();
        }
    }
}
