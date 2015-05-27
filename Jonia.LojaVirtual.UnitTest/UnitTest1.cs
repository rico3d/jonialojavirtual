using System;
using System.Runtime.InteropServices;
using System.Web.Mvc;
using Jonia.LojaVirtual.Web.HtmlHelpers;
using Jonia.LojaVirtual.Web.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jonia.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestJonia
    {
        [TestMethod]
        public void TestarSeaPaginacaEstaSendoGeradaCorretamente()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao()
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act

            MvcHtmlString resultado = html.PageLInks(paginacao, paginaUrl);

            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>" 
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>" 
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                );

        }
    }
}
