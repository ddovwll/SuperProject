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
    internal class registerPresenter : IregisterPresenter
    {
        IregisterView view;
        registerModel model;
        string result;

        public registerPresenter(IregisterView view)
        {
            this.view = view;
            this.model = new registerModel();
            this.result = "ok";
        }

        string IregisterPresenter.resultRegistr { get => result; set => value = result; }

        public async Task Register(string name, string pass)
        {
            // Создание HTTP клиента для отправки запросов на сервер
            using HttpClient httpClient = new HttpClient();

            // Создание тела запроса в формате JSON
            var body = new
            {
                nickName = name,
                password = pass,
            };
            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            // Отправка POST запроса на сервер
            var response = await httpClient.PostAsync("http://localhost:5221/login", content);

            int statusCode = (int)response.StatusCode;
            switch (statusCode)
            {
                case 400:
                    result = "пустые или отсутствующие поля";
                    // BadRequest
                    break;
                case 409:
                    result = "юзер с таким именем существует";
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

            // Если запрос выполнен успешно
            /*if (response.IsSuccessStatusCode == true)
            {
                // Получение данных из ответа
                var data = await response.Content.ReadAsStringAsync();

                // Десериализация JSON данных в объект headers
                var _headers = JsonConvert.DeserializeObject<headers>(data);

                // Сохранение данных сессии в заголовках для последующих запросов
                headers.header.sessionId = _headers.sessionId;
                headers.header.userId = _headers.userId;
            }
            else
            {
                result = "ошибкааа";
            }
            */
            // Добавление заголовков userId и sessionId для последующих запросов
            httpClient.DefaultRequestHeaders.Add("userId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("sessionId", headers.header.sessionId.ToString());
        }
    }
}
