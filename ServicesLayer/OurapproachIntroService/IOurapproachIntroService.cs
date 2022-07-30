using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.OurapproachIntroService
{
    public interface IOurapproachIntroService
    {
        IEnumerable<OurapproachIntro> GetAllOurapproachIntro();
        OurapproachIntro GetOurapproachIntro(int id);
        void InsertOurapproachIntro(OurapproachIntro ourapproachIntro);
        void UpdateOurapproachIntro(OurapproachIntro ourapproachIntro);
        void DeleteOurapproachIntro(int id);
    }
}
