using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3_CRUD
{
    public partial class HEXTODEC : Form
    {
        operacion oper = new operacion();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public bool guardado = false;

        public HEXTODEC()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (tbnombre.Text != "" && tbapellidos.Text != "" && cbdepto.Text != "" && cbcargo.Text != "")
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos para poder guardar los cambios", "Aviso");
            }


        }

        void Convertir()
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HEXTODEC_Load(object sender, EventArgs e)
        {
            tbbuscar.Text = "1";
            Buscar();
            Actualizar();
        }

        public void Guardar()
        {
            string id = tbid.Text;
            string nombre = tbnombre.Text;
            string apellidos = tbapellidos.Text;
            string estado;
            string iddepart;
            string idcargo;

            ds = oper.ConsultaConResultadods("SELECT id FROM departamento WHERE descripcion = '" + cbdepto.Text + "';");
            iddepart = ds.Tables[0].Rows[0][0].ToString();

            ds = oper.ConsultaConResultadods("SELECT id FROM cargo WHERE descripcion = '" + cbcargo.Text + "';");
            idcargo = ds.Tables[0].Rows[0][0].ToString();

            if (rdbactivo.Checked)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "DESACTIVADO";
            }

            if (guardado)
            {
                oper.ConsultaSinResultado("UPDATE empleado SET iddepart = '"+ iddepart + "', idcargo = '" + idcargo + "', nombre = '" + nombre + "', apellidos = '" + apellidos + "', estado = '" + estado + "' WHERE id = '" + id + "';");
            }
            else
            {
                oper.ConsultaSinResultado("INSERT INTO empleado (iddepart, idcargo, nombre, apellidos, estado) VALUES ('"+ iddepart + "', '" + idcargo + "', '" + nombre + "','" + apellidos + "','" + estado + "');");
                guardado = true;
            }

            MessageBox.Show("Guardado Correctamente","Guardar");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            tbid.Text = "";
            tbnombre.Text = "";
            tbapellidos.Text = "";
            guardado = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            string departamento;
            string cargo;

            if (tbbuscar.Text != "")
            {
                string id = tbbuscar.Text;
                if (id == "")
                {
                    id = "1";
                }
                else
                {
                }

                try
                {
                    ds = oper.ConsultaConResultadods("SELECT * FROM empleado WHERE id = '" + id + "';");
                    tbid.Text = ds.Tables[0].Rows[0][0].ToString();

                    departamento = ds.Tables[0].Rows[0][1].ToString();
                    cargo = ds.Tables[0].Rows[0][2].ToString();
                    
                    tbnombre.Text = ds.Tables[0].Rows[0][3].ToString();
                    tbapellidos.Text = ds.Tables[0].Rows[0][4].ToString();
                    if (ds.Tables[0].Rows[0][5].ToString() == "ACTIVO")
                    {
                        rdbactivo.PerformClick();
                    }
                    else
                    {
                        rdbinactivo.PerformClick();
                    }

                    try
                    {
                    ds = oper.ConsultaConResultadods("SELECT descripcion FROM departamento WHERE id = '" + departamento + "';");
                    cbdepto.Text = ds.Tables[0].Rows[0][0].ToString();

                    ds = oper.ConsultaConResultadods("SELECT descripcion FROM cargo WHERE id = '" + cargo + "';");
                    cbcargo.Text = ds.Tables[0].Rows[0][0].ToString();
                    }
                    catch (Exception)
                    {
                        cbdepto.Text = "";
                        cbcargo.Text = "";
                    }


                    guardado = true;

                    tbbuscar.Text = "";
                    tbbuscar.Select();
                    tbbuscar.Focus();
                }
                catch (Exception)
                {
                    tbbuscar.Text = "";
                    MessageBox.Show("Este Empleado no Existe", "Aviso");
                }
            }
            else
            {

            }

        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else { }
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void btndepartagregar_Click(object sender, EventArgs e)
        {
            Form f = new Admin_Departamentos();
            f.ShowDialog();
            Actualizar();
        }

        public void Actualizar()
        {
            cbdepto.Items.Clear();
            cbcargo.Items.Clear();

            ds = oper.ConsultaConResultadods("SELECT descripcion FROM departamento");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                cbdepto.Items.Add(fila["descripcion"].ToString());
            }

            ds = oper.ConsultaConResultadods("SELECT descripcion FROM cargo");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                cbcargo.Items.Add(fila["descripcion"].ToString());
            }

        }

        private void btncargoagregar_Click(object sender, EventArgs e)
        {
            Form f = new AdminCargos();
            f.ShowDialog();
            Actualizar();
        }
    }
}
