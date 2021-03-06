﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rafy.WPF;

namespace JXC.WPF
{
    /// <summary>
    /// Interaction logic for BillLayout.xaml
    /// </summary>
    public partial class BillLayout : UserControl, ILayoutControl
    {
        public BillLayout()
        {
            InitializeComponent();
        }

        public void Arrange(UIComponents components)
        {
            var control = components.Main;
            if (control != null) { content.Content = control.Control; }

            control = components.CommandsContainer;
            if (control != null) { commands.Content = control.Control; }

            components.ArrangeChildrenByTabControl(childrenTab);
        }
    }
}
