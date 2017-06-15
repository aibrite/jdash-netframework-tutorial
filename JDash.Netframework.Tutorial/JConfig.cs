using JDash.NetFramework.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JDash.NetFramework.Models;

namespace JDash.Netframework.Tutorial
{
    public class JConfig : BaseJDashConfigurator
    {
        public JConfig(JRequestWrapper request) : base(request)
        {
        }


        public override JDashPrincipal GetPrincipal()
        {
            return new JDashPrincipal(this.Request.User.Identity.Name ?? "username");
        }

        public override IJDashProvider GetProvider()
        {
            string mySqlConnStr = "Server=localhost;Database=jdash_mysql_demo;Uid=root;Pwd=1234;";
            return new JDash.NetFramework.Provider.MySQL.JMySQLProvider(mySqlConnStr);
        }
    }
}