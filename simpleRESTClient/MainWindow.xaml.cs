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

namespace simpleRESTClient
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
            debugOutput("Button clicked");
            RestClient client = new RestClient();
            client.endPoint = textBoxLink.Text;
            debugOutput("Rest client created");
            string strResponse = string.Empty;
            strResponse = client.makeRequest();
            debugOutput(strResponse);
        }

        private void textBoxResponse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        #region UI Event Handlers

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textBoxResponse.Text = textBoxResponse.Text + strDebugText + Environment.NewLine;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write(e.Message, ToString() + Environment.NewLine);
            }
        }

        #endregion
    }
}
