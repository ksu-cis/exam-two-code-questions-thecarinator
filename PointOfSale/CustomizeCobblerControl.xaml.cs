using System;
using System.Collections.Generic;
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
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Cobbler c = (Cobbler)DataContext;
            switch (((RadioButton)sender).Name)
            {
                case "Peac":
                    c.Fruit = FruitFilling.Peach;
                    break;
                case "Blue":
                    c.Fruit = FruitFilling.Blueberry;
                    break;
                case "Cher":
                    c.Fruit = FruitFilling.Cherry;
                    break;
            }
        }
    }
}
