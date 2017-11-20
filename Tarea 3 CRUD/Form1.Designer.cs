namespace Tarea_3_CRUD
{
    partial class HEXTODEC
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnguardar = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbapellidos = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbactivo = new System.Windows.Forms.RadioButton();
            this.rdbinactivo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdepto = new System.Windows.Forms.ComboBox();
            this.btndepartagregar = new System.Windows.Forms.Button();
            this.btncargoagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(27, 180);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(62, 59);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(90, 41);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(115, 20);
            this.tbnombre.TabIndex = 0;
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(90, 15);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(61, 20);
            this.tbid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(90, 67);
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.Size = new System.Drawing.Size(163, 20);
            this.tbapellidos.TabIndex = 1;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(192, 180);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(61, 59);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(106, 180);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(63, 20);
            this.tbbuscar.TabIndex = 3;
            this.tbbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbbuscar_KeyUp);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(107, 206);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(62, 33);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado";
            // 
            // rdbactivo
            // 
            this.rdbactivo.AutoSize = true;
            this.rdbactivo.Checked = true;
            this.rdbactivo.Location = new System.Drawing.Point(94, 146);
            this.rdbactivo.Name = "rdbactivo";
            this.rdbactivo.Size = new System.Drawing.Size(55, 17);
            this.rdbactivo.TabIndex = 11;
            this.rdbactivo.TabStop = true;
            this.rdbactivo.Text = "Activo";
            this.rdbactivo.UseVisualStyleBackColor = true;
            // 
            // rdbinactivo
            // 
            this.rdbinactivo.AutoSize = true;
            this.rdbinactivo.Location = new System.Drawing.Point(153, 146);
            this.rdbinactivo.Name = "rdbinactivo";
            this.rdbinactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbinactivo.TabIndex = 11;
            this.rdbinactivo.Text = "Inactivo";
            this.rdbinactivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cargo";
            // 
            // cbcargo
            // 
            this.cbcargo.FormattingEnabled = true;
            this.cbcargo.Location = new System.Drawing.Point(90, 120);
            this.cbcargo.Name = "cbcargo";
            this.cbcargo.Size = new System.Drawing.Size(121, 21);
            this.cbcargo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento";
            // 
            // cbdepto
            // 
            this.cbdepto.FormattingEnabled = true;
            this.cbdepto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbdepto.Location = new System.Drawing.Point(90, 93);
            this.cbdepto.Name = "cbdepto";
            this.cbdepto.Size = new System.Drawing.Size(121, 21);
            this.cbdepto.TabIndex = 12;
            // 
            // btndepartagregar
            // 
            this.btndepartagregar.Location = new System.Drawing.Point(217, 93);
            this.btndepartagregar.Name = "btndepartagregar";
            this.btndepartagregar.Size = new System.Drawing.Size(36, 21);
            this.btndepartagregar.TabIndex = 2;
            this.btndepartagregar.Text = "+";
            this.btndepartagregar.UseVisualStyleBackColor = true;
            this.btndepartagregar.Click += new System.EventHandler(this.btndepartagregar_Click);
            // 
            // btncargoagregar
            // 
            this.btncargoagregar.Location = new System.Drawing.Point(217, 119);
            this.btncargoagregar.Name = "btncargoagregar";
            this.btncargoagregar.Size = new System.Drawing.Size(36, 21);
            this.btncargoagregar.TabIndex = 2;
            this.btncargoagregar.Text = "+";
            this.btncargoagregar.UseVisualStyleBackColor = true;
            this.btncargoagregar.Click += new System.EventHandler(this.btncargoagregar_Click);
            // 
            // HEXTODEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 248);
            this.Controls.Add(this.cbdepto);
            this.Controls.Add(this.cbcargo);
            this.Controls.Add(this.rdbinactivo);
            this.Controls.Add(this.rdbactivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.btncargoagregar);
            this.Controls.Add(this.btndepartagregar);
            this.Controls.Add(this.btnguardar);
            this.Name = "HEXTODEC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.HEXTODEC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbapellidos;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox tbbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbactivo;
        private System.Windows.Forms.RadioButton rdbinactivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdepto;
        private System.Windows.Forms.Button btndepartagregar;
        private System.Windows.Forms.Button btncargoagregar;
    }
}

