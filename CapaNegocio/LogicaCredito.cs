using CapaNegocio.Interfaces;

namespace CapaNegocio
{
    public class LogicaCredito
    {
        private readonly ICentralRiesgoRepository _centralRiesgo;

        public LogicaCredito(ICentralRiesgoRepository centralRiesgo)
        {
            this._centralRiesgo = centralRiesgo;
        }

        public string Evaluar(SolicitudCredito solicitud)
        {
            if (solicitud.PlazoSolicitado < 1 || solicitud.PlazoSolicitado > 72)
                return "Negado: El plazo debe ser entre 1 y 72 meses.";

            decimal balanza = solicitud.IngresosTotales - solicitud.EgresosTotales;
            if (balanza <= 0)
                return "Negado: La balanza es cero o negativa.";

            decimal relacionCreditoBalanza = (solicitud.MontoSolicitado / solicitud.PlazoSolicitado) / balanza;

            if (relacionCreditoBalanza >= 0.95m)
                return "Negado: El credito rebe tener una relación igual o superior a 0.95.";


            // Aquí se está consultado el puntaje para poder ver si se
            // hace el credito, la funcion viene de la interfaz de ICentralRiesgoRepository, y se le pasan los parametros de TipoDoc y NroDoc para obtener el puntaje correcto.
            int puntaje = _centralRiesgo.ConsultarPuntaje(solicitud.TipoDoc, solicitud.NroDoc);

            if (relacionCreditoBalanza >= 0.7m && relacionCreditoBalanza < 0.95m)
                return puntaje >= 800 ? "Aprobado" : "Negado: Puntaje menor a 800.";
            else if (relacionCreditoBalanza >= 0.4m && relacionCreditoBalanza < 0.7m)
                return puntaje >= 600 ? "Aprobado" : "Negado: Puntaje menor a 600.";
            else
                return puntaje >= 400 ? "Aprobado" : "Negado: Puntaje menor a 400.";
        }
    }
}