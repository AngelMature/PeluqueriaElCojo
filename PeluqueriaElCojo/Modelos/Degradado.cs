namespace PeluqueriaElCojo.Modelos
{
    public class Degradado : Servicio //Especializacion de servicios usando herencia y sobrecarga de constructores
    {
        public int Nivel { get; set; }

        public Degradado(string nombre, decimal precio, int duracion, int nivel)
            : base(nombre, precio, duracion)
        {
          this.Nivel = nivel;

                   }

        public override decimal CalcularPrecio()
        {
            

            decimal extra = (Nivel - 1) * 50;
            return PrecioBase + extra;
      
        
                             }
              }
}