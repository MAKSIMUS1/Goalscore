﻿using FootballDataApi.Builders;
using FootballDataApi.Extensions;
using FootballDataApi.Interfaces;
using FootballDataApi.Models;
using FootballDataApi.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FootballDataApi
{
    public class AreaProvider : IAreaProvider
    {
        private static string BaseAddress = "https://api.football-data.org/v4/areas";
        
        private HttpClient _httpClient;

        internal AreaProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Area>> GetAllAreas()
        {
            var url = $"{BaseAddress}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var rootArea = await _httpClient.Get<RootArea>(request);

            return rootArea.Areas;
        }

        public async Task<Area> GetAreaById(int idArea)
        {
            HttpHelpers.VerifyActionParameters(idArea, null, null);

            var url = $"{BaseAddress}/{idArea}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _httpClient.Get<Area>(request);
        }

        public static AreaProviderBuilder Create()
        {
            return new AreaProviderBuilder();
        }
    }
}
