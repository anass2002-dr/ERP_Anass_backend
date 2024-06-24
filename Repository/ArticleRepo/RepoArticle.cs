using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.ArticleRepo
{
    public class RepoArticle : IRepoArticle
    {
        private readonly DbContextERP _context;

        public RepoArticle(DbContextERP context)
        {
            _context = context;
        }

        public Article AddArticle(Article article)
        {
            _context.Article.Add(article);
            _context.SaveChanges();
            return article;
        }

        public bool DeleteArticle(int id)
        {
            var article = _context.Article.Find(id);
            if (article == null)
            {
                return false;
            }

            _context.Article.Remove(article);
            _context.SaveChanges();
            return true;
        }

        public Article GetArticleById(int id)
        {
            return _context.Article.Find(id);
        }

        public List<Article> GetArticles()
        {
            return _context.Article.ToList();
        }

        public Article UpdateArticle(Article article)
        {
            _context.Article.Update(article);
            _context.SaveChanges();
            return article;
        }
    }
}
