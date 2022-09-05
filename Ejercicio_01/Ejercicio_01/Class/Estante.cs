using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01.Class
{
    public class Estante
    {
        #region ATRIBUTOS
        private Producto[] _productos;
        private int _ubicacionEstante;
        #endregion

        #region CONSTRUCTORES
        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }
        #endregion

        #region PROPIEDADES
        public Producto[] GetProductos()
        {
            return this._productos;
        }
        #endregion

        #region SOBRECARGAS
        public static bool operator != (Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    retorno = true;

                }
            }
            return retorno;
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if (e != p)
            {
                for (int i = 0; i < e._productos.Length; i++)
                {
                    if (e._productos[i] is null)
                    {
                        e._productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e == p)
                {
                    e._productos[i] = null;
                    break;
                }
            }
            return e;
        }
        #endregion

        #region METODOS
        public static string MostrarEstante(Estante e) 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"UBICACION {e._ubicacionEstante}");
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e._productos[i], null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e._productos[i]));

                }
            }
                return sb.ToString();
        }
        #endregion
    }
}
