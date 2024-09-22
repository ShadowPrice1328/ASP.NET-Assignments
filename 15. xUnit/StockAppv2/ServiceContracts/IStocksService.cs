﻿using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IStocksService
    {
        /// <summary>
        ///  Inserts a new buy order into the database
        /// </summary>
        /// <param name="request">BuyOrder to be created</param>
        /// <returns>A BuyOrderResponse object representing newly created BuyOrder</returns>
        public Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? request);

        /// <summary>
        /// Inserts a new sell order into the database
        /// </summary>
        /// <param name="request">SellOrder to be created</param>
        /// <returns>A SellOrderResponse object representing newly created SellOrder</returns>
        public Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? request);

        /// <summary>
        /// Returns the existing list of buy orders retrieved from database 
        /// </summary>
        /// <returns>A list representing all existing BuyOrders</returns>
        public Task<List<BuyOrderResponse>?> GetBuyOrders();

        /// <summary>
        /// Returns the existing list of sell orders retrieved from database
        /// </summary>
        /// <returns>A list representing all existing SellOrders</returns>
        public Task<List<SellOrderResponse>?> GetSellOrders();
    }
}
