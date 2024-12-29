using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Net.Http.Headers;
using DE_WEB.Interface;
using DE_WEB.Entities;
namespace DE_WEB.Models;

public class UsuarioModel : IUsuarioModel
{
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;
    private readonly IHttpContextAccessor _HttpContextAccessor;
    private string url_Api;
    public UsuarioModel(IConfiguration configuration, HttpClient httpClient, IHttpContextAccessor HttpContextAccessor)
    {
        _configuration = configuration;
        _httpClient = httpClient;
        _HttpContextAccessor = HttpContextAccessor;
        url_Api = _configuration.GetSection("Llaves:UrlApi").Value;
    }

    public int SignUp(UsuarioEnt usuario)
    {
        string url = url_Api + "api/Login/SignUp";
        JsonContent obj = JsonContent.Create(usuario);
        var resp = _httpClient.PostAsync(url, obj).Result;

        if (resp.IsSuccessStatusCode)
            return resp.Content.ReadFromJsonAsync<int>().Result;
        else
            return 0;
    }

    public UsuarioEnt? SignIn(UsuarioEnt usuario)
    {
        string url = url_Api + "api/Login/SignIn";
        JsonContent obj = JsonContent.Create(usuario);
        var resp = _httpClient.PostAsync(url, obj).Result;

        if (resp.IsSuccessStatusCode)
            return resp.Content.ReadFromJsonAsync<UsuarioEnt>().Result;
        else
            return null;
    }
}
