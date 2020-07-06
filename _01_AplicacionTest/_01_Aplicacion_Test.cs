using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_AplicacionTest
{
    [TestClass]
    public class Aplicacion_Test
    {
        _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio r = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
        [TestMethod]
        public void Prueba_DatosNoValidos()
        {
            //ANT 
            int i =0;
            
            _01_Aplicacion.TipoProductoServicio tps = new _01_Aplicacion.TipoProductoServicio(r);
            //_02_Dominio.Entidades.TipoProducto tp = new _02_Dominio.Entidades.TipoProducto();
            _02_Dominio.Entidades.TipoProducto eliminar = tps.Eliminar(i);
            //ACT y ASERT
            Assert.AreEqual(eliminar.Id, i);

        }
    }
}
