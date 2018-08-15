using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace food_sealer
{
    public class labelchanged : INotifyPropertyChanged
    {
        public  String colorname1 = "";
        public String Color
        {
            set
            {
                colorname1 = value;
                if (PropertyChanged != null)//有改变  
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Color"));//对Color进行监听  
                }
            }
            get
            {
                return colorname1;
            }
            //*************************************************************************
            
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }


    
    }  

