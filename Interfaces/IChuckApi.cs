using Refit;
using RefitExample.Models;

namespace RefitExample.Interfaces
{
    public interface IChuckApi
    {
        [Get("/jokes/random")]
        Task<ChuckNorrisModel> GetAdvice();
    }
}
