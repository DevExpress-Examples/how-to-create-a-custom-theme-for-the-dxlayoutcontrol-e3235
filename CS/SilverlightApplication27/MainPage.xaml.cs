using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace SilverlightApplication27 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e) {
            Theme theme = new Theme("testTheme", new Uri("/SilverlightApplication27;component/DevExpress.Xpf.LayoutControl/Office2007.Silverlight.xaml", UriKind.Relative)) { IsStandard = false, FullName = "Test Theme" };
            ThemeManager.ApplicationTheme = theme;
        }
    }
}
