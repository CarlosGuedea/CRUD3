using CRUD2.Data;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using DocumentFormat.OpenXml.Office2010.Excel;
using Nest;
using Rotativa;
using iTextSharp.LGPLv2;
using iTextSharp.text;
using iTextSharp.text.pdf;
using IronPdf;
using Microsoft.AspNetCore.Components.RenderTree;

namespace CRUD2.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult Index()
        {
            IronPdf.PdfDocument.FromFile("Views/Usuarios/Index.cshtml");

            // Imprimir a PDF
            

            // Guardar el archivo PDF generado en disco
            


            return View();

        }

    }
}
