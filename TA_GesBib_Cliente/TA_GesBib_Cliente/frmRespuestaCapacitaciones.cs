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
    public partial class frmRespuestaCapacitaciones : Form
    {

        private Form var_perfilPersonal;
        private TipoPerfil var_tipoPerfil = TipoPerfil.PerfilBibliotecario;
        private ServicioJava.usuario var_usuario;

        private BindingList<ServicioJava.capacitacion> _lstaCapaPend;
        private BindingList<ServicioJava.capacitacion> _lstaCapaAcep;

        ServicioJava.ServicioClient servTA = new ServicioJava.ServicioClient();

        public frmRespuestaCapacitaciones()
        {
            InitializeComponent();
        }


        public frmRespuestaCapacitaciones(Form formPerfilPersonal, TipoPerfil tipoPerfil,
            ServicioJava.usuario _user)
        {
            var_perfilPersonal = formPerfilPersonal;
            var_tipoPerfil = tipoPerfil;
            var_usuario = _user;

            InitializeComponent();

            //autogenrates columns = false...            
            dgvRespCapac.AutoGenerateColumns = false;
            dgvAceptadas.AutoGenerateColumns = false;
            
            //Cargar data
            //dgvRespCapac.DataSource = Program.DBController.listarCapacitaciones();//lsita todas

            //pasamos a las variables de listas

            try
            {
                _lstaCapaPend = new BindingList<ServicioJava.capacitacion>(
                Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id, -1));
                //aca lista todas de este usuario q aun estan por confirmar
                dgvRespCapac.DataSource = _lstaCapaPend;
            }
            catch(Exception ex)
            {

            }
            

            try
            {
                _lstaCapaAcep = new BindingList<ServicioJava.capacitacion>(
                Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id, 1));
                //luego debe lsitar al listar capas aceptadas por este personal
                dgvAceptadas.DataSource = _lstaCapaAcep;
            }
            catch(Exception ex)
            {

            }
            
                        
            
            


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            switch (var_tipoPerfil)
            {
                /*case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    this.var_perfilBibliotecario.LblBienvenido.Visible = true;
                    this.var_perfilBibliotecario.PanelAviso.Visible = true;
                    break;*/
                case TipoPerfil.PerfilBibliotecario:
                    this.Visible = false;
                    //((frmPerfilBibliotecario)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelAviso.Visible = true;
                    ((frmPerfilBibliotecario)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                case TipoPerfil.PerfilAuxiliar:
                    this.Visible = false;
                    //((frmPerfilAuxiliar)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilAuxiliar)this.var_perfilPersonal).PanelAviso.Visible = true;
                    //((frmPerfilAuxiliar)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                case TipoPerfil.PerfilPracticante:
                    this.Visible = false;
                    //((frmPerfilPracticante)this.var_perfilPersonal).LblBienvenido.Visible = true;
                    ((frmPerfilPracticante)this.var_perfilPersonal).PanelAviso.Visible = true;
                    //((frmPerfilPracticante)this.var_perfilPersonal).PanelBIPO.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void dgvRespCapac_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            ServicioJava.capacitacion _capa = dgvRespCapac.Rows[e.RowIndex].DataBoundItem
                         as ServicioJava.capacitacion;

            dgvRespCapac.Rows[e.RowIndex].Cells[0].Value = _capa.nombre;
            dgvRespCapac.Rows[e.RowIndex].Cells[1].Value = _capa.descripcion;

        }

       

        private void btnGuardarPen_Click(object sender, EventArgs e)
        {

            if (dgvRespCapac.RowCount > 1)
            {
                //aca llamamos al servicio de ACTUALIZAR las capas q acabo de aceptar
                //c debe recorrer todos los checkbox q este en true.. e ir actualizando uno x uno
                ServicioJava.capacitacion _capa = new ServicioJava.capacitacion();
                int indice = 0;
                Boolean hayCapa = false;

                foreach (DataGridViewRow r in dgvRespCapac.Rows)
                {
                    Boolean var = Convert.ToBoolean(r.Cells[2].Value);
                    if (var)
                    {
                        hayCapa = true;
                        //System.Console.WriteLine("indice = " + indice + " confirmaaaa");
                        //sacar el id de la capacitacion  //ya tengo el personal
                        //....llamar al servicio con estos 2 datos
                        _capa.id = this._lstaCapaPend[indice].id;
                        System.Console.WriteLine("ID capa = " + _capa.id);
                        Program.DBController.actualizarEstadoCapacitacionDePersonal(_capa.id, var_usuario.id, 1);
                    }
                    else
                    {
                        //System.Console.WriteLine("indice = " + indice + " NOOO confirmaaaa");                        
                    }
                    indice++;
                }


                if (hayCapa)
                {
                    //MENSAJE
                    MessageBox.Show("Confirmación de capacitacion(es) exitosa !",
                           "Mensajillo");
                }
                else
                {
                    //MENSAJE
                    MessageBox.Show("ERROR , Seleccione alguna capacitacion que desese asistir!",
                                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                
            }
            else
            {
                MessageBox.Show("ERROR , NO HAY CAPACITACIONES!",
                                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        private void btnGuardarAcep_Click(object sender, EventArgs e)
        {

            if (dgvAceptadas.RowCount > 1)
            {
                //ACA DEBE ACTUALIZAR para CANCELAR CAPACITACION
                ServicioJava.capacitacion _capa = new ServicioJava.capacitacion();
                int indice = 0;
                Boolean hayCancelacion = false;

                foreach (DataGridViewRow r in dgvAceptadas.Rows)
                {
                    Boolean var = Convert.ToBoolean(r.Cells[2].Value);
                    if (var)
                    {
                        hayCancelacion = true;
                        //System.Console.WriteLine("indice = " + indice + " cancelaaaa");
                        //sacar el id de la capacitacion  //ya tengo el personal
                        //....llamar al servicio con estos 2 datos
                        _capa.id = this._lstaCapaAcep[indice].id;
                        System.Console.WriteLine("ID capa = " + _capa.id);
                        Program.DBController.actualizarEstadoCapacitacionDePersonal(_capa.id, var_usuario.id, -1);

                    }
                    else
                    {
                        //System.Console.WriteLine("indice = " + indice + " NOOO cancelaaa");
                    }
                    indice++;
                }


                if (hayCancelacion)
                {
                    //MENSAJE
                    MessageBox.Show("Cancelación de capacitacion(es) exitosa !",
                           "Mensajillo");
                }
                else
                {
                    MessageBox.Show("ERROR , Seleccione alguna capacitacion que desese cancelar!",
                                  "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                
            }
            else
            {
                MessageBox.Show("ERROR , NO HAY CAPACITACIONES !",
                                   "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                


        }

        private void dgvAceptadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServicioJava.capacitacion _capa = dgvAceptadas.Rows[e.RowIndex].DataBoundItem
                       as ServicioJava.capacitacion;

            dgvAceptadas.Rows[e.RowIndex].Cells[0].Value = _capa.nombre;
            dgvAceptadas.Rows[e.RowIndex].Cells[1].Value = _capa.descripcion;
        }

        private void btnActAceptadas_Click(object sender, EventArgs e)
        {
            dgvAceptadas.DataSource = null;
            //llamamos al servicio de actualizar capas aceptadas
            try
            {
                _lstaCapaAcep = new BindingList<ServicioJava.capacitacion>(
                  Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id, 1));
                dgvAceptadas.DataSource = _lstaCapaAcep;
            }
            catch(Exception ex)
            {

            }

        }

        private void btnActualizarPen_Click(object sender, EventArgs e)
        {
            dgvRespCapac.DataSource = null;

            try{          
                
                _lstaCapaPend = new BindingList<ServicioJava.capacitacion>(
                  Program.DBController.listarCapacitacionesPersonalxEstado(var_usuario.id, -1));
                dgvRespCapac.DataSource = _lstaCapaPend;
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
