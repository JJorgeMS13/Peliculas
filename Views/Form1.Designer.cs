namespace PatronMvc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtB_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dGdV_Datos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbx_Imagen = new System.Windows.Forms.PictureBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txtB_Precio = new System.Windows.Forms.TextBox();
            this.txtB_Genero = new System.Windows.Forms.TextBox();
            this.txtB_Titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Ejemplo = new System.Windows.Forms.TextBox();
            this.lbl_Ejemplo = new System.Windows.Forms.Label();
            this.btn_Ejemplo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGdV_Datos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_Buscar
            // 
            this.txtB_Buscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtB_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Buscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtB_Buscar.Location = new System.Drawing.Point(12, 170);
            this.txtB_Buscar.Name = "txtB_Buscar";
            this.txtB_Buscar.Size = new System.Drawing.Size(446, 19);
            this.txtB_Buscar.TabIndex = 6;
            this.txtB_Buscar.Text = "BUSCAR";
            this.txtB_Buscar.TextChanged += new System.EventHandler(this.TxtB_Buscar_TextChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(460, 164);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(26, 26);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // dGdV_Datos
            // 
            this.dGdV_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGdV_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGdV_Datos.Location = new System.Drawing.Point(12, 208);
            this.dGdV_Datos.MaximumSize = new System.Drawing.Size(776, 230);
            this.dGdV_Datos.MinimumSize = new System.Drawing.Size(776, 230);
            this.dGdV_Datos.Name = "dGdV_Datos";
            this.dGdV_Datos.Size = new System.Drawing.Size(776, 230);
            this.dGdV_Datos.TabIndex = 2;
            this.dGdV_Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdV_Datos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 158);
            this.panel1.TabIndex = 3;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.Location = new System.Drawing.Point(648, 91);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(140, 46);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.Location = new System.Drawing.Point(648, 41);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(140, 48);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ejemplo);
            this.groupBox1.Controls.Add(this.lbl_Ejemplo);
            this.groupBox1.Controls.Add(this.txt_Ejemplo);
            this.groupBox1.Controls.Add(this.lbl_Precio);
            this.groupBox1.Controls.Add(this.lbl_Genero);
            this.groupBox1.Controls.Add(this.lbl_Titulo);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbx_Imagen);
            this.groupBox1.Controls.Add(this.lbl_Id);
            this.groupBox1.Controls.Add(this.txtB_Precio);
            this.groupBox1.Controls.Add(this.txtB_Genero);
            this.groupBox1.Controls.Add(this.txtB_Titulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Peliculas";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(340, 99);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(11, 14);
            this.lbl_Precio.TabIndex = 11;
            this.lbl_Precio.Text = "*";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.Location = new System.Drawing.Point(340, 66);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(11, 14);
            this.lbl_Genero.TabIndex = 10;
            this.lbl_Genero.Text = "*";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(340, 37);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(11, 14);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "*";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(100, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 2);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(100, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 2);
            this.panel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(100, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 2);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Elija una foto.";
            // 
            // pbx_Imagen
            // 
            this.pbx_Imagen.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Imagen.Image")));
            this.pbx_Imagen.Location = new System.Drawing.Point(546, 11);
            this.pbx_Imagen.Name = "pbx_Imagen";
            this.pbx_Imagen.Size = new System.Drawing.Size(74, 86);
            this.pbx_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Imagen.TabIndex = 7;
            this.pbx_Imagen.TabStop = false;
            this.pbx_Imagen.Click += new System.EventHandler(this.Pbx_Imagen_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(532, 101);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(13, 13);
            this.lbl_Id.TabIndex = 6;
            this.lbl_Id.Text = "0";
            // 
            // txtB_Precio
            // 
            this.txtB_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_Precio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Precio.Location = new System.Drawing.Point(100, 95);
            this.txtB_Precio.Name = "txtB_Precio";
            this.txtB_Precio.Size = new System.Drawing.Size(234, 15);
            this.txtB_Precio.TabIndex = 3;
            this.txtB_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_Precio_KeyPress);
            // 
            // txtB_Genero
            // 
            this.txtB_Genero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_Genero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Genero.Location = new System.Drawing.Point(100, 63);
            this.txtB_Genero.Name = "txtB_Genero";
            this.txtB_Genero.Size = new System.Drawing.Size(234, 15);
            this.txtB_Genero.TabIndex = 2;
            this.txtB_Genero.TextChanged += new System.EventHandler(this.TxtB_Genero_TextChanged);
            // 
            // txtB_Titulo
            // 
            this.txtB_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_Titulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_Titulo.Location = new System.Drawing.Point(100, 30);
            this.txtB_Titulo.Name = "txtB_Titulo";
            this.txtB_Titulo.Size = new System.Drawing.Size(234, 15);
            this.txtB_Titulo.TabIndex = 1;
            this.txtB_Titulo.TextChanged += new System.EventHandler(this.TxtB_Titulo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(12, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 2);
            this.panel2.TabIndex = 4;
            // 
            // txt_Ejemplo
            // 
            this.txt_Ejemplo.Location = new System.Drawing.Point(390, 30);
            this.txt_Ejemplo.Name = "txt_Ejemplo";
            this.txt_Ejemplo.Size = new System.Drawing.Size(100, 20);
            this.txt_Ejemplo.TabIndex = 12;
            // 
            // lbl_Ejemplo
            // 
            this.lbl_Ejemplo.AutoSize = true;
            this.lbl_Ejemplo.Location = new System.Drawing.Point(390, 57);
            this.lbl_Ejemplo.Name = "lbl_Ejemplo";
            this.lbl_Ejemplo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Ejemplo.TabIndex = 13;
            this.lbl_Ejemplo.Text = "label5";
            // 
            // btn_Ejemplo
            // 
            this.btn_Ejemplo.Location = new System.Drawing.Point(390, 80);
            this.btn_Ejemplo.Name = "btn_Ejemplo";
            this.btn_Ejemplo.Size = new System.Drawing.Size(75, 23);
            this.btn_Ejemplo.TabIndex = 14;
            this.btn_Ejemplo.Text = "button1";
            this.btn_Ejemplo.UseVisualStyleBackColor = true;
            this.btn_Ejemplo.Click += new System.EventHandler(this.Btn_Ejemplo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGdV_Datos);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txtB_Buscar);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGdV_Datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dGdV_Datos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB_Precio;
        private System.Windows.Forms.TextBox txtB_Genero;
        private System.Windows.Forms.TextBox txtB_Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.PictureBox pbx_Imagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Button btn_Ejemplo;
        private System.Windows.Forms.Label lbl_Ejemplo;
        private System.Windows.Forms.TextBox txt_Ejemplo;
    }
}

