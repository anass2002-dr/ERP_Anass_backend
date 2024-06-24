﻿using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.ArticleRepo
{
    public interface IRepoArticle
    {
        Article GetArticleById(int id);
        List<Article> GetArticles();
        Article AddArticle(Article article);
        Article UpdateArticle(Article article);
        Boolean DeleteArticle(int id);
    }
}
