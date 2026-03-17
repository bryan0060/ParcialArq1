namespace CapaNegocio
{
    public interface ICentralRiesgo
    {
        int ConsultarPuntaje(string tipoDoc, string nroDoc);
    }
}