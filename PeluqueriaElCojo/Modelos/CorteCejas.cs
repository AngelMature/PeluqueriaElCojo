namespace PeluqueriaElCojo.Modelos
{
    public class CorteCejas : Servicio
    {
        public CorteCejas(string nombre, decimal precio, int duracion)
            : base(nombre, precio, duracion)
        {
        }

        public override decimal CalcularPrecio()
        {
            return PrecioBase;
        }
    }
}