using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _42Email发送邮件
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage emial = new MailMessage();
                emial.BodyEncoding = Encoding.UTF8;
                MailAddress address = new MailAddress("xiaozixiang@MyTest.com");
                emial.From = address;

                emial.To.Add(new MailAddress("test@MyTest.com"));
                //MailAddressCollection mac = new MailAddressCollection();
                //mac.Add("test@MyTest.com");
                ////.To="test@MyTest.com"
                //mac = emial.To;

                emial.Subject = "用于测试";
                emial.IsBodyHtml = true;
                emial.HeadersEncoding = Encoding.UTF8;

                StringBuilder sb = new StringBuilder();
                sb.Append("<html>");
                sb.Append(" <head>");
                sb.Append("  <title>");
                sb.Append("          测试");
                sb.Append("   </title>");
                sb.Append("<style>  .c1{width:100px}  </style>");
                sb.Append(" </head>");
                sb.Append("<body>");
                sb.Append(" <table border='1' cellpadding='0' cellspacing='0' style='text-align:center'>");
                sb.Append("  <tr style='color:red'> <th>学号</th><th>姓名</th><th>年龄</th></tr>");
                sb.Append("<tr><td class='c1'>14203139</td><td>肖自翔</td><td>23</td></tr>");
                sb.Append("<tr><td class='c1'>14203139</td><td>肖自翔</td><td>23</td></tr>");
                sb.Append("<tr><td class='c1'>14203139</td><td>肖自翔</td><td>23</td></tr>");
                sb.Append("<tr><td class='c1'>14203139</td><td>肖自翔</td><td>23</td></tr>");
                sb.Append("<tr><td class='c1'>14203139</td><td>肖自翔</td><td>23</td></tr>");
                sb.Append("</table>");


                sb.Append("</body>");


                sb.Append("</html>");

                emial.Body = sb.ToString();

                SmtpClient sc = new SmtpClient("192.168.1.100",25);
                sc.Credentials = new System.Net.NetworkCredential("xiaozixiang@MyTest.com", "123456");
                sc.Send(emial);
                Console.WriteLine("发送邮件成功！！");
                Console.ReadKey();
                
            }
            catch {
                int i = 0;
            }
           
        }
    }
}
