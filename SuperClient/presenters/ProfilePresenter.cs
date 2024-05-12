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
    internal class ProfilePresenter: IProfilePresenter
    {
        IProfileView view;
        Post model;
        string result;

        public ProfilePresenter(IProfileView view)
        {
            this.view = view;
            this.model = new Post();
        }

        public string resultAuth { get => result; set => value = result; }

        public async Task CreatePost(string header, string text, int userId, string userName)
        {
            using HttpClient httpClient = new HttpClient();

            var body = new
            {
                header = model.header,
                text = model.text,
                userId = headers.header.userId,
                userName = headers.header.NickName,
            };

            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:5221/post/create", content);

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков, заголовок UserId не соответствует userId из тела запроса или id пользователя не соответствует id сессии";
                    // BadRequest
                    break;
                case 400:
                    result = "пустые или отсутствующие поля";
                    //NotFound
                    break;
                case 200:
                    // Получение данных из ответа
                    var data = await response.Content.ReadAsStringAsync();

                    // Десериализация JSON данных в объект Post
                    var _headers = JsonConvert.DeserializeObject<Post>(data);

                    result = "ok";
                    break;
                // Другие возможные коды состояния...
                default:
                    result = "ошибка";
                    // Обработка других кодов состояния
                    break;
            }
        }
    }
}
