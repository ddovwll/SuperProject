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
    internal class LikedPostsPresenter
    {
        ILikedPostsView view;
        string result;

        public LikedPostsPresenter(ILikedPostsView view)
        {
            this.view = view;
        }
        public string resultAuth { get => result; set => value = result; }

        public async Task<List<Post>> LikedPosts() // все посты
        {
            using HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("UserId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("SessionId", headers.header.sessionId.ToString());

            var response = await httpClient.GetAsync("http://localhost:5221/likes");

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
        public async Task DeleteLike(int postId) // удаление лайка
        {
            using HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Add("UserId", headers.header.userId.ToString());
            httpClient.DefaultRequestHeaders.Add("SessionId", headers.header.sessionId.ToString());

            var response = await httpClient.DeleteAsync("http://localhost:5221/likes/" + postId.ToString());

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков или id пользователя не соответствует id сессии";
                    // Unauthorized 
                    break;
                case 409:
                    result = "На посте не стоит лайк";
                    // Conflict
                    break;
                case 200:
                    result = "ok";
                    break;
                // Другие возможные коды состояния
                default:
                    result = "ошибка";
                    // Обработка других кодов состояния
                    break;
            }
        }

    }
}
