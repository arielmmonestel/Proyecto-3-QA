using NUnit.Framework;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_3.Controllers;
using Proyecto_3.Models;

namespace TestCases
{
    [TestFixture]
    class Test_Reporte_Errores_Controller
    {
        [Category("Validacion de email")]
        [TestCase("arielmmonestel@gmail.com", true)]
        [TestCase("franciscoferfoja.es", false)]
        [TestCase("", false)]
        [TestCase("a@b.com", true)]
        [TestCase("@gmail.com", false)]
        [TestCase("@gmail@othermail", false)]
        [TestCase("juanito@hotmail", false)]
        [TestCase(null, false)]

        public void emailIsValid_ValidEmail_ReturnBool(String email, Boolean expected)
        {

            Boolean esValido = InsertarReporte.EmailEsValido(email);
            Assert.AreEqual(esValido, expected);
        }

        [TestCase(4, "PC", "2017 - 11 - 10", "luis@mail.com", null, "Debe llenar todos los campos")]
        [TestCase(4, "PC", "2017 - 11 - 10", null, null, "Debe llenar todos los campos")]
        [TestCase(4, "PC", null, "luis@mail.com", null, "Debe llenar todos los campos")]
        [TestCase(4, null, "2017 - 11 - 10", "luis@mail.com", null, "Debe llenar todos los campos")]
        [TestCase(null, "PC", "2017 - 11 - 10", "luis@mail.com", null, "Debe llenar todos los campos")]
        [TestCase(4, "PC", "2017 - 11 - 10", "luismail", "La PC no enciende", "El correo no es valido")]
        public void RegistroReporte_ValidaReporte_ReturnErrorMessage(int saleID, string productName, DateTime errorDate, string contactMail, string errorDec, string msjExpected)
        {
            ReporteDeErroresController ReporteController = new ReporteDeErroresController();
            ErrorReport reporte = new ErrorReport { SaleID = saleID, ProductName = productName, ErrorDate = errorDate, ContactMail = contactMail, ErrorDescription = errorDec };
            ReporteController.RegistrarError(reporte);
            Assert.AreEqual(reporte.errorMessage, msjExpected);
        }
    }
}
