using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomAdaptorSortFilter.Data;

namespace CustomAdaptorSortFilter.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\SyncfusionExamples\Grid\CustomAdaptor-CRUD-Sortfilter\grid\EJ2-DataGrid-Blazor-CustomAdaptor-As-Component-CRUD-SortFilter\CustomADP\CustomADP\App_Data\NORTHWND.MDF;Integrated Security=True");
            }
        }
    }
 
}
