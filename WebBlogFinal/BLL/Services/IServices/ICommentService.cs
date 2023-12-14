using System.Xml.Linq;
using WebBlogFinal.BLL.ViewModels.Comments;
using WebBlogFinal.DAL.Models;

namespace WebBlogFinal.BLL.Services.IServices
{
    public interface ICommentService
    {
        Task<Guid> CreateComment(CommentCreateViewModel model, Guid userId);

        Task RemoveComment(Guid id);

        Task<List<Comment>> GetComments();
        Task<Comment> GetComment(Guid id);

        Task<CommentEditViewModel> EditComment(Guid id);

        Task EditComment(CommentEditViewModel model, Guid id);
    }
}