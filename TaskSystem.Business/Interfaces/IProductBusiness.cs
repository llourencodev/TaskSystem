using ProdutoAPI.Models;
using TaskSystem.Business;
using TaskSystem.Shared.DTOs;

namespace ProdutoAPI.Business.Interfaces
{
    public interface IProductBusiness
    {
        Task<> Create( ); 
    }
}
