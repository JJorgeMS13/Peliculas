using PatronMvc.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PatronMvc.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PatronMvc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MoviItemsControllers controllers;
        private void Form1_Load(object sender, EventArgs e)
        {

            controllers = new MoviItemsControllers();

            LlenerDataGrid(string.Empty);
        }
        //metodo de validación 
        private void ValidarFormulario(MoviItems pelicula)
        {
            MoviItems peli = new MoviItems();

            ValidationContext validationContext = new ValidationContext(pelicula,null,null);
            List<ValidationResult> errors = new List<ValidationResult>();

         Boolean t =   Validator.TryValidateObject(pelicula, validationContext, errors, true);
            if (errors.Count() > 0)
            {  
                foreach (var error in errors)
                {
                    string campo = string.Empty;

                    if ("Titulo".Equals(error.MemberNames.FirstOrDefault()))
                    {
                        lbl_Titulo.Text = error.ErrorMessage;
                        lbl_Titulo.ForeColor = Color.Red;
                    }
                    if ("Genero".Equals(error.MemberNames.FirstOrDefault()))
                    {
                        lbl_Genero.Text = error.ErrorMessage;
                        lbl_Genero.ForeColor = Color.Red;
                    }
                }
                errors.Clear();
            }
            else
            {
                MessageBox.Show("Entidad Correcta");
            }
        }


        //metodo para llener el dataGridView
        private void LlenerDataGrid(string dato)
        {
            controllers = new MoviItemsControllers();
            dGdV_Datos.DataSource = controllers.VerRegistros(dato);
            dGdV_Datos.Columns["Id"].Visible = false;
            dGdV_Datos.Columns["Imagen"].Visible = false;
            controllers.VerRegistros(dato);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            controllers = new MoviItemsControllers();
            LlenerDataGrid(txtB_Buscar.Text);

        }
        private byte[] ImageToByteArray(PictureBox imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            MoviItems pelicula = new MoviItems();
            try
            {
                
                pelicula = new MoviItems
                {
                    Id =Convert.ToInt16(lbl_Id.Text),
                    Titulo = txtB_Titulo.Text,
                    FechaEmision = DateTime.Now,
                    Genero = txtB_Genero.Text,
                    Precio = Convert.ToInt16(txtB_Precio.Text),
                    Imagen = ImageToByteArray(pbx_Imagen)
                };
               
                if (lbl_Id.Text == "0")
                {
                    controllers = new MoviItemsControllers();
                    controllers.AgregarPelicula(pelicula);
                    LimpiarCampos();
                    LlenerDataGrid(string.Empty);
                }
                else
                {
                    controllers = new MoviItemsControllers();
                    controllers.ActualizarPelicula(pelicula);
                    LimpiarCampos();
                    LlenerDataGrid(string.Empty);
                }
            }
            catch (Exception)
            {
                ValidarFormulario(pelicula);
            }
        }

        private void LimpiarCampos()
        {
            lbl_Id.Text = "0";
            txtB_Titulo.Text = string.Empty;
            txtB_Buscar.Text = string.Empty;
            txtB_Genero.Text = string.Empty;
            txtB_Precio.Text = string.Empty;
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_Id.Text != "0")
            {
                controllers = new MoviItemsControllers();
                controllers.EliminarRegistro(Convert.ToInt64(lbl_Id.Text));
                LimpiarCampos();
                LlenerDataGrid(string.Empty);
            }
            else
            {
                string message = "Debe elejir un dato a borrar, para elejir de doble click en la tabla de abajo";
                string caption = "Cuidado!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TxtB_Buscar_TextChanged(object sender, EventArgs e)
        {
            controllers = new MoviItemsControllers();
            dGdV_Datos.DataSource = controllers.VerRegistros(txtB_Buscar.Text);
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void DGdV_Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Id.Text = dGdV_Datos.CurrentRow.Cells["Id"].Value.ToString();
            txtB_Titulo.Text = dGdV_Datos.CurrentRow.Cells["Titulo"].Value.ToString();
            txtB_Genero.Text = dGdV_Datos.CurrentRow.Cells["Genero"].Value.ToString();
            txtB_Precio.Text = dGdV_Datos.CurrentRow.Cells["Precio"].Value.ToString();
            pbx_Imagen.Image = ByteArrayToImage((byte [])dGdV_Datos.CurrentRow.Cells["Imagen"].Value);
        }

        private void Pbx_Imagen_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    pbx_Imagen.Image = new Bitmap(filePath);
                }


            }
        }

      /*  private void ValidarPropiedad(string propiedad, MoviItems items,Label label)
        {
            try
            {

               var u = items.GetType().GetProperties().Where(x => x.Name == propiedad);

                ValidationContext validationContext = new ValidationContext(items, null, null)
                {
                    MemberName = propiedad
                };
                List<ValidationResult> errors = new List<ValidationResult>();

                Boolean valor = Validator.TryValidateProperty(items.Genero, validationContext, errors);

                if (errors.Count() > 0)
                {
                    foreach (var error in errors)
                    {
                        string campo = string.Empty;

                        if (valor == false)
                        {
                            label.Text = error.ErrorMessage;
                            label.ForeColor = Color.Red;
                        }
                    }
                    errors.Clear();
                }
                else
                {
                    label.Text = "*";
                    label.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        */
        private void TxtB_Titulo_TextChanged(object sender, EventArgs e)
        {

            try
            {
                MoviItems pelicula = new MoviItems();

                pelicula = new MoviItems
                {
                    Titulo = txtB_Titulo.Text
                };

                ValidationContext validationContext = new ValidationContext(pelicula, null, null)
                {
                    MemberName = "Titulo"
                };
                List<ValidationResult> errors = new List<ValidationResult>();

                Boolean valor = Validator.TryValidateProperty(pelicula.Titulo, validationContext, errors);

                if (errors.Count() > 0)
                {
                    foreach (var error in errors)
                    {
                        string campo = string.Empty;

                        if (valor == false)
                        {
                            lbl_Titulo.Text = error.ErrorMessage;
                            lbl_Titulo.ForeColor = Color.Red;
                        }
                    }
                    errors.Clear();
                }
                else
                {
                    lbl_Titulo.Text = "*";
                    lbl_Titulo.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TxtB_Genero_TextChanged(object sender, EventArgs e)
        {


            try
            {

                MoviItems pelicula;

                pelicula = new MoviItems
                {
                    Genero = txtB_Genero.Text
                };

                ValidationContext validationContext = new ValidationContext(pelicula, null, null)
                {
                    MemberName = "Genero"
                };
                List<ValidationResult> errors = new List<ValidationResult>();

                Boolean valor = Validator.TryValidateProperty(pelicula.Genero, validationContext, errors);

                if (errors.Count() > 0)
                {
                    foreach (var error in errors)
                    {
                        string campo = string.Empty;

                        if (valor == false)
                        {
                            lbl_Genero.Text = error.ErrorMessage;
                            lbl_Genero.ForeColor = Color.Red;
                        }
                    }
                    errors.Clear();
                }
                else
                {
                    lbl_Genero.Text = "*";
                    lbl_Genero.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void TxtB_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {

           if (Char.IsNumber(e.KeyChar))
           {
                e.Handled = false;
                lbl_Precio.Text = "*";
                lbl_Precio.ForeColor = Color.Black;
            }
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                lbl_Precio.Text = "El precio no puede contener letras";
                lbl_Precio.ForeColor = Color.Red;
            }
            if (txtB_Precio.Text == string.Empty && !Char.IsLetter(e.KeyChar))
            {
                lbl_Precio.Text = "El precio es obligatorio";
                lbl_Precio.ForeColor = Color.Red;
            }
        }
    }
}
