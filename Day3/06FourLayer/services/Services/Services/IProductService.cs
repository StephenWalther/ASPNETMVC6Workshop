using System.Collections.Generic;
using Services.Models;

namespace Services.Services
{
    public interface IProductService
    {
        void Add(FullProductDTO product);
        void Delete(int id);
        void Edit(FullProductDTO product);
        FullProductDTO Get(int id);
        IList<BriefProductDTO> List();
    }
}