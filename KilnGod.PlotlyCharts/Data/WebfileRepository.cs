//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: WebfileRepository.cs
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.Data
{
    public class WebfileRepository : IWebfileRepository
    {
        private HttpClient _Client;


        public WebfileRepository(HttpClient httpClient)
        {
            _Client = httpClient;
          // var cors = new EnableCorsAttribute("www.example.com", "*", "*");
        }

        public async Task<string?> DownloadText(string url)
        {

            var response = await _Client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            string? result = null;
            if (response.IsSuccessStatusCode)
            {
                result = content;
            }
            return result;
        }

    }
}
