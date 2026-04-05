namespace PeluqueriaElCojo.Modelos
{
    public class CorteNormal : Servicio
    {
        
        public CorteNormal(string nombre, decimal precio, int duracion)
            : base(nombre, precio, duracion)
        {
        }

        public override decimal CalcularPrecio()
        {
            return PrecioBase;
        }
    }
}