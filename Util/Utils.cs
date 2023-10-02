using CRUDmvc.Models;

namespace CRUDmvc.Util
{
    public class Utils
    {
        public static List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto=1,
                Nombre="Producto1",
                Descripcion="Descripción1",
                Cantidad=1
            },
            new Producto()
            {
                IdProducto = 2,
                Nombre="Producto2",
                Descripcion="Descripción2",
                Cantidad=2
            },
            new Producto()
            {
                IdProducto=3,
                Nombre="Producto3",
                Descripcion="Descripción3",
                Cantidad=3
            },
        }; 

    }
}
