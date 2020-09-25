using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopEntities;
using JuiceShopBusinessManager;

namespace JuiceShopClient
{
    class JuiceshopClientConsole
    {
        static void Main(string[] args)
        {
            JuiceshopBusMan jbm = new JuiceshopBusMan();
            jbm.DeletePreviosPurchases();
            Console.WriteLine("The Juice flavors available:");
            List<Juice> lstjuices = jbm.GetAllItems();
            foreach (Juice j in lstjuices)
            {
                Console.WriteLine("Juice_id: {0}\tJuice_flavor: {1}\tPrice: {2}", j.juice_id,j.juice_flavor,j.price);
            }
            

            Console.Write("\nEnter the Juice Id of the flavour you want: ");
            int J_id = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the quantity: ");
            int Q = int.Parse(Console.ReadLine());
            jbm.PurchasedJuice(J_id, Q);


            Console.Write("\nDo you want to continue purshasing y/n: ");
            string reply = (Console.ReadLine());
            if (reply == "y")
            {
                do
                {
                    Console.WriteLine("\nThe Juice flavors available:");
                    foreach (Juice j in lstjuices)
                    {
                        Console.WriteLine("Juice_id: {0}\tJuice_flavor: {1}\tPrice: {2}", j.juice_id, j.juice_flavor, j.price);
                    }

                    Console.Write("\nEnter the Juice Id of the flavour you want: ");
                    int jid = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter the quantity: ");
                    int q = int.Parse(Console.ReadLine());
                    jbm.PurchasedJuice(jid, q);
                    Console.Write("\nDo you want to continue purshasing y/n: ");
                    reply = (Console.ReadLine());
                }
                while (reply == "y");
            }


            List<JuicePurchased> lstjucpur = jbm.GetAllPurchasedItems();
            int TotalAmount = 0;
            foreach (JuicePurchased jp in lstjucpur)
            {
                TotalAmount += jp.amount;
            }
            Console.WriteLine("\nYour total Purchase amount is: " + TotalAmount);
            Console.WriteLine("          THANK YOU");
        }
    }
}
