using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureCRUDQA.Models;

namespace AzureCRUDQA.Data
{
    public class DbInitializer
    {
        public static void Initialize(AzureCRUDQAContext context)
        {
            context.Database.EnsureCreated();

            if (context.Accounts.Any())
            {
                return;
            }

            var accounts = new Accounts[]
            {
                new Accounts{AccountName="Test1", AccountPassword="Testpass1", AccountDeatils="test details", CreateDate=DateTime.Now, UpdateDate=DateTime.Now},
                new Accounts{AccountName="Test2", AccountPassword="Testpass2", AccountDeatils="test details", CreateDate=DateTime.Now, UpdateDate=DateTime.Now},
                new Accounts{AccountName="Test3", AccountPassword="Testpass3", AccountDeatils="test details", CreateDate=DateTime.Now, UpdateDate=DateTime.Now}
            };

            foreach(var a in accounts)
            {
                context.Accounts.Add(a);
            }

            context.SaveChanges();
        }
    }
}
