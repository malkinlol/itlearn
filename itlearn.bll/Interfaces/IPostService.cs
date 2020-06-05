using itlearn.model.ViewModels.Post;
using itlearn.model.ViewModels.Search;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itlearn.bll.Interfaces
{
    public interface IPostService
        : IBaseService<PostVM>
    {
        Task<List<PostVM>> GetByTag(string tag);
        Task<List<PostVM>> GetByUser(string userName);
        Task<List<PostVM>> GetBySearch(PostSearchVM model);
    }
}
