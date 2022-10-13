namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles.AddRange(articles);
            _balance += articles.Count;
        }

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> removedArticles = new List<Article>();

            if (empty)
            {
                removedArticles.AddRange(_articles);
                _articles.Clear();
            }
            else
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

        public float Balance
        {
            get
            {
                return _balance;
            }
        }

        public void StartCashingProcess()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                throw new NotImplementedException();
            }
        }
        #endregion private methods
    }
}
