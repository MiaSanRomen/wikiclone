using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiClone.Models;

namespace WikiClone.Data
{
    public class SampleData
    {
        public static void Initialize(ArticleContext context)
        {
            if (!context.Articles.Any())
            {
                context.Articles.AddRange(
                    new Article
                    {
                        Name = "Rome",
                        Info = "Capital and the largest city of Italy",
                    },
                    new Article
                    {
                        Name = "Roman Empire",
                        Info = "The history of Ancient Rome since 27 BC.",
                    },
                    new Article
                    {
                        Name = "Roman army",
                        Info = "The regular army of Ancient Rome, one of the main elements of Roman society and state.",
                    },
                    new Article
                    {
                        Name = "Punic wars",
                        Info = "Three wars between Ancient Rome and Carthage, which continued intermittently in 264-146 BC.",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
