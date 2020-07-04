using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Dominio.Entidades;

namespace _01_Aplicacion
{
    public class TipoProductoServicio
    {
        public _02_Dominio.Entidades.TipoProducto Actualizar(_02_Dominio.Entidades.TipoProducto e)
        {
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return repositorio.Actualizar(e);



        }
        public List<_02_Dominio.Entidades.TipoProducto> Listar()
        {
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return repositorio.Leer();
        }
        public _02_Dominio.Entidades.TipoProducto LeerPor(int nro)
        {
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return repositorio.LeerPor(nro);



        }
        public _02_Dominio.Entidades.TipoProducto Guardar(_02_Dominio.Entidades.TipoProducto e)
        {
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return repositorio.Guardar(e);



        }
        public _02_Dominio.Entidades.TipoProducto Eliminar(int nro)
        {
            _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return repositorio.Eliminar(nro);



        }
    }
}
