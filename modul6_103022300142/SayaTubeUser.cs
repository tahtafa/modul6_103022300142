using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300142
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            Username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                
                totalPlayCount += video.GetPlayCount();
            }
            return totalPlayCount;
        }

        public void AddVideo(SayaTubeVideo video) { 
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            int count = 0;
            Console.WriteLine("User: " + Username);
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                count++;
                Console.WriteLine("Video " + count + " Judul: " + video.GetTitle());
            }
            
            
        }
    }
}
