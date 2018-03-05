using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjeto.DataProvider.Migrations;
using WebProjeto.DataProvider.Models;

namespace WebProjeto.DataProvider.Context
{
    public class WebProjetoContext : DbContext
    {
        public WebProjetoContext() : base("Contexto")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebProjetoContext, Configuration>());
        }

        public System.Data.Entity.DbSet<WebProjeto.DataProvider.Models.LivroModel> LivroModels { get; set; }
    }
}
