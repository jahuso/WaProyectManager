using NUnit.Framework;
using ProjectManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace ProjectManager.Test.Steps
{
    [Binding]
    public class ProjectStepDefinitions
    {
        Proyecto proyecto = new Proyecto()
        {
            Nombre = "Proyecto Unit Test",
            Descripcion = "Proyecto Unit Test",
            Estado = "Inscrito",
            Tutor = 12345,
            Equipo = 1


        };
        List<String> listadoProyectos = new List<string>();
        Boolean existe = false;

        [Given(@"Tengo el listado de Proyectos")]
        public void GivenTengoElListadoDeProyectos()
        {

            listadoProyectos.Add("Monografia");
            listadoProyectos.Add("Tesis");
            listadoProyectos.Add("Investigacion Documental");
            listadoProyectos.Add("Investigacion de Campo");
            listadoProyectos.Add("Investigacion Historica");
            listadoProyectos.Add("Investigacion Descriptica");
            listadoProyectos.Add("Investigacion Documental");
        }

        [Given(@"Tengo el tipo de Projecto escogido \$Monografia")]
        public void GivenTengoElTipoDeProjectoEscogidoMonografia(String pTipoProjecto)
        {
            proyecto.Tipo = pTipoProjecto;
            WhenLoValido(pTipoProjecto);
        }

        [When(@"Lo Valido")]
        public void WhenLoValido(String pTipoProjecto)
        {
            existe = listadoProyectos.Any(pTipoProjecto.Contains);
        }

        [Then(@"El resultado debe ser Verdadero")]
        public void ThenElResultadoDebeSerVerdadero()
        {
            Assert.AreEqual(true, existe);
        }
    }
}
