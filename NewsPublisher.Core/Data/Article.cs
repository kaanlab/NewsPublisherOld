using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewsPublisher.Core.Data
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string SiteSelection { get; set; }
        public string TextField { get; set; }
        public string CurentUserName { get; set; }
        public string CurentUserLogin { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDate { get; set; }
        public ICollection<Image> Images { get; set; } //= new List<Image>();
    }
}
