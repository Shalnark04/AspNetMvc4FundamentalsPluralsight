using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMvc4FundamentalsPluralsight.WebApi.Models
{
    public class VideoDb : DbContext
    {
        DbSet<Video> Videos { get; set; }
    }
}