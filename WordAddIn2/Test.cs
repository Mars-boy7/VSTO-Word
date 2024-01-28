using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using Task = System.Threading.Tasks.Task;

public class Test
{
    public static async Task Main(string userInput)
    {
        try
        {
            Test testInstance = new Test();

            // 调用 GenerateTextAsync 方法
            await testInstance.GenerateTextAsync(userInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"发生错误: {ex.Message}");
        }
    }

    public async Task GenerateTextAsync(string userInput)
    {
        try
        {
            using (var httpClient = new HttpClient())
            {
                // 生成的 API 接口
                var apiUrl = "http://115.156.114.150:7861/chat/chat";
                // 请求体 JSON
                var requestBody = $@"{{
                    ""query"": ""{userInput}"",                      
                    ""stream"": true,
                    ""model_name"": ""Qwen-14B-Chat"",
                    ""temperature"": 0.1,
                    ""max_tokens"": 0,
                    ""prompt_name"": ""default""
                }}";

                // 使用 StringContent 封装 POST 内容体
                var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                
                // 调用 HttpClient 类的 POST 方法，获取响应 JSON
                using (var response = await httpClient.PostAsync(apiUrl, content))
                {
                    Console.WriteLine($"状态码: {response.StatusCode}");

                    // 流式读取响应内容
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            string line;
                            while ((line = await reader.ReadLineAsync()) != null)
                            {
                                Console.WriteLine($"响应内容:\n{line}");
                                // 插入文本到 Word 文档
                                await InsertTextIntoWordDocumentFromJson(line);
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"发生错误: {ex.Message}");
        }
    }

    private async Task InsertTextIntoWordDocumentFromJson(string responseContent)
    {
        try
        {
            // 获取 Word 应用程序的运行实例
            Application wordApp = null;
            try
            {
                wordApp = (Application)System.Runtime.InteropServices.Marshal.GetActiveObject("Word.Application");
            }
            catch
            {
                // 处理 Word 未运行的情况
                Console.WriteLine("Word 未运行或没有活动文档。");
                return;
            }

            // 使 Word 应用程序可见
            wordApp.Visible = true;

            // 获取活动文档
            Document doc = wordApp.ActiveDocument;

            // 解析响应内容，提取 "text" 字段的值
            var lines = responseContent.Split('\n');
            foreach (var line in lines)
            {
                try
                {
                    // 提取 "text" 字段的值
                    if (line.StartsWith("data: "))
                    {
                        var jsonData = line.Substring("data: ".Length).Trim();
                        // 代码的其余部分
                        var textValue = ExtractTextValue(jsonData);
                        // 在当前内容之后插入字符
                        Range range = doc.Range();
                        range.InsertAfter(textValue);
                        //// 在当前插入点(光标)插入字符
                        //Selection selection = wordApp.Selection;
                        //selection.TypeText(textValue);

                        // 添加延迟以模拟打字机效果（根据需要调整延迟）
                        await Task.Delay(20);
                    }
                }
                catch (Exception ex)
                {
                    // 输出异常信息
                    Console.WriteLine($"异常：{ex.Message}");
                    Console.WriteLine($"异常发生在以下行：\n{line}");
                }
            }

            Console.WriteLine("文本成功插入 Word 文档。");
        }
        catch (Exception ex)
        {
            // 处理任何异常
            Console.WriteLine($"错误：{ex.Message}");
        }
    }

    private string ExtractTextValue(string jsonData)
    {
        try
        {
            // 使用 JSON 库解析 JSON 数据
            dynamic jsonObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);

            // 确保 jsonObject 中存在 "text" 字段
            if (jsonObject != null && jsonObject.text != null)
            {
                // 提取 "text" 字段的值
                var textValue = jsonObject.text;
                return textValue;
            }
            else
            {
                // 处理 "text" 字段不存在的情况
                Console.WriteLine("错误：在 JSON 数据中未找到 'text' 字段。");
                return string.Empty; // 或者根据需求进行处理
            }
        }
        catch (Newtonsoft.Json.JsonReaderException ex)
        {
            // 处理 JSON 解析异常
            Console.WriteLine($"解析 JSON 时发生错误：{ex.Message}");
            return string.Empty; // 或者根据需求进行处理
        }
    }

}
