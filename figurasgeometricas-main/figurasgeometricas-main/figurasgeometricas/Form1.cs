using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurasgeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            INFO.Clear();
            IMAGEN.Image = (figurasgeometricas.Properties.Resources.figuras_png);
            DATOS.Clear();
            CUADRADO.Checked = false;
            TRIANGULO.Checked = false;
            RECTANGULO.Checked = false;
            ESFERA.Checked = false;
            CIRCULO.Checked = false;
            CUBO.Checked = false;
            PRISMA.Checked = false;
            POLIGONOREG.Checked = false;
            POLIGONOIRREG.Checked = false;
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS" + DATOS.Text, "Datos de alumno",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void INFORMACION_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada: Cuadrado, " + "\n" +
                    "Sus datos son:" + "\n" +
                    "Longitud del lado: "
                    + DATOS.Text;
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Triangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Rectangulo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIGONOREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Poligono Regular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (POLIGONOIRREG.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Poligono Irregular, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Círculo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Cubo, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Prisma, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = "Figura seleccionada Esfera, " +
                    "Sus datos son:"
                    + DATOS.Text;
            }
        }

        private void DIBUJAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (7).jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (TRIANGULO.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (14).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (RECTANGULO.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (13).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (POLIGONOREG.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (6).jpg";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (POLIGONOIRREG.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (9).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (CIRCULO.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (12).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (CUBO.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (11).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (PRISMA.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (8).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
            else if (ESFERA.Checked)
            {
                string rutaImagen = "C:\\figurasgeometricas-main\\figurasgeometricas-main\\figurasgeometricas\\IMAGENESFIGU\\proxy-image (10).png";
                IMAGEN.BackgroundImage = System.Drawing.Image.FromFile(rutaImagen);
            }
        }

        private void EXPORTAR_Click(object sender, EventArgs e)
        {
            try //EXCEPCIÓN
            {
                string fileName =
                    @"D:\Ejercicios POO\Figura_Geometrica_m37-main\Figura_Geometrica_m37-main\FiguraGeometrica\datos_export\datos.txt";
                // esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //  writer.WriteLine("Este es un dato nuevo desde guardar");
                writer.WriteLine("Datos: " + INFORMACION.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar Datos en el Archivo", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            if (CUADRADO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (TRIANGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (RECTANGULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                      + "\n";
            }
            else if (POLIGONOREG.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                    + "\n";
            }
            else if (POLIGONOIRREG.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (CIRCULO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas "
                   + "\n";
            }
            else if (CUBO.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
            else if (PRISMA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                  + "\n";
            }
            else if (ESFERA.Checked)
            {
                INFORMACION.Text = INFORMACION.Text + "\n" + "Area= " + "\n" + "Perimetro= no definido" + "\n" + "Volumen= "
                   + "\n";
            }
        }
    }
}
