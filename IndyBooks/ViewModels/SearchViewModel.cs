using System;
using System.ComponentModel.DataAnnotations; 

namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public string Title { get; set; }

        //TODO: Add properties needed for searching

        public string Author { get; set; }

        [DataType(DataType.Currency)]
        public decimal Min { get; set;  }


        [DataType(DataType.Currency)]
        public decimal Max { get; set; }



    }
}
