
using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Router
    {
        public int Xvalue;
        public int Xtime   //deleted it 
        {
            get { return Xvalue; }
            set { Xvalue = value; }
        }
    }
    public class Route
    {
        public Router myRouter = new Router();
       public  Router[] myArray = new Router[] { };
       

        public Router[] AddInput()                       //Add a router to given route
        {
            Console.WriteLine("Please enter a Router");
            for (int i = 0; i < myArray.Length; i++)
             { 
                int val = Convert.ToInt32(Console.ReadLine());
                myArray[i] = new Router { Xvalue = val };
             }
            return myArray;
        }
       
    }
    public class Sync_Async
    {
        //Sync method that calculates best route from available routes.
       
        Route myRoute = new Route();
        public int Calcuates()

        {
            ArrayList mylistRoute = new ArrayList();

             for (int j=0; j< mylistRoute.Count ; j++)
             {
                mylistRoute.AddRange(myRoute.AddInput());
            }
            int result =0  ;
            int shortpath = 999999;

            //best path 
            foreach (Router[] item in mylistRoute)
            {
                for (int t = 0; t < myRoute.myArray.Length; t++)
                {
                    result = 0;
                    result += myRoute.myArray[t];
                }
                    if (result < shortpath)
                    { shortpath = result; }
             }
            return shortpath;
        }
        
        public async  void Calculates_async ()
        {
            int t = await Task.Run(() => Calcuates());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Route myRoute1 = new Route();
            myRoute1.AddInput();

            Sync_Async Sync_async = new Sync_Async();

            Sync_async.Calcuates();
            Sync_async.Calculates_async();

           
            

        }
    }
}
