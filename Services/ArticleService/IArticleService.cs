using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.ArticleService
{
    public interface IArticleService
    {
        Article GetArticleById(int id);
        List<Article> GetArticles();
        Article AddArticle(Article article);
        Article UpdateArticle(int id,ArticleDtos articleDto);
        bool DeleteArticle(int id);
        List<Article> GetArticlesByPriceRange(float minPrice, float maxPrice);
        bool IsArticleInStock(int id);
    }
}
