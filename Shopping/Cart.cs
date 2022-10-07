using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
            List<Article> removedArticles = new List<Article>();

            if (clearCart)
            {
                removedArticles.AddRange(_articles);
                _articles.Clear();
            } else
            {
                _articles.Remove(_articles.Last());
                removedArticles.Add(_articles.Last());
            }

            return removedArticles;
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }
        #endregion public methods
    }
}
