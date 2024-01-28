using System.Linq;
using System.Windows.Forms;

namespace WordAddIn2
{
    public class LoginManager
    {
        public bool AuthenticateUser(out string username)
        {
            using (LoginForm loginForm = new LoginForm())
            {
                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    username = loginForm.Username;
                    string password = loginForm.Password;
            
                    return IsValidLogin(username, password);
                }
                else
                {
                    username = null;
                    return false;
                }
            }
        }
       
        private bool IsValidLogin(string username, string password)
        {
            // 在这里添加实际的登录验证逻辑
            // 返回 true 表示验证通过，返回 false 表示验证失败           
            return username == "admin" && password == "password";
        }
    }
}
