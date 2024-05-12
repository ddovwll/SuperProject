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
    internal class AllPostsPresenter : IAllPostsPresenter
    {
        IAllPostsView view;
        string result;

        public AllPostsPresenter(IAllPostsView view)
        {
            this.view = view;
        }

        public string resultAuth { get => result; set => value = result; }

        public async Task AllPosts()
        {
            using HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync("http://localhost:5221/post/all");

            int statusCode = (int)response.StatusCode;

            switch (statusCode)
            {
                case 401:
                    result = "отсутствует один из заголовков или id пользователя не соответствует id сессии";
                    // BadRequest
                    break;
                case 200:
                    // Чтение содержимого ответа
                    string data = await response.Content.ReadAsStringAsync();

                    result = "ok";
                    break;
                default:
                    result = "ошибка";
                    // Обработка других кодов состояния
                    break;
            }
        }
    }
}
