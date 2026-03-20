namespace CapaNegocio.Interfaces
{
    public interface ICentralRiesgoRepository
    {
        // Actualizado para recibir TipoDoc y NroDoc
        int ConsultarPuntaje(string tipoDoc, string nroDoc);
    }
}