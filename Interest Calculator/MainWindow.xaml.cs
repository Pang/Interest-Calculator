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

namespace Interest_Calculator
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

        private void CalculateInterest(object sender, TextChangedEventArgs args)
        {
            var amountTxt = 0f;
            if (AmountTxt != null) float.TryParse(AmountTxt.Text, out amountTxt);

            var rateTxt = 0f;
            if (RateTxt != null) float.TryParse(RateTxt.Text, out rateTxt);

            if (amountTxt > 0 && rateTxt > 0)
            {
                var percentOfRate = (float)rateTxt / 100;
                var interest = (decimal)(amountTxt * percentOfRate);
                InterestTxt.Text = interest.ToString("C2");
            }
        }
    }
}

