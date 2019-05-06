using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvc5_1.Models
{
    public class MyDbInit:System.Data.Entity.CreateDatabaseIfNotExists<MyDb>
    {
        protected override void Seed(MyDb context)
        {
            base.Seed(context);

            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "20180001",
                Xueshengxingming = "zhangsan",
                Xueshengxingbie = "男"

            });
            context.Xueshengxinxis.Add(new Xueshengxinxi
            {
                Xueshengxuehao = "20180002",
                Xueshengxingming = "lisi",
                Xueshengxingbie = "女"
            });

        }
    }
}