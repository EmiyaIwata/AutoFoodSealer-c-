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
    /// ruler.xaml 的交互逻辑
    /// </summary>
    public partial class ruler : Window
    {
        private System.Timers.Timer timer;
        public static int number=0;
        public ruler()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
            language1way();

        }
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Colormingzi1.Color = color.colorname;
        }
        private labelchanged Colormingzi1 = new labelchanged();
        private void changebutton_Click(object sender, RoutedEventArgs e)
        {
            if(foodchange1.Text=="1")
            {
                if(foodnamechange1.Text!="")
                {
                    Food1.Food1name = foodnamechange1.Text;
                }
                if(fooddatechange1.Text!="")
                {
                    Food1.Food1date = fooddatechange1.Text;
                }
                if(foodsourcechange1.Text!="")
                {
                    Food1.Food1source = foodsourcechange1.Text;
                }
                if(foodintroducechage1.Text!="")
                {
                    Food1.Food1intro = foodintroducechage1.Text;
                }
                if(foodnumberchange1.Text!="")
                {
                    Food1.Food1num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "2")
            {
                if (foodnamechange1.Text != "")
                {
                    food2.food2name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food2.food2date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food2.food2source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food2.food2intoduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food2.food2num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "3")
            {
                if (foodnamechange1.Text != "")
                {
                    food3.food3name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food3.food3date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food3.food3source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food3.food3introduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food3.food3num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "4")
            {
                if (foodnamechange1.Text != "")
                {
                    food4.food4name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food4.food4date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food4.food4source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food4.food4intorduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food4.food4num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "5")
            {
                if (foodnamechange1.Text != "")
                {
                    food5.food5name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food5.food5date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food5.food5source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food5.food5intorduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food5.food5num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "6")
            {
                if (foodnamechange1.Text != "")
                {
                    food6.food6name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food6.food6date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food6.food6source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food6.food6intorduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food6.food6num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "7")
            {
                if (foodnamechange1.Text != "")
                {
                    food7.food7name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food7.food7date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food7.food7source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food7.food7intorduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food7.food7num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "8")
            {
                if (foodnamechange1.Text != "")
                {
                    food8.food8name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food8.food8date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food8.food8source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food8.food8intorduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food8.food8num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if (foodchange1.Text == "9")
            {
                if (foodnamechange1.Text != "")
                {
                    food9.food9name = foodnamechange1.Text;
                }
                if (fooddatechange1.Text != "")
                {
                    food9.food9date = fooddatechange1.Text;
                }
                if (foodsourcechange1.Text != "")
                {
                    food9.food9source = foodsourcechange1.Text;
                }
                if (foodintroducechage1.Text != "")
                {
                    food9.food9intorduce = foodintroducechage1.Text;
                }
                if (foodnumberchange1.Text != "")
                {
                    food9.food9num = foodnumberchange1.Text;
                }
                MessageBox.Show("已更改成功");
                number = 1;
            }
            if(Food1.Food1num!="0")
            {
                
            }
            if(number!=1)
            {
                MessageBox.Show("没有输入");
            }
        }

        private void receivecolorbutton_Click(object sender, RoutedEventArgs e)
        {
            grid.DataContext = Colormingzi1;
            Colormingzi1.Color = color.colorname;
        }

        private void angleok_Click(object sender, RoutedEventArgs e)
        {
            if (anglexuhao.Text == "1")
            {
                if (angleinput.Text != "")
                {
                    Food1.Food1angle = angleinput.Text;
                    MessageBox.Show("已经修改成功");
                }
            }
            if (anglexuhao.Text == "2")
            {
                if (angleinput.Text != "")
                {
                    food2.food2angle = angleinput.Text;
                    MessageBox.Show("已经修改成功");
                }
            }
            if (anglexuhao.Text == "3")
            {
                if (angleinput.Text != "")
                {
                    food3.food3angle = angleinput.Text;
                    MessageBox.Show("已经修改成功");
                }
            }
            if (anglexuhao.Text == "4")
            {
                if (angleinput.Text != "")
                {
                    food4.food4angle = angleinput.Text;
                    MessageBox.Show("已经修改成功");
                }
            }
            if (anglexuhao.Text == "5")
            {
                if (angleinput.Text != "")
                {
                    food5.food5angle = angleinput.Text;
                    MessageBox.Show("已经修改成功");
                }
            }
            if (anglexuhao.Text == "6")
            {
                if (angleinput.Text != "")
                {
                    food6.food6angle = angleinput.Text;
                    MessageBox.Show("已经修改成功");
                }
            }
        }
        public void language1way()
        {
            if (language.language1 =="Chinese")
            {
                helloblock.Text = "你吼啊";
                xuhaoblock.Text = "食物编号";
                nameblock.Text = "名称";
                dateblock.Text = "日期";
                sourceblock.Text = "过敏原";
                introduceblock.Text = "介绍";
                numblock.Text = "数量";
                xuhao1block.Text = "序号";
                jiaodublock.Text = "角度";
                angleok.Content = "确定";
                changebutton.Content = "确定";
                receivecolorbutton.Content = "开始接受";
                receivecolorbutton.FontSize = 12;

            }
            if(language.language1=="English")
            {
                helloblock.Text = "Hello!";
                xuhaoblock.Text = "INDIFIER";
                nameblock.Text = "NAME";
                dateblock.Text = "DATE";
                sourceblock.Text = "SOURCE";
                introduceblock.Text = "INTRO";
                numblock.Text = "NUMBER";
                xuhao1block.Text = "INDIFIER";
                jiaodublock.Text = "ANGLE";
                angleok.Content = "OK!";
                changebutton.Content = "OK!";
                receivecolorbutton.Content = "LINK START";
                receivecolorbutton.FontSize = 8;

            }
        }

        private void mainmotorun_Click(object sender, RoutedEventArgs e)
        {
           
                motor.motor1 = 1;
            
            
        }

        private void thesecondmotorun_Click(object sender, RoutedEventArgs e)
        {
   
                motor.motor2 = 1;

        }

        private void thethirdmotorun_Click(object sender, RoutedEventArgs e)
        {

                motor.motor3 = 1;
  
        }
    }
}
