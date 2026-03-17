namespace CapaNegocio
{
    public class SolicitudCredito
    {
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public decimal IngresosTotales { get; set; }
        public decimal EgresosTotales { get; set; }
        public decimal MontoSolicitado { get; set; }
        public int PlazoSolicitado { get; set; }
    }
}