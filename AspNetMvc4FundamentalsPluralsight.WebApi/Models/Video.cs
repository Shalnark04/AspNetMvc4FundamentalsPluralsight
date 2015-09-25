using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc4FundamentalsPluralsight.WebApi.Models
{
    public class Video
    {
        public virtual int VideoId { get; set; }
        public virtual string Title { get; set; }
        public virtual int Length { get; set; }
    }
}