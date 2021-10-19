using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.Models
{
    public class ImageConverter
    {
        public byte[] GetImage(IFormFile file)
        {
            MemoryStream stream = new MemoryStream();
            file.CopyTo(stream);
            return stream.ToArray();
        }
    }
}
