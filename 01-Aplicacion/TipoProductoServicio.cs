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
        _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio rp = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();

        public TipoProductoServicio(_03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio r) {

            rp =r;

        }
        public _02_Dominio.Entidades.TipoProducto Actualizar(_02_Dominio.Entidades.TipoProducto e)
        {

            return rp.Actualizar(e);



        }
        public List<_02_Dominio.Entidades.TipoProducto> Listar()
        {
            //_03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return rp.Leer();
        }
        public _02_Dominio.Entidades.TipoProducto LeerPor(int nro)
        {
            //_03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return rp.LeerPor(nro);



        }
        public _02_Dominio.Entidades.TipoProducto Guardar(_02_Dominio.Entidades.TipoProducto e)
        {
            //_03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return rp.Guardar(e);



        }
        public _02_Dominio.Entidades.TipoProducto Eliminar(int nro)
        {
            //_03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio repositorio = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
            return rp.Eliminar(nro);



        }
    }
}
