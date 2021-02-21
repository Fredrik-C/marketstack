﻿using Marketstack.Entities.Exchanges;
using Marketstack.Entities.Stocks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marketstack.Interfaces
{
    public interface IMarketstackService
    {
        Task<List<Exchange>> GetExchanges();
        Task<List<Stock>> GetExchangeStocks(string exchangeMic);
        Task<List<StockBar>> GetStockEodBars(string stockSymbol, DateTime fromDate, DateTime toDate);
        Task<List<StockBar>> GetStockIntraDayBars(string stockSymbol, DateTime fromDate, DateTime toDate, string interval = "1hour");
    }
}
