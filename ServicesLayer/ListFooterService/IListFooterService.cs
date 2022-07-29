using DomainLayer.Model;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.ListFooterService
{
    public interface IListFooterService
    {
        IEnumerable<ListFooter> GetAllListFooter();
        ListFooter GetListFooter(int id);
        void InSertListFooter(ListFooter listFooter);
        void UpdateListFooter(ListFooter listFooter);
        void DeleteListFooter(int id);
    }
}
