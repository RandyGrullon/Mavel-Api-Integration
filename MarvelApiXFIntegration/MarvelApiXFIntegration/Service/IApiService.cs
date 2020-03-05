using MarvelApiXFIntegration.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MarvelApiXFIntegration.Models;

namespace MarvelApiXFIntegration.Service
{
    public interface IApiService
    {
        Task<ComicsBook> GetComic();
    }
}
