using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.OurapproachDemoService
{
    public interface IOurapproachDemoService
    {
        IEnumerable<OurapproachDemo> GetAllOurapproachDemo();
        OurapproachDemo GetOurapproachDemo(int id);
        void InsertOurapproachDemo(OurapproachDemo ourapproachDemo);
        void UpdateOurapproachDemo(OurapproachDemo ourapproachDemo);
        void DeleteOurapproachDemo(int id);
    }
}
