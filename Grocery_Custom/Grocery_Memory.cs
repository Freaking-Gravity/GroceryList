using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Custom
{
   [Serializable]
    public class Grocery_Memory
    {
        
        public decimal Price { get; set; }
        public string Object_ID { get; set; }

        public string Item_Name { get; set; }
        public decimal Item_Quantity { get; set; }


    public Grocery_Memory(Grocery_List_Object save_list)
        {
            Item_Name = save_list.Name;
            Price = save_list.Price;
            Object_ID = save_list.Object_ID;
            Item_Quantity = save_list.Item_Quant;
        }
    }
}
