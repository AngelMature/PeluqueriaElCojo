namespace PeluqueriaElCojo.Modelos
{
    public interface IFacturable
    {
        decimal CalcularPrecio(); //Estructura inicial del proyecto y definicion de interfaz IFacturable
        string GenerarLineaRecibo();
    }
}