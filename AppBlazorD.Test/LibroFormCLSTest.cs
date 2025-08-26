using AppBlazor.Entities;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace AppBlazorD.Test
{
    public class LibroFormCLSTest
    {
        private List<ValidationResult> validaModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo,null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }
        [Fact]
        public void ValidacionCamposVacios()
        {
            var libro = new Pedido();

            var errores = validaModelo(libro);

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El id es requerido") ||
            e.ErrorMessage!.Contains("El valor debe ser un numero positivo"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El titulo es requerido"));

            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El resumen es requerido"));

        }

        [Fact]
        public void ValidacionCamposCorrectos()
        {
            var libro = new Pedido
            {
                idLibro = 1,
                titulo = "Libro de prueba",
                resumen = "Es un resumen del libro de pruebas"
            };
            
            var errores = validaModelo(libro);

            Assert.Empty(errores);
        }
    }
}