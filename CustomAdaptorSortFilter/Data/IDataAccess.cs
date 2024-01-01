using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CustomAdaptorSortFilter.Data;

namespace CustomAdaptorSortFilter.Data
{
    public interface IDataAccess
    {
        Task<List<Order>> GetAllRecords();
    }
}
