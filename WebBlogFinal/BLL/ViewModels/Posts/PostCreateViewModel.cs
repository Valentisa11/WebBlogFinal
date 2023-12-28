﻿using System.ComponentModel.DataAnnotations;
using WebBlogFinal.BLL.ViewModels.Tags;

namespace WebBlogFinal.BLL.ViewModels.Posts
{
    public class PostCreateViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? AuthorId { get; set; }
        public List<TagViewModel>? Tags { get; set; }

        [Required(ErrorMessage = "Поле Заголовок обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Заголовок", Prompt = "Заголовок")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Поле Контент обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Контент", Prompt = "Контент")]
        public string? Content { get; set; }
    }
}