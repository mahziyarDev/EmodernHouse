using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using EModernHouse.Application.Extensions;
using EModernHouse.Application.Utils;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace EModernHouse.Web.Controllers
{
    public class UploaderController : SiteBaseController
    {
        [HttpPost]
        public IActionResult UploadImage(IFormFile upload,string CkEditorFuncName,string CKEditor,string langCode)
        {
            if (upload.Length <= 0) return null;
            if (!upload.IsImage())
            {
                var notImageMessage = "لطفا یک تصویر انتخاب کنبد";
                var notImage =
                    JsonConvert.DeserializeObject("{'uploaded':0, 'error':{'message':\" " + notImageMessage + " \"}");
                return Json(notImage);

            }

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();
            upload.AddImageToServer(fileName,PathExtensions.UploadImageServer,null,null);
            return Json(new
            {
                uploaded = true,
                url = $"{PathExtensions.UploadImage}{fileName}"
            });
        }
    }
}
