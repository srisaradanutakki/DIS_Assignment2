using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
      decimal value = 0.0m;

            // write your implementation here
            if (!this.IsEmpty())
            {
                var stn = new StockNode();
                stn = this.head;
                value = value + stn.StockHolding.Holdings * stn.StockHolding.CurrentPrice;

                do
                {
                    stn = stn.Next;
                    value = value + stn.StockHolding.Holdings * stn.StockHolding.CurrentPrice;
                }
                while (stn.Next != null);
            }

            return value;
    }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
      int similarityIndex = 0;

      // write your implementation here
      var list1 = new List<string>();

            if (!this.IsEmpty())
            {
                var stn = new StockNode();
                stn = this.head;
                list1.Add(stn.StockHolding.Symbol);

                do
                {
                    stn = stn.Next;
                    list1.Add(stn.StockHolding.Symbol);
                }
                while (stn.Next != null);
            }

            var list2 = new List<string>();

            if (!listToCompare.IsEmpty())
            {
                var stn = new StockNode();
                stn = listToCompare.head;
                list2.Add(stn.StockHolding.Symbol);

                do
                {
                    stn = stn.Next;
                    list2.Add(stn.StockHolding.Symbol);
                }
                while (stn.Next != null);
            }

            var CommonList = list1.Intersect(list2);
            similarityIndex = CommonList.Count();

      return similarityIndex;
    }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {
            // write your implementation here

            if (!this.IsEmpty())
            {
                var stn = new StockNode();
                stn = this.head;
                Console.WriteLine(stn.StockHolding.ToString());
                
                do
                {
                    stn = stn.Next;
                    Console.WriteLine(stn.StockHolding.ToString());
                }
                while (stn.Next != null);
                
            }

        }
  }
}