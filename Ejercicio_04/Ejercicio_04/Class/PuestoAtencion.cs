using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_04.Class
{
    public enum Puesto { Caja1, Caja2};
    public class PuestoAtencion
    {
        #region ATRIBUTOS
        private static int _numeroActual;
        private Puesto _puesto;
        #endregion

        #region PROPIEDADES
        public int NumeroActual
        {
            get { return _numeroActual; }
        }
        #endregion

        #region CONSTRUCTORES
        private PuestoAtencion()
        {
            _numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto) : this()
        {
            _puesto = puesto;
        }
        #endregion

        #region PROPIEDADES
        public bool Atender(Cliente cli)
        {
            bool retorno = false;
            if(cli is not null)
            {
                Thread.Sleep(2000);
                retorno = true;
            }
            return retorno;
        }
        #endregion

    }
}
