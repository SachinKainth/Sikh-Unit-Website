using System.Web.Mvc;
using Ionic.Zip;

namespace SikhUnit.Site.ActionResults
{
    public class ZipResult : ActionResult
    {
        private readonly string _directory;
        private string _fileName;

        public string FileName
        {
            get
            {
                return _fileName ?? "file.zip";
            }
            set { _fileName = value; }
        }

        public ZipResult(string directory)
        {
            _directory = directory;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            using (var zf = new ZipFile(FileName))
            {
                zf.AddDirectory(_directory);
                context.HttpContext.Response.ContentType = "application/zip";
                context.HttpContext.Response.AppendHeader("content-disposition", "attachment; filename=\"" + FileName + ".zip" + "\"");
                zf.Save(context.HttpContext.Response.OutputStream);
            }
        }
    } 
}