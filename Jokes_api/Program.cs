using RestSharp;
using System.Text.Json;
using System.Net;
RestClient jokeClient = new ("https://api.jokes.one");

RestRequest request = new("pokemon/rayquaza");

RestResponse response = jokeClient.GetAsync(request).Result;