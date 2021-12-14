using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.RegularExpressions;

namespace Business
{


    public class Program
        {

            public static int Main(string[] args)
            {


            //HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://www.taobao.com/");
            //Request.Timeout = 20 * 1000;//请求超时。
            //Request.AllowAutoRedirect = true; //网页自动跳转。
            //Request.UserAgent = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";//伪装成谷歌爬虫。
            //Request.Method = "GET"; //获取数据的方法。GET
            //                        //Request.Method = "POST";//POST
            //                        //Request.ContentType = "application/json";上传的格式JSON
            //Request.KeepAlive = true; //保持
            //HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            //using (StreamReader sReader = new StreamReader(Response.GetResponseStream(), Encoding.UTF8))
            //{
            //    String Htmlstring = sReader.ReadToEnd();
            //    Htmlstring = Regex.Replace(Htmlstring, @"\r", String.Empty, RegexOptions.IgnoreCase);
            //    Htmlstring = Regex.Replace(Htmlstring, @"\n", String.Empty, RegexOptions.IgnoreCase);
            //    Htmlstring = Regex.Replace(Htmlstring, @"<script[^>]*?>.*?</script>", String.Empty, RegexOptions.IgnoreCase);
            //    Htmlstring = Regex.Replace(Htmlstring, @"<head[^>]*?>.*?</head>", String.Empty, RegexOptions.IgnoreCase);
            //    Htmlstring = Regex.Replace(Htmlstring, @"<video[^>]*?>.*?</video>", String.Empty, RegexOptions.IgnoreCase);
            //    Htmlstring = Regex.Replace(Htmlstring, @"<p[^>]*?>.*?</p>", String.Empty, RegexOptions.IgnoreCase);

            //    string regexString = @"<\s*a\s+[^>]*href\s*=\s*[""'](?<HREF>[^""']*)[""'][^>]*>(?<IHTML>[\s\S]+?)<\s*/\s*a\s*>";
            //    Regex regex = new Regex(regexString, RegexOptions.IgnoreCase);
            //    MatchCollection matchs = regex.Matches(Htmlstring);
            //    foreach (Match match in matchs)
            //    {
            //        string match_string = match.Groups["HREF"].Value.ToLower();
            //        Console.WriteLine("超链接:" + match_string);
            //    }
            //    Console.ReadLine();
                //HtmlDocument htmlDoc = new HtmlDocument();
                //htmlDoc.LoadHtml(simpleCrawlResult.Contents);
                //HtmlNodeCollection liNodes = htmlDoc.DocumentNode.SelectSingleNode("//div[@id='pane-news']").SelectSingleNode("div[1]/ul[1]").SelectNodes("li");
                //if (liNodes != null && liNodes.Count > 0)
                //{
                //    for (int i = 0; i < liNodes.Count; i++)
                //    {
                //        string title = liNodes[i].SelectSingleNode("strong[1]/a[1]").InnerText.Trim();
                //        string href = liNodes[i].SelectSingleNode("strong[1]/a[1]").GetAttributeValue("href", "").Trim();
                //        Console.WriteLine("新闻标题：" + title + ",链接：" + href);
                //    }
                //}
            //}

        

       






































































            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Debug()
#else
                .MinimumLevel.Information()
#endif
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                    .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
                    .Enrich.FromLogContext()
                    .WriteTo.Async(c => c.File("Logs/logs.txt"))
#if DEBUG
                .WriteTo.Async(c => c.Console())
#endif
                .CreateLogger();

                try
                {
                    Log.Information("Starting Business.HttpApi.Host.");
                    CreateHostBuilder(args).Build().Run();
                    return 0;
                }
                catch (Exception ex)
                {
                    Log.Fatal(ex, "Host terminated unexpectedly!");
                    return 1;
                }
                finally
                {
                    Log.CloseAndFlush();
                }
            }

            internal static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureAppConfiguration(build =>
                    {
                        build.AddJsonFile("appsettings.secrets.json", optional: true);
                    })
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    })
                    .UseAutofac()
                    .UseSerilog();
        }

    }



