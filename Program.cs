using System;
using System.Collections.Generic;

namespace dictionary_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("GMC", "General Motor Contractors");
            stocks.Add("CAT", "Caterpillar");

            string GM = stocks["GM"];

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add (new Dictionary<string, double>(){ {"GM", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GM", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GM", 406.34} });
            purchases.Add (new Dictionary<string, double>(){{"CAT", 424.12} });

                        /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock


                From the three purchases above, one of the entries
                in this new dictionary will be...
                    {"General Electric", 1217.53}

                Replace the questions marks below with the correct types.
            */
            Dictionary<string, double> stockReport = new Dictionary<string, double>();
            /*
            Iterate over the purchases and record the valuation for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases) {
            {
                foreach (KeyValuePair<string, double> price in purchase)
                {
                    foreach(KeyValuePair<string, string> kvp in stocks)
                    {   
                        // Does the full company name key already exist in the `stockReport`?
                        if(kvp.Key == price.Key){
                            if(stockReport.ContainsKey(kvp.Value)){
                                // If it does, update the total valuation
                                stockReport[kvp.Value] += price.Value;
                            }else{
                                                    /*
                                    If not, add the new key and set its value.
                                    You have the value of "GE", so how can you look
                                    the value of "GE" in the `stocks` dictionary
                                    to get the value of "General Electric"?
                                */
                                stockReport.Add(kvp.Value, price.Value);
                            }

                        }
                        
                    }

                }
            }

        }
            //specif type of keys and values
            foreach(KeyValuePair<string, double> money in stockReport){
                Console.WriteLine($"{money.Key}, {money.Value}");
            }

    }
}
}
