using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DF.VIP.Infrastructure.Repository;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using DF.VIP.Infrastructure.Entity.Admin;

namespace DF.VIP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public  void TestMethod()
        {
           
            List<Task> list = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(Task.Run(() =>
                {

                    var db = new VIPDB();
                    var user = new LoginUser { IsActive = false, NickName = "china" + i, CreateTime = DateTime.Now, UpdateTime = DateTime.Now, LastSignTime = DateTime.Now };

                    db.Set<LoginUser>().Add(user);

                    db.SaveChanges();
                }));

            }
            Task.WaitAll(list.ToArray());

        }
    }
}
