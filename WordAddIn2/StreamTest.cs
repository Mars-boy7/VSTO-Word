using System.IO;
using System.Net;
using System.Text;
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;

namespace WordAddIn2
{
    public class StreamTest
    {
        public void StreamToWord(string url, string filePath)
        {
            var postData = new
            {
                query = "简单输出一些内容，比如说龟兔赛跑的故事",
                stream = true,
                model_name = "Qwen-14B-Chat",
                temperature = 0.1,
                max_tokens = 0,
                prompt_name = "default"
            };

            string json = JsonConvert.SerializeObject(postData);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            byte[] byteData = Encoding.UTF8.GetBytes(json);
            request.ContentLength = byteData.Length;

            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                Application word = new Application();
                Document doc = word.Documents.Add();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        doc.Content.Text += line + "\n";
                    }
                }

                doc.SaveAs2(filePath);
                doc.Close();
                word.Quit();
            }
        }
    }
}
