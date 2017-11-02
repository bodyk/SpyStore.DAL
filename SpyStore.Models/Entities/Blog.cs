using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SpyStore.Models.Entities
{
    public class Blog
    {
        //omitted for brevity
        public int BlogId { get; set; }

        [InverseProperty(nameof(Post.Blog))]
        public List<Post> Posts { get; set; }
    }
}
