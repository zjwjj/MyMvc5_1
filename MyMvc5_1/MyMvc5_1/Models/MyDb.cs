using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMvc5_1.Models
{
    public class MyDb:DbContext
    {
        public MyDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<MyMvc5_1.Models.Xueshengxinxi> Xueshengxinxis { get; set; }
    }
}