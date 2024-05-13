using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClient.models
{
    public static class LikesHistory
    {
        private static LikeHistory likeHistory;

        static string filePath = "C:/Users/arish/Documents/GitHub/SuperProject/SuperClient/Resources/likehistory.json";

        public static void Initialize()
        {
            likeHistory = LoadLikeHistory();
            if (likeHistory == null)
            {
                likeHistory = new LikeHistory();
            }
        }

        public static void LikePost(int postId)
        {
            if (!likeHistory.PostLikes.ContainsKey(postId))
            {
                likeHistory.PostLikes[postId] = 0;
            }

            likeHistory.PostLikes[postId]++;
            SaveLikeHistory(); // сохранение данных после изменения
        }

        public static void UnlikePost(int postId)
        {
            if (likeHistory.PostLikes.ContainsKey(postId) && likeHistory.PostLikes[postId] > 0)
            {
                likeHistory.PostLikes[postId]--;
                SaveLikeHistory(); // сохранение данных после изменения
            }
        }

        private static void SaveLikeHistory()
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, likeHistory);
            }
        }

        private static LikeHistory LoadLikeHistory()
        {
            try
            {
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (LikeHistory)serializer.Deserialize(file, typeof(LikeHistory));
                }
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }

}
