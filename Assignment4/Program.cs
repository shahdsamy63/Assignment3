
namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q01
            double[]prices = { 25.5, 40.0, 33.75};
            Console.WriteLine($"second price is {prices[1]}");


            //Q02
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine($" number of copies  is {shelfCopies[1,0]}");


            //Q03
             void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            PrintWelcomeMessage();


            //Q04
            void PrintBookTitle(string title)
            {
                Console.WriteLine($"Book title: {title}");

            }
            PrintBookTitle("Clean Code");


            //Q05
            int pages = 400;
            void AddBonusPages(int pages)
            {
                pages += 50;
            }
            AddBonusPages(pages);
            Console.WriteLine($"number of pages is : {pages}");
            //pages number will be the same >> cuz its variable data type we call function with the value not the refrence;



            //Q06
            double[] dprices = { 25.5, 40.0 };
            void ApplyDiscount(double[] prices)
            {
                prices[0]-=5;
            }
            ApplyDiscount(dprices);
            Console.WriteLine($"price is : {dprices[0]}");
            //price will be substracted >> cuz array is refrence data type so changes is applied in same refrence;



            //Q07
            void AddBonusPagesByRef(ref int pages)
            {
                pages += 50;
            }
            AddBonusPagesByRef(ref pages);
            Console.WriteLine($"number of pages is : {pages}");
            //pages number will change;


            //Q08
            void ReplaceArray(ref double[] prices)
            {
                prices= new double[]{ 10.0, 12.5, 15.0 };
                
            }
            ReplaceArray(ref dprices);
            Console.WriteLine($"replaced array length : {dprices.Length}");


            //Q09
            double oprice;
            bool TrtGetPrice(string title, out double oprice)
            {
                if (title == "Clean Code")
                {
                    oprice = 25.5;
                    return true;

                }
                else
                {
                    oprice = 0;
                    return false;
                }
            }
            if(TrtGetPrice("Clean Code",out oprice))
                Console.WriteLine(oprice);



            //Q10
            void PrintBookInfo(string title, int pages = 300){
                Console.WriteLine($"title is: {title} and pages is: {pages}");
            }
            PrintBookInfo("title1");
            PrintBookInfo("title1",50);


            //Q11
            PrintBookInfo( pages:120,title:"title55");


            //Q12
            void PrintAllTitles(params string[] titles){
                foreach (string title in titles) {

                    Console.WriteLine($"title >> {title}");
                }
            }
            PrintAllTitles("title1", "title2", "title3");

        }

    }

           

    }
