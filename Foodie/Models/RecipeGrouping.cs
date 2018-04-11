using System;
using System.Collections.Generic;

namespace Foodie.Models
{
    public class RecipeGrouping : List<Recipe>
    {
        public string Title
        {
            get;
            set;
        }
        public string ShortName
        {
            get;
            set;
        }

        public RecipeGrouping(string title, string shortName)
        {
            Title = title;
            ShortName = shortName;
        }
    }
}
