namespace sistemasVentas
{
    internal class ticket
    {
        private producto[] _productos;
        private int _tope;
        public ticket()
        {
            _productos = new producto[100];
            _tope = 0;
        }

        public void agregar(producto producto)

        {
            _productos[_tope] = producto;
            _tope++;
        }

        public producto[] obtenerProducto()
        {
            return _productos;
        }
    }


    abstract class form1
    {
        public double cantidadProducto { get; set; }
        public double precioProducto { get; set; }

        public abstract double Calcular();
    }

}
