using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Storefront newStorefront = new Storefront();
            newStorefront.Id = 1;
            newStorefront.Build = "Box";
            newStorefront.Model = "Fent";
            newStorefront.Size = 50;

            Storefront newSuperStore = new SuperStore();
            newSuperStore.Id = 2;
            newSuperStore.Build = "Freeform";
            newSuperStore.Model = "Fender";
            newSuperStore.Size = 130;
            ((SuperStore)newSuperStore).HasEventRoom = true;
            ((SuperStore)newSuperStore).HasOfficeRoom = true;
            
            foreach (var Storefront in Storefronts)
            {
                Console.WriteLine(Storefront.DisplayText);
            }
        }
    }
}
