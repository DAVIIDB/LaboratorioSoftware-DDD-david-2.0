using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_AplicacionTest
{
    [TestClass]
    public class Aplicacion_Test
    {
        _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio r = new _03_InfraestructuraDatos.SQLServer.TipoProductoRepositorio();
        [TestMethod]
        public void Prueba_DatosValidos()
        {
            //ANT 
            string n ="ss";
            //ACT
            _01_Aplicacion.TipoProductoServicio tps = new _01_Aplicacion.TipoProductoServicio(r);
            _02_Dominio.Entidades.TipoProducto tp = new _02_Dominio.Entidades.TipoProducto();

            _02_Dominio.Entidades.TipoProducto _tp = new _02_Dominio.Entidades.TipoProducto();

            _01_Aplicacion.TipoProductoServicio _tps = new _01_Aplicacion.TipoProductoServicio(r);
            tp.Nombre = n;
            _tp.Nombre = n;
           // tps.Guardar(_tp);
           
           // _tps.Guardar(tp);

            //ASERT
            Assert.AreEqual(tp.Nombre,n);

        }
        [TestMethod]
        public void Prueba_DatosInvalidos()
        {
            //ANT 
            string n=null;
            //ACT
            _01_Aplicacion.TipoProductoServicio tps = new _01_Aplicacion.TipoProductoServicio(r);
            _02_Dominio.Entidades.TipoProducto tp = new _02_Dominio.Entidades.TipoProducto();

            tp.Nombre = n;
            
            // tps.Guardar(_tp);

           

            //ASERT
            Assert.IsNull(tp.Nombre);

        }
    }
}
