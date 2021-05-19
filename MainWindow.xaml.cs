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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameOfThrones.DelegateAndEvents;

namespace GameOfThrones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var hardHome = new HardhomeBattleV2();
            //hardHome.HardhomeEldersMeetingEvent();
            hardHome.HardhomeEldersMeetingEvent += () =>
            {
                MessageBox.Show("I got notified that Hardhome elders meeting had occurred","V2");
            };
            hardHome.StartAct();
            MessageBox.Show(hardHome.ActStarted.ToString(),"V2");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var hardHome = new HardhomeBattleV1();
            //hardHome.HardhomeEldersMeetingDelegate();
            hardHome.HardhomeEldersMeetingDelegate += () =>
            {
                MessageBox.Show("I got notified that Hardhome elders meeting had occurred","V1");
            };
            hardHome.StartAct();
            MessageBox.Show(hardHome.ActStarted.ToString(),"V1");
        }
    }
}
