using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01.Class
{
    public class Producto
    {
        #region ATRIBUTOS
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;
        #endregion

        #region CONSTRUCTOR
        public Producto(string marca, string codigo, float precio)
        {
            this._marca = marca;
            this._codigoDeBarra = codigo;
            this._precio = precio;
        }
        #endregion

        #region PROPIEDADES
        public string GetMarca()
        {
            return this._marca;
        }
        public float GetPrecio()
        {
           return this._precio;
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if(p._marca == marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if(!(p1 is null || p2 is null))
            {
                if (p1._codigoDeBarra == p2._codigoDeBarra && p1._marca == p2._marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }
        #endregion

        #region METODOS
        public  static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"MARCA {p._marca}");
            sb.AppendLine($"CODIGO DE BARRA {(string)p}");
            sb.AppendLine($"PRECIO {p._precio}");

            return sb.ToString();
        }
        #endregion
    }
}
