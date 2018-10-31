using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPublisher.Core.Data
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Description { get; set; }
        public string TrumbImg { get; set; }
        public byte[] ImageSource { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
