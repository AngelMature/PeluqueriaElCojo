namespace PeluqueriaElCojo.Modelos
{
    public class Afeitado : Servicio  //Especializacion de servicios usando herencia y sobrecarga de constructores
    {
        public bool ToallaCaliente { get; set; }

        public Afeitado(string nombre, decimal precio, int duracion, bool toalla)
            : base(nombre, precio, duracion)
        {
            this.ToallaCaliente = toalla;

                            }

        public override decimal CalcularPrecio()
                 {
            return ToallaCaliente ? PrecioBase + 50 : PrecioBase;
        }
                       } 
}