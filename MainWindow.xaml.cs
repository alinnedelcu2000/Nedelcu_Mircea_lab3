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

namespace Nedelcu_Mircea_Lab2
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private DoughnutMachine myDoughnutMachine;
        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            //Tema de laborator
        }
        private int mRaisedGlazed;
        private int mRaisedSugar;
        private int mFilledLemon;
        private int mFiledChocolate;
        private int mFilledVanilla;
    }
    private void glazedToolStripMenuItem_Click(object sender, RoutedEventArgs e)
    {
        glazedToolStripMenuItem.IsChecked = true;
        sugarToolStripMenuItem.IsChecked = false;
        myDoughnutMachine.MakeDoughnuts(DoughnutType.Glazed);
    }
    private void sugarToolStripMenuItem_Click(object sender, RoutedEventArgs e)
    {
        sugarToolStripMenuItem.IsChecked = true;
        glazedToolStripMenuItem.IsChecked = false;
        myDoughnutMachine.MakeDoughnuts(DoughnutType.Sugar);
    }
    private void DoughnutCompleteHandler()
    {
switch (myDoughtnutMachine.Flavor)
        {
            case DoughnutType.Glazed:
                mRaisedGlazed++;
                txtGlazedRaised.Text = mRaisedGlazed.ToString();
                break;
                case DoughnutType.Sugar:
                mRaisedSugar++;
                txtSugarRaised.Text = mRaisedSugar.ToString();
                break;
                //tema
        }
    }
    myDoughnutMachine.DoughnutComplete += new
        DoughnutMachine.DoughtnutCompleteDelegate(DoughnutCompleteHandler);

        private void stopToolStripMenuItem_Click(object sender, RoutedEventArgs e)
    {
        myDoughnutMachine.Enabled = false;
    }
    private void exitToolScriptMenuItem_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    private void txtQuantity_KeyPress(object sender, KeyEventArgs e)
    {
        if(!(e.Key>=Key.D0 && e.Key<=Key.D9))
        {
            MessageBox.Show("Numai cifre se pot introduce!", "Input Error",MessageBoxButton.OK,MessageBoxImage.Error);
        }
    }
}
