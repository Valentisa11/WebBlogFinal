using WebBlogFinal.BLL.ViewModels.Comments;
using WebBlogFinal.BLL.ViewModels.Posts;
using WebBlogFinal.BLL.ViewModels.Tags;
using WebBlogFinal.BLL.ViewModels.Users;
using WebBlogFinal.DAL.Models;
using AutoMapper;

namespace WebBlogFinal
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegisterViewModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.UserName));

            CreateMap<CommentCreateViewModel, Comment>();
            CreateMap<CommentEditViewModel, Comment>();
            CreateMap<PostCreateViewModel, Post>();
            CreateMap<PostEditViewModel, Post>();
            CreateMap<TagCreateViewModel, Tag>();
            CreateMap<TagEditViewModel, Tag>();
            CreateMap<UserEditViewModel, User>();
        }
    }
}