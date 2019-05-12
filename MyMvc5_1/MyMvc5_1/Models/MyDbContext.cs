using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMvc5_1.Models
{
    //除了ASPNET用户管理之外的数据库表的模型
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<MyMvc5_1.Models.Xueshengxinxi> Xueshengxinxis { get; set; }

    }
}