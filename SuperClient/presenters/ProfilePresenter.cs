using Newtonsoft.Json;
using SuperClient.models;
using SuperClient.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public async Task CreatePost(string header, string text, int userId) // добавление поста
        {
            model.header = header;
            model.text = text;
            model.userId = userId;
            model.userName = headers.header.NickName;
            model.likesCount = 0;

            using HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("UserId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("SessionId", headers.header.sessionId.ToString());

            var body = new
            {
                header = model.header,
                text = model.text,
                userId = headers.header.userId,
            };

            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:5221/post/create", content);

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков, заголовок UserId не соответствует userId из тела запроса или id пользователя не соответствует id сессии";
                    // Unauthorized 
                    break;
                case 400:
                    result = "пустые или отсутствующие поля";
                    // BadRequest 
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

        public async Task<List<Post>> UserPosts(string nickname) // все посты пользователя
        {
            nickname = headers.header.NickName;

            using HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("UserId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("SessionId", headers.header.sessionId.ToString());

            var response = await httpClient.GetAsync("http://localhost:5221/post/user/" + nickname);

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков или id пользователя не соответствует id сессии";
                    // Unauthorized 
                    break;
                case 200:
                    // Получение данных из ответа
                    var data = await response.Content.ReadAsStringAsync();

                    // Десериализация JSON данных в объект List<Post>
                    var posts = JsonConvert.DeserializeObject<List<Post>>(data);
                    result = "ok";
                    return posts;
                // Другие возможные коды состояния...
                default:
                    result = "ошибка";
                    // Обработка других кодов состояния
                    break;
            }

            return null; 
        }

        public async Task DeletePost(int id) // удаление поста
        {
            using HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("UserId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("SessionId", headers.header.sessionId.ToString());

            var response = await httpClient.DeleteAsync("http://localhost:5221/post/delete/" + id.ToString());

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков или пост не принадлежит пользователю или id пользователя не соответствует id сессии";
                    // Unauthorized 
                    break;
                case 404:
                    result = "пост не найден";
                    // NotFound
                    break;
                case 200:
                    result = "ok";
                    break;
                // Другие возможные коды состояния...
                default:
                    result = "ошибка";
                    // Обработка других кодов состояния
                    break;
            }
        }

        public async Task UpdatePost(int id, string header, string text) // изменение поста
        {
            model.header = header;
            model.text = text;
            model.id = id;

            using HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("UserId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("SessionId", headers.header.sessionId.ToString());

            var body = new
            {
                id = model.id,
                header = model.header,
                text = model.text,
            };

            string jsonBody = JsonConvert.SerializeObject(body);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:5221/post/update", content);

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков или пост не принадлежит пользователю или поста не существует или id пользователя не соответствует id сессии";
                    // Unauthorized 
                    break;
                case 400:
                    result = "пустые или отсутствующие поля";
                    // BadRequest 
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
