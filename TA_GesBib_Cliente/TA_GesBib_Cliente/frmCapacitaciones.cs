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
        private int esModificar;
        private Form var_formGestor;
        private BindingList<ServicioJava.personal> listaPersonal;
        private ServicioJava.capacitacion capacitacion;
        private BindingList<ServicioJava.diaCapacitacion> listaDiaCapacitacion;
        private ServicioJava.capacitacion capacitacionSeleccionada;
        private int idCap;
        public frmCapacitaciones()
        {
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
        }

        public frmCapacitaciones(Form _formPerfilGestor)
        {
            var_formGestor = _formPerfilGestor;
            InitializeComponent();
            estadoComponentes(Estado.Inicial);
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
                    btnAgregarDC.Enabled = false;
                    btnEditarDC.Enabled = false;
                    btnQuitarDC.Enabled = false;
                    btnPerInscrito.Enabled = false;
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
                    btnAgregarDC.Enabled = true;
                    btnEditarDC.Enabled = true;
                    btnQuitarDC.Enabled = true;
                    btnPerInscrito.Enabled = false;
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
                    btnAgregarDC.Enabled = true;
                    btnEditarDC.Enabled = true; 
                    btnQuitarDC.Enabled = true;
                    btnPerInscrito.Enabled = true;
                    break;

                case Estado.Buscar:
                    //Botones
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnAgregarDC.Enabled = false;
                    btnEditarDC.Enabled = false;
                    btnQuitarDC.Enabled = false;
                    btnPerInscrito.Enabled = false;
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
            esModificar = 0;            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Modificar);
            esModificar = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.Buscar);
            frmBuscarCapacitacion frmBuscarCap = new frmBuscarCapacitacion();
            if (frmBuscarCap.ShowDialog() == DialogResult.OK)
            {                
                capacitacionSeleccionada = frmBuscarCap.CapacitacionSeleccionada;
                idCap = capacitacionSeleccionada.id;
                listaPersonal = new BindingList<ServicioJava.personal>(capacitacionSeleccionada.listaPersonal);                
                txtNombre.Text = capacitacionSeleccionada.nombre;
                txtLugar.Text = capacitacionSeleccionada.lugar;
                txtDescripcion.Text = capacitacionSeleccionada.descripcion;
                dtpInicio.Value = capacitacionSeleccionada.fecha_ini;
                dtpFin.Value = capacitacionSeleccionada.fecha_fin;
                dtpInicioInscripcion.Value = capacitacionSeleccionada.inicio_inscripcion;
                dtpFinInscripcion.Value = capacitacionSeleccionada.fin_inscripcion;                
                for(int x = 0; x < capacitacionSeleccionada.listaDiasCapacitacion.Length; x++)
                {
                    String aux1 = capacitacionSeleccionada.listaDiasCapacitacion[x].fecha.ToString();
                    String dato1 = aux1.Substring(0, 10);
                    String aux2 = capacitacionSeleccionada.listaDiasCapacitacion[x].hora_ini;
                    String dato2 = aux2.Substring(0, 5);
                    String aux3 = capacitacionSeleccionada.listaDiasCapacitacion[x].hora_fin;
                    String dato3 = aux3.Substring(0, 5);
                    dgvDiaCapacitacion.Rows.Add(dato1, dato2, dato3);
                }
                estadoComponentes(Estado.Buscar);
            }
        }

        private void btnPerInscrito_Click(object sender, EventArgs e)
        {
            frmPersonalInscrito formPersonal = new frmPersonalInscrito(listaPersonal);
            formPersonal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre de la capacitación","Mensaje");
                return;
            }else if (txtLugar.Text == "")
            {
                MessageBox.Show("Debe ingresar lugar de la capacitación","Mensaje");
                return;
            }else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar descripción de la capacitación", "Mensaje");
                return;
            }
            DateTime temp1, temp2, temp3, temp4;
            DateTime.TryParse(dtpInicio.Text, out temp1);
            DateTime.TryParse(dtpFin.Text, out temp2);
            DateTime.TryParse(dtpInicioInscripcion.Text, out temp3);
            DateTime.TryParse(dtpFinInscripcion.Text, out temp4);
            if (temp1 > temp2)
            {
                MessageBox.Show("La Fecha Inicio debe ser menor a la Fecha Fin", "Mensaje");
                return;
            }
            if (temp3 > temp4)
            {
                MessageBox.Show("La Fecha Inicio de Inscripción debe ser menor a la Fecha Fin Inscripción","Mensaje");
                return;
            }
            if (temp1 < temp4)
            {
                MessageBox.Show("La Fecha Inicio debe ser mayor a la Fecha Fin de Inscripción0", "Mensaje");
                return;
            }
            
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
                String aux = row.Cells[0].Value.ToString();
                diaCapacitacion.fecha = Convert.ToDateTime(aux);
                diaCapacitacion.fechaSpecified = true;
                diaCapacitacion.hora_ini = row.Cells[1].Value.ToString();
                diaCapacitacion.hora_fin = row.Cells[2].Value.ToString();
                listaDiaCapacitacion.Add(diaCapacitacion);
            }
            capacitacion.listaDiasCapacitacion = listaDiaCapacitacion.ToArray();
            if (esModificar == 0)
            {
                Program.DBController.insertarCapacitacion(capacitacion);
                MessageBox.Show("Capacitacion registrada exitosamente", "Mensaje Confirmacón", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (esModificar == 1)
            {
                capacitacion.id = idCap;                
                Program.DBController.actualizarCapacitacion(capacitacion);
                MessageBox.Show("Capacitacion modificada exitosamente", "Mensaje Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnAgregarDC_Click(object sender, EventArgs e)
        {
            
            frmCrearDiaCapacitacion formCrearDC = new frmCrearDiaCapacitacion();
            if (formCrearDC.ShowDialog() == DialogResult.OK)
            {
                String aux1 = formCrearDC.DiaCapacitacionSeleccionada.fecha.ToString();
                String dato1 = aux1.Substring(0, 10);
                String aux2 = formCrearDC.DiaCapacitacionSeleccionada.hora_ini;
                String dato2 = aux2.Substring(11, 5);
                String aux3 = formCrearDC.DiaCapacitacionSeleccionada.hora_fin;
                String dato3 = aux3.Substring(11, 5);
                dgvDiaCapacitacion.Rows.Add(dato1, dato2, dato3);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void limpiarComponentes()
        {
            txtNombre.Text = "";
            txtLugar.Text = "";
            txtDescripcion.Text = "";
            dgvDiaCapacitacion.RowCount = 0;
        }

        private void btnQuitarPA_Click(object sender, EventArgs e)
        {
            dgvDiaCapacitacion.Rows.Remove(dgvDiaCapacitacion.CurrentRow);
        }

        private void btnEditarDC_Click(object sender, EventArgs e)
        {
            String aux = dgvDiaCapacitacion.CurrentRow.Cells[0].Value.ToString();
            DateTime dato1 = Convert.ToDateTime(aux);
            String dato2 = dgvDiaCapacitacion.CurrentRow.Cells[1].Value.ToString();
            String dato3 = dgvDiaCapacitacion.CurrentRow.Cells[2].Value.ToString();
            int index = dgvDiaCapacitacion.CurrentRow.Index;
            frmModificarDiaCapacitacion formModificar = new frmModificarDiaCapacitacion(dato1, dato2, dato3);
            if (formModificar.ShowDialog() == DialogResult.OK)
            {
                String aux1 = formModificar.DiaCapacitacionSeleccionada.fecha.ToString();
                String data1 = aux1.Substring(0, 10);
                String aux2 = formModificar.DiaCapacitacionSeleccionada.hora_ini;
                String data2 = aux2.Substring(11, 5);
                String aux3 = formModificar.DiaCapacitacionSeleccionada.hora_fin;
                String data3 = aux3.Substring(11, 5);
                dgvDiaCapacitacion.Rows.RemoveAt(index);
                dgvDiaCapacitacion.Rows.Insert(index, data1, data2, data3);
            }
        }
    }
}
