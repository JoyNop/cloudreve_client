using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chromium.Event;
using NetDimension.NanUI;
using System.Diagnostics;

namespace cloudreve
{
    public partial class Form1 : Formium
    {
        public Form1()
            : base("https://up.uno.moe/cloudreve_client/v1_beta_0_1.html")//
        {
            InitializeComponent();
            //获取键盘按下的key值
            Chromium.KeyboardHandler.OnKeyEvent += KeyboardHandler_OnKeyEvent;
        }
        #region 获取键盘按下的key值      

        /// <summary>
        /// 获取键盘按下的key值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardHandler_OnKeyEvent(object sender, CfxOnKeyEventEventArgs e)
        {
            {
                if (e.Event.WindowsKeyCode == 123) //F12
                {
                    Chromium.ShowDevTools();
                }
                if (e.Event.WindowsKeyCode == 116) //F5
                {

                }
            }
        }

        #endregion

    }
}
