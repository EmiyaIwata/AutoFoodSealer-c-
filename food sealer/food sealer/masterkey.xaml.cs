using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace food_sealer
{
    /// <summary>
    /// masterkey.xaml 的交互逻辑
    /// </summary>
    public partial class masterkey : Window
    {
        public masterkey()
        {
            InitializeComponent();
            if (language.language1 == "English")
            {
                usernameblock.Text = "USERNAME";
                passwordblock.Text = "PASSWORD";
                buttonloginin.Content = "LOGIN IN";
            }
            if(language.language1=="Chinese")
            {
                usernameblock.Text = "用户名";
                passwordblock.Text = "密码";
                buttonloginin.Content = "登陆";
            }

        }

        private void buttonloginin_Click(object sender, RoutedEventArgs e)
        {
            if(textboxUserName.Text=="admin"&&textboxPassword.Password=="password")
            {
                ruler ruler = new ruler();
                ruler.Show();
                this.Close();
            }
            else
            {
                if (language.language1 == "Chinese")
                {
                    MessageBox.Show("用户名或者密码错误");
                }
                if(language.language1=="English")
                {
                    MessageBox.Show("Username or password error!!");
                }
            }
        }
    }
}
