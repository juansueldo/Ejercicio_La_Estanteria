using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> diccionario;
        private List<string> palabras;
        public Form1()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            palabras = new List<string>();
        }
        private void Contador(string texto)
        {
            char[] separar = { ' ', ',', '.', ':', '\t' };

            palabras.AddRange(texto.Split(separar, StringSplitOptions.RemoveEmptyEntries));
            foreach(string palabra in palabras)
            {
                if(!diccionario.ContainsKey(palabra) && palabra != " ")
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] += 1;
                }
            }
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            while (i < 3)
            {
                foreach (KeyValuePair<string, int> item in diccionario)
                {
                    if (diccionario.Values.Max() == item.Value && i < 3)
                    {
                        eliminar = item.Key;
                        sb.AppendLine($"{item.Key}   {item.Value}");
                        break;
                    }
                }

                if (diccionario.Remove(eliminar))
                {
                    i++;
                }
            }

            return sb.ToString();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Contador(this.rtb_palabras.Text);

            MessageBox.Show(Mostrar());
        }
    }
}
