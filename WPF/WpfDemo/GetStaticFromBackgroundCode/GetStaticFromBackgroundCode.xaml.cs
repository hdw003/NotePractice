﻿using System;
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

namespace WpfDemo.GetStaticFromBackgroundCode
{
    /// <summary>
    /// GetStaticFromBackgroundCode.xaml 的交互逻辑
    /// </summary>
    public partial class GetStaticFromBackgroundCode : Window
    {
        public static string Name = "这是来自后台的静态变量";
        public GetStaticFromBackgroundCode()
        {
            InitializeComponent();
        }
    }
}
