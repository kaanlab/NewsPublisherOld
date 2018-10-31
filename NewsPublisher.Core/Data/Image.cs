using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublisher.Core.Data
{
    public class Image
    {
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/0449bf6a-83a1-4783-8bb8-a6935b0a8a62/wpf-application-for-image-gallery?forum=wpf
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        
        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
