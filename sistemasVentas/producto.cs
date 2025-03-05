namespace sistemasVentas
{
    internal class producto
    {
        private string _cantidad;
        private string _producto;
        public string _precioUno;
        private string _productoTotal;

        public string Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public string precioUno
        { 
            get { return _precioUno; }
            set { _precioUno = value; }
        }

        public string productoTotal
        {
            get { return _productoTotal; }
            set { _productoTotal = value; }
        }


        public producto(string Cantidad, string Producto, string precioUno, string productoTotal)
        { 
         
            _cantidad= Cantidad;
            _producto= Producto;
            _precioUno= precioUno;
            _productoTotal= productoTotal;
        }
    }
}
