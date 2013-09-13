/**
   Copyright GeekyTheory 2013 (@GeekyTheory)

   Licensed under the GPL General Public License, Version 3.0 (the "License"),  
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.gnu.org/licenses/gpl.html

   Unless required by applicable law or agreed to in writing, software 
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   
   Website: http://geekytheory.com
   Author: Dachi Gogotchui <dachi@geekytheory.com>
*/

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
using Microsoft.Phone.Controls;

namespace TallerIntroWindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void navega_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SecondPage.xaml?Nombre=" + txtName.Text, UriKind.Relative));
        }

        private void move_click(object sender, System.Windows.RoutedEventArgs e)
        {
            animacion1.Begin();
        }
    }
}