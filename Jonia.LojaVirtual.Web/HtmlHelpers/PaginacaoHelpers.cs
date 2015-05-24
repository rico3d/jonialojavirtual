using System;
using System.Text;
using System.Web.Mvc;
using Jonia.LojaVirtual.Web.Models;

namespace Jonia.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLInks(this HtmlHelper html, Paginacao paginacao,Func<int,string> paginaUrl)
        {



            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i < paginacao.TotalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");

                tag.MergeAttribute("href",paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                tag.AddCssClass("btn-default");
                resultado.Append(tag);

            }

            return MvcHtmlString.Create(resultado.ToString());

        }

    }
}