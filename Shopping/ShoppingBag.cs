namespace Shopping
{
    public class ShoppingBag:ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();

        public List<Article> Articles => throw new NotImplementedException();

        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
        }

        public List<Article> Remove(bool empty = false)
        {
            throw new NotImplementedException();
        }
        #endregion private attributes
    }
}
