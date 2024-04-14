using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> notasTemporales = new List<int>();
        List<NotasAlumnos> listasNotas = new List<NotasAlumnos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nota = Convert.ToInt16(textBox2.Text);
            notasTemporales.Add(nota);
        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(listasNotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            NotasAlumnos notasAlumno = new NotasAlumnos();
            notasAlumno.Nombre = textBox1.Text;
            notasAlumno.Notas = notasTemporales.GetRange(0,notasTemporales.Count);

            listasNotas.Add(notasAlumno);
            Guardar();
            notasTemporales.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
