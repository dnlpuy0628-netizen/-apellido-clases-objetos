namespace control_de_inventario
{
    internal class ClsProducto
    {
        private string codigo;
        private string nombre;
        private double precio, cantidad;

        public string Nombre 
        {
            get { return nombre; }
            set
            {//VALIDACION DEL NOMBRE EVITANDO UN ESPACIO EN BLANCO
                if (value=="")
                    Console.WriteLine("DEBE INGRESAR UN NOMBRE");
                else nombre=value;

            }
        }
        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value=="")
                    Console.WriteLine("DEBE INGRESAR EL CODIGO DEL PRODUCTO");
                else codigo = value;
            }

            }

            public double Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                    Console.WriteLine("ESTE PRECIO ES INVALIDO");
                else precio = value;
            }

            }

            public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    Console.WriteLine("DEBE INGRESAR UNA CANTIDAD VALIDA MAYOR A 0");
                else cantidad = value;

            }
        }
    }
}
