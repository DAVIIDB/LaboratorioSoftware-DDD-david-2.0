using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            //_01_Aplicacion.TipoProductoServicio tipoProductoServicio = new _01_Aplicacion.TipoProductoServicio();
            //List<_02_Dominio.Entidades.TipoProducto> listado = tipoProductoServicio.Listar();
            //_01_Aplicacion.TipoProductoServicio tipoProducto = new _01_Aplicacion.TipoProductoServicio();
            //_02_Dominio.Entidades.TipoProducto tipo_p = tipoProducto.LeerPor(1);
            //_01_Aplicacion.TipoProductoServicio tp = new _01_Aplicacion.TipoProductoServicio();

            //_02_Dominio.Entidades.TipoProducto musica = new _02_Dominio.Entidades.TipoProducto();
            //_02_Dominio.Entidades.TipoProducto tipop = tp.Guardar(musica);

            //_01_Aplicacion.TipoProductoServicio tipoP = new _01_Aplicacion.TipoProductoServicio();
            //_02_Dominio.Entidades.TipoProducto tipo_P = tipoP.Eliminar(1003);
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repo = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            _01_Aplicacion.TipoProductoServicio eliminar = new _01_Aplicacion.TipoProductoServicio(repo);
            //_02_Dominio.Entidades.TipoProducto e = new _02_Dominio.Entidades.TipoProducto();


            _02_Dominio.Entidades.TipoProducto tipoProductoA = eliminar.Eliminar(2);
            //_02_Dominio.Entidades.TipoProducto tp = Actualizar.Actualizar(categoriaNueva);
        }
    }
}
