using Microsoft.Extensions.Hosting;
using WebBlogFinal.BLL.ViewModels.Posts;
using WebBlogFinal.DAL.Models;

namespace WebBlogFinal.BLL.Services.IServices
{
    public interface IPostService
    {
        Task<PostCreateViewModel> CreatePost();

        Task<Guid> CreatePost(PostCreateViewModel model);

        Task<PostEditViewModel> EditPost(Guid Id);

        Task EditPost(PostEditViewModel model, Guid Id);
        Task RemovePost(Guid id);
        Task<List<Post>> GetPosts();
        Task<Post> ShowPost(Guid id);

        Task<List<Post>> GetPostsByAuthor(string authorId);//
    }
}