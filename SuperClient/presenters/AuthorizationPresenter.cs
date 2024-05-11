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
    internal class AuthorizationPresenter : IAuthorizationPresenter
    {
        IAuthorizationView view;
        AuthorizationModel model;
        string result;

        public AuthorizationPresenter(IAuthorizationView view)
        {
            this.view = view;
            //result = "ok";
            this.model = new AuthorizationModel();
        }

        public string resultAuth { get => result; set => value = result; }

        public async Task Authorization(string name, string pass)
        {
            using HttpClient httpClient = new HttpClient();

            var body = new
            {
                nickName = name,
                password = pass,
            };
            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:5221/login", content);

            int statusCode = (int)response.StatusCode;
            switch (statusCode)
            {
                case 400:
                    result = "неверный логин или пароль";
                    // BadRequest
                    break;
                case 409:
                    result = "юзера с таким именем нет";
                    //NotFound
                    break;
                case 404:
                    result = "юзера с таким именем нет";
                    //NotFound
                    break;
                case 200:
                    // Получение данных из ответа
                    var data = await response.Content.ReadAsStringAsync();

                    // Десериализация JSON данных в объект headers
                    var _headers = JsonConvert.DeserializeObject<headers>(data);

                    // Сохранение данных сессии в заголовках для последующих запросов
                    headers.header.sessionId = _headers.sessionId;
                    headers.header.userId = _headers.userId;
                    result = "ok";
                    break;
                // Другие возможные коды состояния...
                default:
                    result = "ошибкааа";
                    // Обработка других кодов состояния
                    break;
            }
            
        }
    }
}
