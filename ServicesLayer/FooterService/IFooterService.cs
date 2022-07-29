using DomainLayer.Model;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.FooterService
{
    public interface IFooterService
    {
        IEnumerable<Footer> GetAllFooter();
        Footer GetFooter(int id);
        void InSertFooter(Footer footer);
        void UpdateFooter(Footer footer);
        void DeleteFooter(int id);
    }
}
