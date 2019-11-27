using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_GesBib_Cliente
{
    public partial class frmCapacitaciones : Form
    {
        //Estado estadoCapacitaciones;

        private Form var_formGestor;
        private ServicioJava.capacitacion capacitacion;
        private BindingList<ServicioJava.diaCapacitacion> listaDiaCapacitacion;
        private static int i = 0;
        public frmCapacitaciones()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }

        public frmCapacitaciones(Form _formPerfilGestor)
        {
            var_formGestor = _formPerfilGestor;
            InitializeComponent();
        }

        // Estados
        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    // TextBox
                    txtNombre.Enabled = false;
                    txtLugar.Enabled = false;
                    txtDescripcion.Enabled = false;
                    // Fechas
                    dtpInicio.Enabled = false;
                    dtpFin.Enabled = false;
                    dtpInicioInscripcion.Enabled = false;
                    dtpFinInscripcion.Enabled = false;
                    //Botones
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    break;

                case Estado.Nuevo:
                    // TextBox
                    txtNombre.Enabled = true;
                    txtLugar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    // Fechas
                    dtpInicio.Enabled = true;
                    dtpFin.Enabled = true;
                    dtpInicioInscripcion.Enabled = true;
                    dtpFinInscripcion.Enabled = true;
                    // Buttons
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;

                case Estado.Modificar:
                    // TextBox
                    txtNombre.Enabled = true;
                    txtLugar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    // Fechas
                    dtpInicio.Enabled = true;
                    dtpFin.Enabled = true;
                    dtpInicioInscripcion.Enabled = true;
                    dtpFinInscripcion.Enabled = true;
                    //Botones
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;

                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    break;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            //poner el panel BIPO en visible
            ((frmPerfilGestor)var_formGestor).PanelBIPO.Visible = true;

        }

        private void btnCrearDiaCapa_Click(object sender, EventArgs e)
        {
            frmCrearDiaCapacitacion frmCrearDiaPA = new frmCrearDiaCapacitacion();
            frmCrearDiaPA.Show();
            frmCrearDiaPA.Location = new Point(0, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Nuevo);
            //capacitacion = new ServicioJava.capacitacion();
            //estadoCapacitaciones = Estado.Nuevo;            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Modificar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Buscar);
        }

        private void btnPerInscrito_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // creamos el objeto capacitacion
            capacitacion = new ServicioJava.capacitacion();
            capacitacion.nombre = txtNombre.Text;
            capacitacion.lugar = txtLugar.Text;
            capacitacion.descripcion = txtDescripcion.Text;
            capacitacion.fecha_ini = dtpInicio.Value;
            capacitacion.fecha_iniSpecified = true;
            capacitacion.fecha_fin = dtpFin.Value;
            capacitacion.fecha_finSpecified = true;
            capacitacion.inicio_inscripcion = dtpInicioInscripcion.Value;
            capacitacion.inicio_inscripcionSpecified = true;
            capacitacion.fin_inscripcion = dtpFinInscripcion.Value;
            capacitacion.fin_inscripcionSpecified = true;

            listaDiaCapacitacion = new BindingList<ServicioJava.diaCapacitacion>();

            foreach (DataGridViewRow row in dgvDiaCapacitacion.Rows)
            {
                ServicioJava.diaCapacitacion diaCapacitacion = new ServicioJava.diaCapacitacion();
                String aux = row.Cells[1].Value.ToString();
                diaCapacitacion.fecha = Convert.ToDateTime(aux);
                diaCapacitacion.fechaSpecified = true;
                diaCapacitacion.hora_ini = row.Cells[2].Value.ToString();
                diaCapacitacion.hora_fin = row.Cells[3].Value.ToString();
                listaDiaCapacitacion.Add(diaCapacitacion);
            }
            capacitacion.listaDiasCapacitacion = listaDiaCapacitacion.ToArray();

            Program.DBController.insertarCapacitacion(capacitacion);
        }

        private void btnAgregarPA_Click(object sender, EventArgs e)
        {
            
            frmCrearDiaCapacitacion formCrearDC = new frmCrearDiaCapacitacion();
            if (formCrearDC.ShowDialog() == DialogResult.OK)
            {
                i++;
                String dato0 = i.ToString();
                String dato1 = formCrearDC.DiaCapacitacionSeleccionada.fecha.ToString();
                String dato2 = formCrearDC.DiaCapacitacionSeleccionada.hora_ini;
                String dato3 = formCrearDC.DiaCapacitacionSeleccionada.hora_fin;
                dgvDiaCapacitacion.Rows.Add(dato0, dato1, dato2, dato3);
            }
        }

    }
}
