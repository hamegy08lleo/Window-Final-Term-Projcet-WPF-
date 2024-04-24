using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_.Objects
{
    internal class SearchResultDAO : DAO
    {
        public SearchResultDAO() { }
        public IQueryable<SearchResult> listResult()
        {
            return dataBase.SearchResult;
        }
    }
}
