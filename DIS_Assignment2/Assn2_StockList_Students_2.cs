using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
      StockList resultList = new StockList();

            // write your implementation here

            var list1 = new List<StockNode>();

            if (!this.IsEmpty())
            {
                var stn = new StockNode();
                stn = this.head;
                list1.Add(stn);

                do
                {
                    stn = stn.Next;
                    list1.Add(stn);
                }
                while (stn.Next != null);
            }

            var list2 = new List<StockNode>();

            if (!listToMerge.IsEmpty())
            {
                var stn = new StockNode();
                stn = listToMerge.head;
                list2.Add(stn);

                do
                {
                    stn = stn.Next;
                    list2.Add(stn);
                }
                while (stn.Next != null);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                var symbol = list1[i].StockHolding.Symbol;
                var name = list1[i].StockHolding.Name;
                var holdings = list1[i].StockHolding.Holdings;
                var currentPrice = list1[i].StockHolding.CurrentPrice;
                Stock stock = new Stock(symbol, name, holdings, currentPrice);

                resultList.AddLast(stock);
            }

            for (int i = 0; i < list2.Count; i++)
            {
                var symbol = list2[i].StockHolding.Symbol;
                var name = list2[i].StockHolding.Name;
                var holdings = list2[i].StockHolding.Holdings;
                var currentPrice = list2[i].StockHolding.CurrentPrice;
                Stock stock = new Stock(symbol, name, holdings, currentPrice);

                resultList.AddLast(stock);
            }

            return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      Stock mostShareStock = null;

            // write your implementation here
            if (!this.IsEmpty())
            {
                var stn = new StockNode();
                stn = this.head;
                decimal currentshareCount = stn.StockHolding.Holdings;
                mostShareStock = stn.StockHolding;

                do
                {
                    if(currentshareCount < stn.StockHolding.Holdings)
                    {
                        currentshareCount = stn.StockHolding.Holdings;
                        mostShareStock = stn.StockHolding;
                    }
                    stn = stn.Next;
                }
                while (stn.Next != null);
                
            }


            return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

            // write your implementation here

            if (!this.IsEmpty())
            {
                var stn = new StockNode();
                stn = this.head;
                length++;

                do
                {
                    length++;
                    stn = stn.Next;
                }
                while (stn.Next != null);

                return length;
            }

            return length;
    }
  }
}