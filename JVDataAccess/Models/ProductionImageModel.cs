using System;
using System.Collections.Generic;
using System.Text;

namespace JVDataAccess.Models
{
    public class ProductionImageModel
    {
        public string ImageURL { get; set; }

        public byte[] Picture { get; set; }

        public string GetImage()
        {
            if (Picture is null)
                return ImageURL;

            var base64 = Convert.ToBase64String(Picture);
            return string.Format("data:image/jpg;base64,{0}", base64);
        }

    }
}
