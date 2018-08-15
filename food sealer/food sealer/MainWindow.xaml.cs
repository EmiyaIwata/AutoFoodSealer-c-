using System;
using System.IO.Ports;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;




namespace food_sealer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string  choosefood=null;
        public static int fasongzhuangtai=0;
        public static int chooesfoodnum;//所选的食物的序号
        public static string sendnum="";//发送的内容
        public static int xuanze1num=0;//选择1号食物的数量
        public static int xuanze2num=0;//选择2号食物的数量
        public static int xuanze3num=0;//选择3号食物的数量
        public static int xuanze4num=0;//选择4号食物的数量
        public static int xuanze5num=0;//选择5号食物的数量
        public static int xuanze6num=0;//选择5号食物的数量
        public static int xuanzesuliang = 0;//点击按键的次数
        //public static string foodchoosekind1=null;
        //public static string foodchoosekind2=null;
        //public static string foodchoosekind3 = null;
        //public static string foodchoosekind4 = null;
        //public static string foodchoosekind5 = null;
        //public static string foodchoosekind6 = null;
        //public static string[] foodchoosenames { get; set; }//选择食物的数组
        public SerialPort ComPort = new SerialPort();
        public string[] portNames { get; set; }
        bool openFlag = false;
         //************************************************************************************
       public delegate void HandleInterfaceUpdataDelegate(string text);
        public HandleInterfaceUpdataDelegate interfaceUpdataHandle;
        //***********************************************************************************
        public void GetPort()
        {
            portNames = SerialPort.GetPortNames();                      //得到可用串口
        }//得到串口的名字  
        public void OpenPort()
        {
            if (portNames == null)
            {
                GetPort();
            }
            if (openFlag == false)
            {
                try
                {
                    //设置
                    ComPort.PortName = portNames[0].ToString();
                    ComPort.BaudRate = 115200;
                    ComPort.Parity = Parity.None;
                    ComPort.StopBits = StopBits.One;
                    ComPort.DataBits = 8;
                    ComPort.Handshake = Handshake.None;
                    // ComPort.RtsEnable = true;

                    ComPort.Open();
                    openFlag = true;
                }
                catch
                {
                    MessageBox.Show("打开mcu失败，请检查连接" +
                        "Port error!!");
                }
            }
        }
        //************************************************************************************
        // 发送可修改的地方
        //检查是否有货，选货时实现数量变化(v1.x版本功能，2.x版本不适用）
        //public void ways()
        //{
        //    if (foodchoose.foodchoosekind6!=null)
        //    {
        //        for (int i = 0; i < foodchoose.foodchoosekind6num; i++)
        //        {
        //                   sendnum = foodchoose.foodchoosekind6angle;
        //                    Serial();
        //        }
        //    }
            //if (choosefood == Food1.Food1name)
            //{
            //    chooesfoodnum = int.Parse(Food1.Food1num);
            //    if (chooesfoodnum != 0)
            //    {
            //        chooesfoodnum = chooesfoodnum - xuanze1num;
            //        Food1.Food1num = chooesfoodnum.ToString();
            //        sendnum = Food1.Food1angle;
            //        Serial();
            //    }
            //    else
            //    {
            //        if (language.language1 == "Chinese")
            //        {
            //            MessageBox.Show("没货了");
            //        }
            //        if (language.language1 == "English")
            //        {
            //            MessageBox.Show("No food!!");
            //        }
            //    }
            //}
            //if (choosefood == food2.food2name)
            //{
            //    chooesfoodnum = int.Parse(food2.food2num);
            //    if (chooesfoodnum != 0)
            //    {
            //        chooesfoodnum = chooesfoodnum - 1;
            //        food2.food2num = chooesfoodnum.ToString();
            //        sendnum = food2.food2angle;
            //        Serial();
            //    }
            //    else
            //    {
            //        if (language.language1 == "Chinese")
            //        {
            //            MessageBox.Show("没货了");
            //        }
            //        if (language.language1 == "English")
            //        {
            //            MessageBox.Show("No food!!");
            //        }
            //    }
            //}
            //if (choosefood == food3.food3name)
            //{
            //    chooesfoodnum = int.Parse(food3.food3num);
            //    if (chooesfoodnum != 0)
            //    {
            //        chooesfoodnum = chooesfoodnum - 1;
            //        food3.food3num = chooesfoodnum.ToString();
            //        sendnum = food3.food3angle;
            //        Serial();
            //    }
            //    else
            //    {
            //        if (language.language1 == "Chinese")
            //        {
            //            MessageBox.Show("没货了");
            //        }
            //        if (language.language1 == "English")
            //        {
            //            MessageBox.Show("No food!!");
            //        }
            //    }
            //}
            //if (choosefood == food4.food4name)
            //{
            //    chooesfoodnum = int.Parse(food4.food4num);
            //    if (chooesfoodnum != 0)
            //    {
            //        chooesfoodnum = chooesfoodnum - 1;
            //        food4.food4num = chooesfoodnum.ToString();
            //        sendnum = food4.food4angle;
            //        Serial();
            //    }
            //    else
            //    {
            //        if (language.language1 == "Chinese")
            //        {
            //            MessageBox.Show("没货了");
            //        }
            //        if (language.language1 == "English")
            //        {
            //            MessageBox.Show("No food!!");
            //        }
            //    }
            //}
            //if (choosefood == food5.food5name)
            //{
            //    chooesfoodnum = int.Parse(food5.food5num);
            //    if (chooesfoodnum != 0)
            //    {
            //        chooesfoodnum = chooesfoodnum - 1;
            //        food5.food5num = chooesfoodnum.ToString();
            //        sendnum = food5.food5angle;
            //        Serial();
            //    }
            //    else
            //    {
            //        if (language.language1 == "Chinese")
            //        {
            //            MessageBox.Show("没货了");
            //        }
            //        if (language.language1 == "English")
            //        {
            //            MessageBox.Show("No food!!");
            //        }
            //    }
            //}
            //if (choosefood == food6.food6name)
            //{
            //    chooesfoodnum = int.Parse(food6.food6num);
            //    if (chooesfoodnum != 0)
            //    {
            //        chooesfoodnum = chooesfoodnum - 1;
            //        food6.food6num = chooesfoodnum.ToString();
            //        sendnum = food6.food6angle;
            //        Serial();
            //    }
            //    else
            //    {
            //        if (language.language1 == "Chinese")
            //        {
            //            MessageBox.Show("没货了");
            //        }
            //        if (language.language1 == "English")
            //        {
            //            MessageBox.Show("No food!!");
            //        }
            //    }
            //}
            //if (chooesfoodnum != 0)
            //{
            //    if (language.language1 == "Chinese")
            //    {
            //        MessageBox.Show("您已经选择" + choosefood + "。正在出货，请稍等");
            //    }
            //    if (language.language1 == "English")
            //    {
            //        MessageBox.Show("You have choosen" + choosefood + "。porting,wait please.");
            //    }

            //}
        //}//*********************************************************************************************************************************************
        public void antikindfoodways()
        {
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if(Food1.Food1shunxu==1)
            {
                foodchoose.foodchoosekind1num = xuanze1num;
                foodchoose.foodchoosekind1 = Food1.Food1name+"x"+ foodchoose.foodchoosekind1num + " ";
                foodchoose.foodchoosekind1angle = Food1.Food1angle;
                
            }
            if (Food1.Food1shunxu == 2)
            {
                foodchoose.foodchoosekind2num = xuanze1num;
                foodchoose.foodchoosekind2 = Food1.Food1name + "x" + foodchoose.foodchoosekind2num + " ";
                foodchoose.foodchoosekind2angle = Food1.Food1angle;
            }
            if (Food1.Food1shunxu == 3)
            {
                foodchoose.foodchoosekind3num = xuanze1num;
                foodchoose.foodchoosekind3 = Food1.Food1name + "x" + foodchoose.foodchoosekind3num + " ";
                foodchoose.foodchoosekind3angle = Food1.Food1angle;
            }
            if (Food1.Food1shunxu == 4)
            {
                foodchoose.foodchoosekind4num = xuanze1num;
                foodchoose.foodchoosekind4 = Food1.Food1name + "x" + foodchoose.foodchoosekind4num + " ";
                foodchoose.foodchoosekind4angle = Food1.Food1angle;
            }
            if (Food1.Food1shunxu == 5)
            {
                foodchoose.foodchoosekind5num = xuanze1num;
                foodchoose.foodchoosekind5 = Food1.Food1name + "x" + foodchoose.foodchoosekind5num + " ";
                foodchoose.foodchoosekind5angle = Food1.Food1angle;
            }
            if (Food1.Food1shunxu == 6)
            {
                foodchoose.foodchoosekind6num = xuanze1num;
                foodchoose.foodchoosekind6 = Food1.Food1name + "x" + foodchoose.foodchoosekind6num + " ";
                foodchoose.foodchoosekind6angle = Food1.Food1angle;
            }
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if(food2.food2shunxu==1)
            {
                foodchoose.foodchoosekind1num = xuanze2num;
                foodchoose.foodchoosekind1 = food2.food2name+"x"+ foodchoose.foodchoosekind1num + " ";
                foodchoose.foodchoosekind1angle = food2.food2angle;
            }
            if (food2.food2shunxu == 2)
            {
                foodchoose.foodchoosekind2num = xuanze2num;
                foodchoose.foodchoosekind2 = food2.food2name + "x" + foodchoose.foodchoosekind2num + " ";
                foodchoose.foodchoosekind2angle = food2.food2angle;
            }
            if (food2.food2shunxu == 3)
            {
                foodchoose.foodchoosekind3num = xuanze2num;
                foodchoose.foodchoosekind3 = food2.food2name + "x" + foodchoose.foodchoosekind3num + " ";
                foodchoose.foodchoosekind3angle = food2.food2angle;
            }
            if (food2.food2shunxu == 4)
            {
                foodchoose.foodchoosekind4num = xuanze2num;
                foodchoose.foodchoosekind4 = food2.food2name + "x" + foodchoose.foodchoosekind4num + " ";
                foodchoose.foodchoosekind4angle = food2.food2angle;
            }
            if (food2.food2shunxu == 5)
            {
                foodchoose.foodchoosekind5num = xuanze2num;
                foodchoose.foodchoosekind5 = food2.food2name + "x" + foodchoose.foodchoosekind5num + " ";
                foodchoose.foodchoosekind5angle = food2.food2angle;
            }
            if (food2.food2shunxu == 6)
            {
                foodchoose.foodchoosekind6num = xuanze2num;
                foodchoose.foodchoosekind6 = food2.food2name + "x" + foodchoose.foodchoosekind6num + " ";
                foodchoose.foodchoosekind6angle = food2.food2angle;
            }
            //%^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            //if (Food1.Food1shunxu == 1)
            //{
            //    foodchoose.foodchoosekind1num = xuanze1num;
            //    //foodchoose.foodchoosekind1 = Food1.Food1name + "x" + foodchoose.foodchoosekind1num + " ";
            //    foodchoose.foodchoosekind1angle = food3.food3angle;

            //}
            //if (Food1.Food1shunxu == 2)
            //{
            //    foodchoose.foodchoosekind2num = xuanze1num;
            //    foodchoose.foodchoosekind2 = Food1.Food1name + "x" + foodchoose.foodchoosekind2num + " ";
            //    foodchoose.foodchoosekind2angle = food3.food3angle;

            //}
            //if (Food1.Food1shunxu == 3)
            //{
            //    foodchoose.foodchoosekind3num = xuanze1num;
            //    foodchoose.foodchoosekind3 = Food1.Food1name + "x" + foodchoose.foodchoosekind3num + " ";
            //    foodchoose.foodchoosekind3angle = food3.food3angle;

            //}
            //if (Food1.Food1shunxu == 4)
            //{
            //    foodchoose.foodchoosekind4num = xuanze1num;
            //    foodchoose.foodchoosekind4 = Food1.Food1name + "x" + foodchoose.foodchoosekind4num + " ";
            //    foodchoose.foodchoosekind4angle = food3.food3angle;
            //}
            //if (Food1.Food1shunxu == 5)
            //{
            //    foodchoose.foodchoosekind5num = xuanze1num;
            //    foodchoose.foodchoosekind5 = Food1.Food1name + "x" + foodchoose.foodchoosekind5num + " ";
            //    foodchoose.foodchoosekind5angle = food3.food3angle;
            //}
            //if (Food1.Food1shunxu == 6)
            //{
            //    foodchoose.foodchoosekind6num = xuanze1num;
            //    foodchoose.foodchoosekind6 = Food1.Food1name + "x" + foodchoose.foodchoosekind6num + " ";
            //    foodchoose.foodchoosekind6angle = food3.food3angle;
            //}
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (food3.food3shunxu == 1)
            {
                foodchoose.foodchoosekind1num = xuanze3num;
                foodchoose.foodchoosekind1 = food3.food3name+"x" + foodchoose.foodchoosekind1num + " ";
                foodchoose.foodchoosekind1angle = food3.food3angle;
            }
            if (food3.food3shunxu == 2)
            {
                foodchoose.foodchoosekind2num = xuanze3num;
                foodchoose.foodchoosekind2 = food3.food3name + "x" + foodchoose.foodchoosekind2num + " ";
                foodchoose.foodchoosekind2angle = food3.food3angle;
            }
            if (food3.food3shunxu == 3)
            {
                foodchoose.foodchoosekind3num = xuanze3num;
                foodchoose.foodchoosekind3 = food3.food3name + "x" + foodchoose.foodchoosekind3num + " ";
                foodchoose.foodchoosekind3angle = food3.food3angle;
            }
            if (food3.food3shunxu == 4)
            {
                foodchoose.foodchoosekind4num = xuanze3num;
                foodchoose.foodchoosekind4 = food3.food3name + "x" + foodchoose.foodchoosekind4num + " ";
                foodchoose.foodchoosekind4angle = food3.food3angle;
            }
            if (food3.food3shunxu == 5)
            {
                foodchoose.foodchoosekind5num = xuanze3num;
                foodchoose.foodchoosekind5 = food3.food3name + "x" + foodchoose.foodchoosekind5num + " ";
                foodchoose.foodchoosekind5angle = food3.food3angle;
            }
            if (food3.food3shunxu == 6)
            {
                foodchoose.foodchoosekind6num = xuanze3num;
                foodchoose.foodchoosekind6 = food3.food3name + "x" + foodchoose.foodchoosekind6num + " ";
                foodchoose.foodchoosekind6angle = food3.food3angle;
            }
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (food4.food4shunxu == 1)
            {
                foodchoose.foodchoosekind1num = xuanze4num;
                foodchoose.foodchoosekind1 = food4.food4name+"x" + foodchoose.foodchoosekind1num + " ";
               foodchoose.foodchoosekind1angle = food4.food4angle;
            }
            if (food4.food4shunxu == 2)
            {
                foodchoose.foodchoosekind2num = xuanze4num;
                foodchoose.foodchoosekind2 = food4.food4name + "x" + foodchoose.foodchoosekind2num + " ";
                foodchoose.foodchoosekind2angle = food4.food4angle;
            }
            if (food4.food4shunxu == 3)
            {
                foodchoose.foodchoosekind3num = xuanze4num;
                foodchoose.foodchoosekind3 = food4.food4name + "x" + foodchoose.foodchoosekind3num + " ";
                foodchoose.foodchoosekind3angle = food4.food4angle;
            }
            if (food4.food4shunxu == 4)
            {
                foodchoose.foodchoosekind4num = xuanze4num;
                foodchoose.foodchoosekind4 = food4.food4name + "x" + foodchoose.foodchoosekind4num + " ";
                foodchoose.foodchoosekind4angle = food4.food4angle;
            }
            if (food4.food4shunxu == 5)
            {
                foodchoose.foodchoosekind5num = xuanze4num;
                foodchoose.foodchoosekind5 = food4.food4name + "x" + foodchoose.foodchoosekind5num + " ";
                foodchoose.foodchoosekind5angle = food4.food4angle;
            }
            if (food4.food4shunxu == 6)
            {
                foodchoose.foodchoosekind6num = xuanze4num;
                foodchoose.foodchoosekind6 = food4.food4name + "x" + foodchoose.foodchoosekind6num + " ";
                foodchoose.foodchoosekind6angle = food4.food4angle;
            }
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (food5.food5shunxu == 1)
            {
                foodchoose.foodchoosekind1num = xuanze5num;
                foodchoose.foodchoosekind1 = food5.food5name+"x"+ foodchoose.foodchoosekind1num + " ";
                foodchoose.foodchoosekind1angle = food5.food5angle;
            }
            if (food5.food5shunxu == 2)
            {
                foodchoose.foodchoosekind2num = xuanze5num;
                foodchoose.foodchoosekind2 = food5.food5name + "x" + foodchoose.foodchoosekind2num + " ";
                foodchoose.foodchoosekind2angle = food5.food5angle;
            }
            if (food5.food5shunxu == 3)
            {
                foodchoose.foodchoosekind3num = xuanze5num;
                foodchoose.foodchoosekind3 = food5.food5name + "x" + foodchoose.foodchoosekind3num + " ";
                foodchoose.foodchoosekind3angle = food5.food5angle;
            }
            if (food5.food5shunxu == 4)
            {
                foodchoose.foodchoosekind4num = xuanze5num;
                foodchoose.foodchoosekind4 = food5.food5name + "x" + foodchoose.foodchoosekind4num + " ";
                foodchoose.foodchoosekind4angle = food5.food5angle;
            }
            if (food5.food5shunxu == 5)
            {
                foodchoose.foodchoosekind5num = xuanze5num;
                foodchoose.foodchoosekind5 = food5.food5name + "x" + foodchoose.foodchoosekind5num + " ";
                foodchoose.foodchoosekind5angle = food5.food5angle;
            }
            if (food5.food5shunxu == 6)
            {
                foodchoose.foodchoosekind6num = xuanze5num;
                foodchoose.foodchoosekind6 = food5.food5name + "x" + foodchoose.foodchoosekind6num + " ";
                foodchoose.foodchoosekind6angle = food5.food5angle;
            }
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (food6.food6shunxu == 1)
            {
                foodchoose.foodchoosekind1num = xuanze6num;
                foodchoose.foodchoosekind1 = food6.food6name+"x"+ foodchoose.foodchoosekind1num + " ";
                foodchoose.foodchoosekind1angle = food6.food6angle;
            }
            if (food6.food6shunxu == 2)
            {
                foodchoose.foodchoosekind2num = xuanze6num;
                foodchoose.foodchoosekind2 = food6.food6name + "x" + foodchoose.foodchoosekind2num + " ";
                foodchoose.foodchoosekind2angle = food6.food6angle;
            }
            if (food6.food6shunxu == 3)
            {
                foodchoose.foodchoosekind3num = xuanze6num;
                foodchoose.foodchoosekind3 = food6.food6name + "x" + foodchoose.foodchoosekind3num + " ";
                foodchoose.foodchoosekind3angle = food6.food6angle;
            }
            if (food6.food6shunxu == 4)
            {
                foodchoose.foodchoosekind4num = xuanze6num;
                foodchoose.foodchoosekind4 = food6.food6name + "x" + foodchoose.foodchoosekind4num + " ";
                foodchoose.foodchoosekind4angle = food6.food6angle;
            }
            if (food6.food6shunxu == 5)
            {
                foodchoose.foodchoosekind5num = xuanze6num;
                foodchoose.foodchoosekind5 = food6.food6name + "x" + foodchoose.foodchoosekind5num + " ";
                foodchoose.foodchoosekind5angle = food6.food6angle;
            }
            if (food6.food6shunxu == 6)
            {
                foodchoose.foodchoosekind6num = xuanze6num;
                foodchoose.foodchoosekind6 = food6.food6name + "x" + foodchoose.foodchoosekind6num + " ";
                foodchoose.foodchoosekind6angle = food6.food6angle;
            }
            if(foodchoose.foodchoosekind6num==0)
            {
                foodchoose.foodchoosekind6 = null;
                foodchoose.foodchoosekind6angle = null;
            }
            if (foodchoose.foodchoosekind5num == 0)
            {
                foodchoose.foodchoosekind5 = null;
                foodchoose.foodchoosekind5angle = null;
            }
            if (foodchoose.foodchoosekind4num == 0)
            {
                foodchoose.foodchoosekind4 = null;
                foodchoose.foodchoosekind4angle = null;
            }
            if (foodchoose.foodchoosekind3num == 0)
            {
                foodchoose.foodchoosekind3 = null;
                foodchoose.foodchoosekind3angle = null;
            }
            if (foodchoose.foodchoosekind2num == 0)
            {
                foodchoose.foodchoosekind2 = null;
                foodchoose.foodchoosekind2angle = null;
            }
            if (foodchoose.foodchoosekind1num == 0)
            {
                foodchoose.foodchoosekind1 = null;
                foodchoose.foodchoosekind1angle = null;
            }

                if (foodchoose.foodchoosekind1num != 0)
                {
                    testblockresult.Text = "已经选择" + foodchoose.foodchoosekind1 + foodchoose.foodchoosekind2 + foodchoose.foodchoosekind3 + foodchoose.foodchoosekind4 + foodchoose.foodchoosekind5 + foodchoose.foodchoosekind6;
                }
                else
                {
                    testblockresult.Text = "";
                }
            
          
        }
        //******************************************************************
        public void toumingmieihuo()
        {
            if (Food1.Food1num == "0")
            {
                food1image.Opacity = 0.5;

            }
            if (Food1.Food1num != "0")
            {
                food1image.Opacity = 1;
            }
            if (food2.food2num == "0")
            {
                food2image.Opacity = 0.5;

            }
            if (food2.food2num != "0")
            {
                food2image.Opacity = 1;
            }
            if (food3.food3num == "0")
            {
                food3image.Opacity = 0.5;

            }
            if (food3.food3num != "0")
            {
                food3image.Opacity = 1;
            }
            if (food4.food4num == "0")
            {
                food4image.Opacity = 0.5;

            }
            if (food4.food4num != "0")
            {
                food4image.Opacity = 1;
            }
            if (food5.food5num == "0")
            {
                food5image.Opacity = 0.5;

            }
            if (food5.food5num != "0")
            {
                food5image.Opacity = 1;
            }
            if (food6.food6num == "0")
            {
                food6image.Opacity = 0.5;

            }
            if (food6.food6num != "0")
            {
                food6image.Opacity = 1;
            }
        }//没货透明
        //*********************************************************************************************************************************************************
        public void Serial()//接受发送
        {
            ComPort.DataReceived += new SerialDataReceivedEventHandler(Sp_DataReceived);
            if (!ComPort.IsOpen)
            {
                ComPort.Open();
            }
            //用字节的形式发送数据
            SendBytesData(ComPort);
        }
        public void SendBytesData(SerialPort comport)//发送
        {

            byte[] bytesSend = System.Text.Encoding.Default.GetBytes(sendnum);
            comport.Write(bytesSend, 0, bytesSend.Length);

        }
        public void Sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)//接受
        {
            /* byte[] readBuffer = new byte[Sp.ReadBufferSize];
             Sp.Read(readBuffer, 0, readBuffer.Length);
             //Dispatcher.Invoke(interfaceUpdataHandle, new string[]{ Encoding.UTF8.GetString(readBuffer)});
             Dispatcher.Invoke(interfaceUpdataHandle, new string[] { Encoding.ASCII.GetString(readBuffer) });
             //Dispatcher.Invoke(interfaceUpdateHandle, new string[] { Encoding.ASCII.GetString(buf) });*/

            SerialPort serialPort = (SerialPort)(sender);
            System.Threading.Thread.Sleep(100);//延缓一会，用于防止硬件发送速率跟不上缓存数据导致的缓存数据杂乱
            int n = serialPort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
            //received_count += n;//增加接收计数  
            serialPort.Read(buf, 0, n);//读取缓冲数据  
            //因为要访问ui资源，所以需要使用invoke方式同步ui
            interfaceUpdataHandle = new HandleInterfaceUpdataDelegate(receiveways);//实例化委托对象
            // Dispatcher.Invoke(interfaceUpdateHandle, new string[] { Encoding.ASCII.GetString(buf) });
            Dispatcher.Invoke(interfaceUpdataHandle, new string[] { Encoding.ASCII.GetString(buf) });

            //serialPort.Close();
        }
        //*********************************************************************************************************************************************
        //接收（可以修改的地方）
        private void receiveways(string text)
        {
            //MessageBox.Show(text);
            
            String Receive = Convert.ToString(text);
            String Receive1="";
            //String Receive2="";
            //String Receive3="";
            //String Receive4="";
            if (Receive != "")
            {
                //MessageBox.Show("Receive1");
                 Receive1 = Receive.Substring(0, 1);
            }
            color.colorname = Receive1;
            if (Receive1 == "g")
            {
                color.colorname = "无";
            }
            if(Receive1=="a")
            {
                color.colorname = "绿";
            }
            if(Receive1=="b")
            {
                color.colorname = "蓝";
            }
            if(Receive1=="c")
            {
                color.colorname = "黄";
            }
            if(Receive1 == "d")
            {
                color.colorname = "紫";
            }
            if (Receive1 == "e")
            {
                color.colorname = "粉";
            }
            if(Receive1 == "f")
            {
                color.colorname = "红";
            }
            


        }
        //******************************************************************************************************************

        //**************************************************************************************************************************************************************************************************
        //事件
       private System.Timers.Timer timer;
        private System.Timers.Timer timer1;
        public MainWindow()
        {
            InitializeComponent();
            if (openFlag == false)
            {
                GetPort();
                OpenPort();
            }
            Serial();
            timer = new System.Timers.Timer(1000);
            timer1 = new System.Timers.Timer(500);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer_motor);
            timer.Enabled = true;
            timer1.Enabled = true;
        }
        void timer_motor(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(motor.motor1==1)
            {
                sendnum = "z";
                motor.motor1 = 0;
                Serial();
            }
            else
            {
                sendnum = "";
                Serial();
            }
            if (motor.motor2 == 1)
            {
                sendnum = "x";
                motor.motor2= 0;
                Serial();
            }
            else
            {
                sendnum = "";
                Serial();
            }
            if (motor.motor3 == 1)
            {
                sendnum = "y";
                motor.motor3 = 0;
                Serial();
            }
            else
            {
                sendnum = "";
                Serial();
            }

        }
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (fasongzhuangtai == 1)
            {
                if (foodchoose.foodchoosekind6 != null)
                {
                    sendnum = foodchoose.foodchoosekind6angle;
                    foodchoose.foodchoosekind6num = foodchoose.foodchoosekind6num - 1;
                    Serial();
                    if (foodchoose.foodchoosekind6num == 0)
                    {
                        foodchoose.foodchoosekind6 = null;
                    }
                }
                else
                {
                    if (foodchoose.foodchoosekind5 != null)
                    {
                        sendnum = foodchoose.foodchoosekind5angle;
                        foodchoose.foodchoosekind5num = foodchoose.foodchoosekind5num - 1;
                        Serial();
                        if (foodchoose.foodchoosekind5num == 0)
                        {
                            foodchoose.foodchoosekind5 = null;
                        }
                    }
                    else
                    {
                        if (foodchoose.foodchoosekind4 != null)
                        {
                            sendnum = foodchoose.foodchoosekind4angle;
                            foodchoose.foodchoosekind4num = foodchoose.foodchoosekind4num - 1;
                            Serial();
                            if (foodchoose.foodchoosekind4num == 0)
                            {
                                foodchoose.foodchoosekind4 = null;
                            }
                        }
                        else
                        {
                            if (foodchoose.foodchoosekind3 != null)
                            {
                                sendnum = foodchoose.foodchoosekind3angle;
                                foodchoose.foodchoosekind3num = foodchoose.foodchoosekind3num - 1;
                                Serial();
                                if (foodchoose.foodchoosekind3num == 0)
                                {
                                    foodchoose.foodchoosekind3 = null;
                                }
                            }
                            else
                            {
                                if (foodchoose.foodchoosekind2 != null)
                                {
                                    sendnum = foodchoose.foodchoosekind2angle;
                                    foodchoose.foodchoosekind2num = foodchoose.foodchoosekind2num - 1;
                                    Serial();
                                    if (foodchoose.foodchoosekind2num == 0)
                                    {
                                        foodchoose.foodchoosekind2 = null;
                                    }
                                }
                                else
                                {
                                    if (foodchoose.foodchoosekind1 != null)
                                    {
                                        sendnum = foodchoose.foodchoosekind1angle;
                                        foodchoose.foodchoosekind1num = foodchoose.foodchoosekind1num - 1;
                                        Serial();
                                        if (foodchoose.foodchoosekind1num == 0)
                                        {
                                            foodchoose.foodchoosekind1 = null;
                                            choosefood = null;
                                        }
                                    }
                                    else
                                    {
                                        sendnum = "";
                                        fasongzhuangtai = 0;
                                        xuanze1num = 0;
                                        xuanze2num = 0;
                                        xuanze3num = 0;
                                        xuanze4num = 0;
                                        xuanze5num = 0;
                                        xuanze6num = 0;
                                        xuanzesuliang = 0;

                                    }
                                }

                            }
                        }
                    }
                }
            }
        }
        //***************************************************************************************************************************************************************************************************
        private void maibutton_Click(object sender, RoutedEventArgs e)
        {

            if (choosefood == null)
            {
                if (language.language1 == "Chinese")
                {
                    MessageBox.Show("请选择食品");
                }
                if (language.language1 == "English")
                {
                    MessageBox.Show("Please choose food!");
                }

            }
            else
            {
                //ways();
                fasongzhuangtai = 1;
                testblockresult.Text = "";
                int num1;
                int num2;
                int num3;
                int num4;
                int num5;
                int num6;

                num1 = int.Parse(Food1.Food1num) - xuanze1num;
                num2 = int.Parse(food2.food2num) - xuanze2num;
                num3 = int.Parse(food3.food3num) - xuanze3num;
                num4 = int.Parse(food4.food4num) - xuanze4num;
                num5 = int.Parse(food5.food5num) - xuanze5num;
                num6 = int.Parse(food6.food6num) - xuanze6num;
                Food1.Food1num = Convert.ToString(num1);
                food2.food2num = Convert.ToString(num2);
                food3.food3num = Convert.ToString(num3);
                food4.food4num = Convert.ToString(num4);
                food5.food5num = Convert.ToString(num5);
                food6.food6num = Convert.ToString(num6);


                //choosefood = null;
                // byte[] send_data = new byte[1];
                // send_data[0] =0x31;
                //sendData(send_data);

            }
        }









        private void food1button_MouseEnter(object sender, MouseEventArgs e)
        {
            textblockname.Text = Food1.Food1name;
            textblockdate.Text = Food1.Food1date;
            textblocksource.Text = Food1.Food1source;
            textblockintroduce.Text = Food1.Food1intro;
            textblocknumber.Text = Food1.Food1num;
            if(Food1.Food1num=="0")
            {
                food1image.Opacity = 0.5;

            }
            if(Food1.Food1num!="0")
            {
                food1image.Opacity = 1;
            }
        }

        private void food1button_MouseLeave(object sender, MouseEventArgs e)
        {
            textblockname.Text = "";
            textblockdate.Text = "";
            textblocksource.Text = "";
            textblockintroduce.Text = "";
            textblocknumber.Text = "";
        }

        private void food1button_Click(object sender, RoutedEventArgs e)
        {
            choosefood = Food1.Food1name;
           if(xuanze1num==0)
            {
                xuanzesuliang = xuanzesuliang + 1;
                Food1.Food1shunxu = xuanzesuliang;
            }
            xuanze1num = xuanze1num + 1;
            if (xuanze1num > int.Parse(Food1.Food1num))
            {
                xuanze1num = int.Parse(Food1.Food1num);
            }
            else
            {
                antikindfoodways();
                //if (language.language1 == "Chinese")
                //{
                //    testblockresult.Text = "  已经选择" + Food1.Food1name + "x" + xuanze1num;
                //}
                //if (language.language1 == "English")
                //{
                //    testblockresult.Text = "  You have choosen" + Food1.Food1name+"x"+xuanze1num;
                //}
            }
        }
        private void food2button_Click(object sender, RoutedEventArgs e)
        {
            choosefood = food2.food2name;
            if(xuanze2num==0)
            {
                xuanzesuliang = xuanzesuliang + 1;
                food2.food2shunxu = xuanzesuliang;
            }
            xuanze2num = xuanze2num + 1;
            if(xuanze2num>int.Parse(food2.food2num))
            {
                xuanze2num = int.Parse(food2.food2num);
            }
            else
            {
                antikindfoodways();
            }
            //if (language.language1 == "Chinese")
            //{
            //    testblockresult.Text = "  已经选择" + food2.food2name;
            //}
            //if (language.language1 == "English")
            //{
            //    testblockresult.Text = "  You have choosen" + food2.food2name;
            //}
            //choosefood = food2.food2name;
        }

        private void food2button_MouseEnter(object sender, MouseEventArgs e)
        {
            textblockname.Text = food2.food2name;
            textblockdate.Text = food2.food2date;
            textblocksource.Text = food2.food2source;
            textblockintroduce.Text = food2.food2intoduce;
            textblocknumber.Text = food2.food2num;
            if (food2.food2num == "0")
            {
                food2image.Opacity = 0.5;

            }
            if (food2.food2num != "0")
            {
                food2image.Opacity = 1;
            }
        }

        private void food2button_MouseLeave(object sender, MouseEventArgs e)
        {
            textblockname.Text = "";
            textblockdate.Text = "";
            textblocksource.Text = "";
            textblockintroduce.Text = "";
            textblocknumber.Text = "";
        }

        private void food3button_Click(object sender, RoutedEventArgs e)
        {
            choosefood = food3.food3name;
            if (xuanze3num == 0)
            {
                xuanzesuliang = xuanzesuliang + 1;
                food3.food3shunxu = xuanzesuliang;
            }
            xuanze3num = xuanze3num + 1;
            if (xuanze3num > int.Parse(food3.food3num))
            {
                xuanze3num = int.Parse(food3.food3num);
            }
            else
            {
                antikindfoodways();
            }
            //if (language.language1 == "Chinese")
            //{
            //    testblockresult.Text = "  已经选择" + food3.food3name;
            //}
            //if (language.language1 == "English")
            //{
            //    testblockresult.Text = "  You have choosen" + food3.food3name;
            //}
            //choosefood = food3.food3name;
        }

        private void food3button_MouseEnter(object sender, MouseEventArgs e)
        {
          
            textblockname.Text = food3.food3name;
            textblockdate.Text = food3.food3date;
            textblocksource.Text = food3.food3source;
            textblockintroduce.Text = food3.food3introduce;
            textblocknumber.Text = food3.food3num;
            if (food3.food3num == "0")
            {
                food3image.Opacity = 0.5;
      
            }
            if (food3.food3num != "0")
            {
                food3image.Opacity = 1;
            }
        }

        private void food3button_MouseLeave(object sender, MouseEventArgs e)
        {
            textblockname.Text = "";
            textblockdate.Text = "";
            textblocksource.Text = "";
            textblockintroduce.Text = "";
            textblocknumber.Text = "";
        }

        private void buttonmasterkey_Click(object sender, RoutedEventArgs e)
        {
            masterkey masterkey = new masterkey();
            masterkey.ShowDialog();
        }

        private void food4button_Click(object sender, RoutedEventArgs e)
        {
            choosefood = food4.food4name;
            if (xuanze4num == 0)
            {
                xuanzesuliang = xuanzesuliang + 1;
                food4.food4shunxu = xuanzesuliang;
            }
            xuanze4num = xuanze4num + 1;
            if (xuanze4num > int.Parse(food4.food4num))
            {
                xuanze4num = int.Parse(food4.food4num);
            }
            else
            {
                antikindfoodways();
            }
            //if (language.language1 == "Chinese")
            //{
            //    testblockresult.Text = "  已经选择" + food4.food4name;
            //}
            //if (language.language1 == "English")
            //{
            //    testblockresult.Text = "  You have choosen" + food4.food4name;
            //}

            //choosefood = food4.food4name;
        }
        
        private void food4button_MouseEnter(object sender, MouseEventArgs e)
        {
            textblockname.Text = food4.food4name;
            textblockdate.Text = food4.food4date;
            textblocksource.Text = food4.food4source;
            textblockintroduce.Text = food4.food4intorduce;
            textblocknumber.Text = food4.food4num;
            if (food4.food4num == "0")
            {
                food4image.Opacity = 0.5;
              
            }
            if (food4.food4num != "0")
            {
                food4image.Opacity = 1;
            }
        }

        private void food4button_MouseLeave(object sender, MouseEventArgs e)
        {
            textblockname.Text = "";
            textblockdate.Text = "";
            textblocksource.Text = "";
            textblockintroduce.Text = "";
            textblocknumber.Text = "";
        }

        private void food5button_Click(object sender, RoutedEventArgs e)
        {
            choosefood = food5.food5name;
            if (xuanze5num == 0)
            {
                xuanzesuliang = xuanzesuliang + 1;
                food5.food5shunxu = xuanzesuliang;
            }
            xuanze5num = xuanze5num + 1;
            if (xuanze5num > int.Parse(food5.food5num))
            {
                xuanze5num = int.Parse(food5.food5num);
            }
            else
            {
                antikindfoodways();
            }
            //if (language.language1 == "Chinese")
            //{
            //    testblockresult.Text = "  已经选择" + food5.food5name;
            //}
            //if (language.language1 == "English")
            //{
            //    testblockresult.Text = "  You have choosen" + food5.food5name;
            //}

            //choosefood = food5.food5name;
        }

        private void food5button_MouseEnter(object sender, MouseEventArgs e)
        {
            textblockname.Text = food5.food5name;
            textblockdate.Text = food5.food5date;
            textblocksource.Text = food5.food5source;
            textblockintroduce.Text = food5.food5intorduce;
            textblocknumber.Text = food5.food5num;
            if (food5.food5num == "0")
            {
                food5image.Opacity = 0.5;
       
            }
            if (food5.food5num != "0")
            {
                food5image.Opacity = 1;
            }
        }

        private void food5button_MouseLeave(object sender, MouseEventArgs e)
        {
            textblockname.Text = "";
            textblockdate.Text = "";
            textblocksource.Text = "";
            textblockintroduce.Text = "";
            textblocknumber.Text = "";
        }

        private void food6button_Click(object sender, RoutedEventArgs e)
        {
            choosefood = food6.food6name;
            if (xuanze6num == 0)
            {
                xuanzesuliang = xuanzesuliang + 1;
                food6.food6shunxu = xuanzesuliang;
            }
            xuanze6num = xuanze6num + 1;
            if (xuanze6num > int.Parse(food6.food6num))
            {
                xuanze6num = int.Parse(food6.food6num);
            }
            else
            {
                antikindfoodways();
            }
            //if (language.language1 == "Chinese")
            //{
            //    testblockresult.Text = "  已经选择" + food6.food6name;
            //}
            //if (language.language1 == "English")
            //{
            //    testblockresult.Text = "  You have choosen" + food6.food6name;
            //}
            //choosefood = food6.food6name;
        }

        private void food6button_MouseEnter(object sender, MouseEventArgs e)
        {
            textblockname.Text = food6.food6name;
            textblockdate.Text = food6.food6date;
            textblocksource.Text = food6.food6source;
            textblockintroduce.Text = food6.food6intorduce;
            textblocknumber.Text = food6.food6num;
            if (food6.food6num == "0")
            {
                food6image.Opacity = 0.5;
       
            }
            if (food6.food6num != "0")
            {
                food6image.Opacity = 1;
            }
        }

        private void food6button_MouseLeave(object sender, MouseEventArgs e)
        {
            textblockname.Text = "";
            textblockdate.Text = "";
            textblocksource.Text = "";
            textblockintroduce.Text = "";
            textblocknumber.Text = "";
        }

       
        

        private void mainwindowpic_MouseMove(object sender, MouseEventArgs e)
        {
            toumingmieihuo();
           
        }

        private void buttonmasterkey_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonmasterkey.Opacity = 1;
        }

        private void buttonmasterkey_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonmasterkey.Opacity = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                if(language.language1=="Chinese")
                {
                    language.language1 = "English";
                    languagebutton.Content = "中文";
                    languageway();
                }
                else
                {
                    if(language.language1=="English")
                    {
                        language.language1 = "Chinese";
                        languagebutton.Content = "English";
                        languageway();
                    }
                }
            }
        }
        public void languageway()
        {
            if(language.language1=="Chinese")
            {
                 foodnameblock.Text = "   名称:";
                
                fooddateblock.Text = "   生产日期:";
                foodintroblock.Text = "   介绍:";
                foodnumblock.Text = "   余量:";
                foodsourceblock.Text = "   过敏原:";
                maibutton.Content = "买买买";
                foodnameblock.FontSize = 20;
                fooddateblock.FontSize = 20;
                foodintroblock.FontSize = 20;
                foodsourceblock.FontSize = 20;
                foodnumblock.FontSize = 20;
            }
            if(language.language1=="English")
            {
               
                foodnameblock.Text = "  NAME:";
                foodnameblock.FontSize = 15;
                fooddateblock.Text = "  DATE:";
                fooddateblock.FontSize=15;
                foodintroblock.Text = "  INTORDUCE:";
                foodintroblock.FontSize = 15;
                foodsourceblock.Text = "  SOURCE:";
                foodsourceblock.FontSize=15;
                foodnumblock.Text = "  NUMBER:";
                foodnumblock.FontSize = 15;
                maibutton.Content = "BUY!!";
            }
        }

        private void testblockresult_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(xuanzesuliang==6)
            {
                foodchoose.foodchoosekind6num = foodchoose.foodchoosekind6num - 1;
                if (Food1.Food1shunxu == 6)
                {
                    xuanze1num = xuanze1num-1;
                }
                if (food2.food2shunxu == 6)
                {
                    xuanze2num = xuanze2num-1;
                }
                if (food3.food3shunxu == 6)
                {
                    xuanze3num = xuanze3num-1;
                }
                if (food4.food4shunxu == 6)
                {
                    xuanze4num = xuanze4num-1;
                }
                if (food5.food5shunxu == 6)
                {
                    xuanze5num = xuanze5num-1;
                }
                if (food6.food6shunxu == 6)
                {
                    xuanze6num = xuanze6num-1;
                }
                if (foodchoose.foodchoosekind6num==0)
                {
                    xuanzesuliang = 5;
                    if(Food1.Food1shunxu==6)
                    {
                        Food1.Food1shunxu = 0;
                        xuanze1num = 0;
                    }
                    if(food2.food2shunxu==6)
                    {
                        food2.food2shunxu = 0;
                        xuanze2num = 0;
                    }
                    if (food3.food3shunxu == 6)
                    {
                        food3.food3shunxu = 0;
                        xuanze3num = 0;
                    }
                    if (food4.food4shunxu == 6)
                    {
                        food4.food4shunxu = 0;
                        xuanze4num = 0;
                    }
                    if (food5.food5shunxu == 6)
                    {
                        food5.food5shunxu = 0;
                        xuanze5num = 0;
                    }
                    if (food6.food6shunxu == 6)
                    {
                        food6.food6shunxu = 0;
                        xuanze6num = 0;
                    }
                }
            }
            else if(xuanzesuliang==5)
            {
                foodchoose.foodchoosekind5num = foodchoose.foodchoosekind5num - 1;
                if (Food1.Food1shunxu == 5)
                {
                    xuanze1num = xuanze1num - 1;
                }
                if (food2.food2shunxu == 5)
                {
                    xuanze2num = xuanze2num - 1;
                }
                if (food3.food3shunxu == 5)
                {
                    xuanze3num = xuanze3num - 1;
                }
                if (food4.food4shunxu == 5)
                {
                    xuanze4num = xuanze4num - 1;
                }
                if (food5.food5shunxu == 5)
                {
                    xuanze5num = xuanze5num - 1;
                }
                if (food6.food6shunxu == 5)
                {
                    xuanze6num = xuanze6num - 1;
                }
                if (foodchoose.foodchoosekind5num==0)
                {
                    xuanzesuliang = 4;
                    if (Food1.Food1shunxu == 5)
                    {
                        Food1.Food1shunxu = 0;
                        xuanze1num = 0;
                    }
                    if (food2.food2shunxu == 5)
                    {
                        food2.food2shunxu = 0;
                        xuanze2num = 0;
                    }
                    if (food3.food3shunxu == 5)
                    {
                        food3.food3shunxu = 0;
                        xuanze3num = 0;
                    }
                    if (food4.food4shunxu == 5)
                    {
                        food4.food4shunxu = 0;
                        xuanze4num = 0;
                    }
                    if (food5.food5shunxu == 5)
                    {
                        food5.food5shunxu = 0;
                        xuanze5num = 0;
                    }
                    if (food6.food6shunxu == 5)
                    {
                        food6.food6shunxu = 0;
                        xuanze6num = 0;
                    }
                }
            }
            else if(xuanzesuliang==4)
            {
                foodchoose.foodchoosekind4num = foodchoose.foodchoosekind4num - 1;
                if (Food1.Food1shunxu == 4)
                {
                    xuanze1num = xuanze1num - 1;
                }
                if (food2.food2shunxu == 4)
                {
                    xuanze2num = xuanze2num - 1;
                }
                if (food3.food3shunxu == 4)
                {
                    xuanze3num = xuanze3num - 1;
                }
                if (food4.food4shunxu == 4)
                {
                    xuanze4num = xuanze4num - 1;
                }
                if (food5.food5shunxu == 4)
                {
                    xuanze5num = xuanze5num - 1;
                }
                if (food6.food6shunxu == 4)
                {
                    xuanze6num = xuanze6num - 1;
                }
                if (foodchoose.foodchoosekind4num == 0)
                {
                    xuanzesuliang = 3;
                    if (Food1.Food1shunxu == 4)
                    {
                        Food1.Food1shunxu = 0;
                        xuanze1num = 0;
                    }
                    if (food2.food2shunxu == 4)
                    {
                        food2.food2shunxu = 0;
                        xuanze2num = 0;
                    }
                    if (food3.food3shunxu == 4)
                    {
                        food3.food3shunxu = 0;
                        xuanze3num = 0;
                    }
                    if (food4.food4shunxu == 4)
                    {
                        food4.food4shunxu = 0;
                        xuanze4num = 0;
                    }
                    if (food5.food5shunxu == 4)
                    {
                        food5.food5shunxu = 0;
                        xuanze5num = 0;
                    }
                    if (food6.food6shunxu == 4)
                    {
                        food6.food6shunxu = 0;
                        xuanze6num = 0;
                    }
                }
            }
            else if(xuanzesuliang==3)
            {
                foodchoose.foodchoosekind3num = foodchoose.foodchoosekind3num - 1;
                if (Food1.Food1shunxu == 3)
                {
                    xuanze1num = xuanze1num - 1;
                }
                if (food2.food2shunxu == 3)
                {
                    xuanze2num = xuanze2num - 1;
                }
                if (food3.food3shunxu == 3)
                {
                    xuanze3num = xuanze3num - 1;
                }
                if (food4.food4shunxu == 3)
                {
                    xuanze4num = xuanze4num - 1;
                }
                if (food5.food5shunxu == 3)
                {
                    xuanze5num = xuanze5num - 1;
                }
                if (food6.food6shunxu == 3)
                {
                    xuanze6num = xuanze6num - 1;
                }
                if (foodchoose.foodchoosekind3num == 0)
                {
                    xuanzesuliang = 2;
                    if (Food1.Food1shunxu == 3)
                    {
                        Food1.Food1shunxu = 0;
                        xuanze1num = 0;
                    }
                    if (food2.food2shunxu == 3)
                    {
                        food2.food2shunxu = 0;
                        xuanze2num = 0;
                    }
                    if (food3.food3shunxu == 3)
                    {
                        food3.food3shunxu = 0;
                        xuanze3num = 0;
                    }
                    if (food4.food4shunxu == 3)
                    {
                        food4.food4shunxu = 0;
                        xuanze4num = 0;
                    }
                    if (food5.food5shunxu == 3)
                    {
                        food5.food5shunxu = 0;
                        xuanze5num = 0;
                    }
                    if (food6.food6shunxu == 3)
                    {
                        food6.food6shunxu = 0;
                        xuanze6num = 0;
                    }
                }
            }
            else if(xuanzesuliang==2)
            {
                foodchoose.foodchoosekind2num = foodchoose.foodchoosekind2num - 1;
                if (Food1.Food1shunxu == 2)
                {
                    xuanze1num = xuanze1num - 1;
                }
                if (food2.food2shunxu == 2)
                {
                    xuanze2num = xuanze2num - 1;
                }
                if (food3.food3shunxu == 2)
                {
                    xuanze3num = xuanze3num - 1;
                }
                if (food4.food4shunxu == 2)
                {
                    xuanze4num = xuanze4num - 1;
                }
                if (food5.food5shunxu == 2)
                {
                    xuanze5num = xuanze5num - 1;
                }
                if (food6.food6shunxu == 2)
                {
                    xuanze6num = xuanze6num - 1;
                }
                if (foodchoose.foodchoosekind2num == 0)
                {
                    xuanzesuliang = 1;
                    if (Food1.Food1shunxu == 2)
                    {
                        Food1.Food1shunxu = 0;
                        xuanze1num = 0;
                    }
                    if (food2.food2shunxu == 2)
                    {
                        food2.food2shunxu = 0;
                        xuanze2num = 0;
                    }
                    if (food3.food3shunxu == 2)
                    {
                        food3.food3shunxu = 0;
                        xuanze3num = 0;
                    }
                    if (food4.food4shunxu == 2)
                    {
                        food4.food4shunxu = 0;
                        xuanze4num = 0;
                    }
                    if (food5.food5shunxu == 2)
                    {
                        food5.food5shunxu = 0;
                        xuanze5num = 0;
                    }
                    if (food6.food6shunxu == 2)
                    {
                        food6.food6shunxu = 0;
                        xuanze6num = 0;
                    }
                }
            }
            else if(xuanzesuliang==1)
            {
                foodchoose.foodchoosekind1num = foodchoose.foodchoosekind1num - 1;
                if (Food1.Food1shunxu == 1)
                {
                    xuanze1num = xuanze1num - 1;
                }
                if (food2.food2shunxu == 1)
                {
                    xuanze2num = xuanze2num - 1;
                }
                if (food3.food3shunxu == 1)
                {
                    xuanze3num = xuanze3num - 1;
                }
                if (food4.food4shunxu == 1)
                {
                    xuanze4num = xuanze4num - 1;
                }
                if (food5.food5shunxu == 1)
                {
                    xuanze5num = xuanze5num - 1;
                }
                if (food6.food6shunxu == 1)
                {
                    xuanze6num = xuanze6num - 1;
                }
                if (foodchoose.foodchoosekind1num == 0)
                {
                    xuanzesuliang = 0;
                    if (Food1.Food1shunxu == 1)
                    {
                        Food1.Food1shunxu = 0;
                        xuanze1num = 0;
                    }
                    if (food2.food2shunxu == 1)
                    {
                        food2.food2shunxu = 0;
                        xuanze2num = 0;
                    }
                    if (food3.food3shunxu == 1)
                    {
                        food3.food3shunxu = 0;
                        xuanze3num = 0;
                    }
                    if (food4.food4shunxu == 1)
                    {
                        food4.food4shunxu = 0;
                        xuanze4num = 0;
                    }
                    if (food5.food5shunxu == 1)
                    {
                        food5.food5shunxu = 0;
                        xuanze5num = 0;
                    }
                    if (food6.food6shunxu == 1)
                    {
                        food6.food6shunxu = 0;
                        xuanze6num = 0;
                    }
                }

            }
            antikindfoodways();
        }

    }
}
