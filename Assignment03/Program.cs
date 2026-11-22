using System;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Q1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q2
            int[,] shelfCopies =
            {
                {3,5},
                {1,4}
            };
            Console.WriteLine(shelfCopies[1,0]);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q3
            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            PrintWelcomeMessage();
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q4
            void PrintBookTitle(string title)
            {
                Console.WriteLine($"Book title : {title}");
            }
            PrintBookTitle("Clean Code");
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q5
            void AddBonusPages(int pages)
            {
                pages += 50;
            }
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages); // I expect to see the same number (400) because the function will reserve a new place on the memory not the same place.
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q6
            void ApplyDiscount(double[] prices)
            {
                prices[0] -= 5;
            }
            double[] prices02 = { 25.5, 40.0 };
            ApplyDiscount(prices02);
            Console.WriteLine(prices02[0]);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q7
            void AddBonusPagesByRef(ref int pages)
            {
                pages += 50;
            }
            int pages02 = 400;
            AddBonusPagesByRef(ref pages02);
            Console.WriteLine(pages02);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q8
            void ReplaceArray(ref double[] prices)
            {
                prices = new double[] { 10.0, 12.5, 15.0 };
            }
            double[] prices03 = { 25.5, 40.0 };
            ReplaceArray(ref prices03);
            Console.WriteLine(prices03.Length);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q9
            bool TryGetPrice(string title,out double price)
            {
                if(title== "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                else
                {
                    price = 0;
                    return false;
                }
            }
            double price;
            bool isFound = TryGetPrice("Clean Code", out price);
            if (isFound)
            {
                Console.WriteLine(price);
            }
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q10
            void PrintBookInfo(string title,int pages = 300)
            {
                Console.WriteLine($"Title: {title} , Pages : {pages}");
            }
            PrintBookInfo("C++");
            PrintBookInfo("C++",580);
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q11
            PrintBookInfo(pages: 780, title: "C++");
            Console.WriteLine("---------------------------------");
            #endregion
            #region
            //Q12
            void PrintAllTitles(params string[] titles)
            {
                foreach(string title in titles)
                {
                    Console.WriteLine(title);
                }
            }
            PrintAllTitles("C++ fundamentals", "Clean Code", "Operation Research");
            Console.WriteLine("---------------------------------");
            #endregion
        }
    }
}