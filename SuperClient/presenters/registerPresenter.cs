using Newtonsoft.Json;
using SuperClient.models;
using SuperClient.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.presenters
{
    internal class registerPresenter: IregisterPresenter
    {
        IregisterView view;
        registerModel model;

        public registerPresenter(IregisterView view)
        {
            this.view = view;
            this.model = new registerModel();
        }
        public async Task Register(string name, string pass)
        {
            HttpClient httpClient = new HttpClient();
            var body = new 
            {
                nickName = name,
                password = pass,
            };
            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody,Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://localhost:5221/login", content);
            if (response.IsSuccessStatusCode == true)
            {
                var data = await response.Content.ReadAsStringAsync();
                var _headers = JsonConvert.DeserializeObject<headers>(data);
                headers.header.sessionId = _headers.sessionId;
                headers.header.userId = _headers.userId;
            }
      

        }
    }
}
