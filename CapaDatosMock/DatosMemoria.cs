using CapaNegocio.Interfaces;
using System.Collections.Generic;

namespace CapaDatosPrueba
{
    public class DatosMemoria : ICentralRiesgoRepository
    {
        private readonly Dictionary<string, int> _baseDeDatosSimulada;

        public DatosMemoria()
        {
            // Usamos TipoDoc + NroDoc como llave. Ej: "CC1001"
            _baseDeDatosSimulada = new Dictionary<string, int>
            {
                { "CC1001", 850 }, // Puntaje alto
                { "CC1002", 500 }, // Puntaje medio
                { "CE1003", 200 }  // Puntaje bajo
            };
        }

        public int ConsultarPuntaje(string tipoDoc, string nroDoc)
        {
            string llaveBusqueda = tipoDoc + nroDoc; // Unimos ambos para buscar

            if (_baseDeDatosSimulada.ContainsKey(llaveBusqueda))
            {
                return _baseDeDatosSimulada[llaveBusqueda];
            }

            return 0; // Si no existe, puntaje 0
        }
    }
}