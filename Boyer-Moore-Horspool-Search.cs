        public void BadMatchTable(string SearchTerm)
        {
            int _defaultVal = SearchTerm.Length;
            Dictionary<int,int> distances = new Dictionary<int, int>();
            for (int x =0; x<SearchTerm.Length-1;x++)
            {
                distances[SearchTerm[x]] = SearchTerm.Length - x - 1;
            }
        }
