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
using System.Windows.Shapes;

namespace UI.Windows
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }





        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (true)
            {
                int index = ListViewMenu.SelectedIndex;

                MoveCursorMenu(index);

                switch (index)
                {
                    case 0:
                         GridPrincipal.Children.Clear();
                        GridPrincipal.Children.Add(new Controls.map());
                         Scrol.PageUp();
                        break;
                    case 1:
                        GridPrincipal.Children.Clear();
                        //GridPrincipal.Children.Add(new UserControlEscolha());
                        Scrol.PageUp();
                        break;
                    case 2:
                        GridPrincipal.Children.Clear();
                        //GridPrincipal.Children.Add(new AddTest_user_control());

                        Scrol.PageUp();
                        break;
                    case 3:
                        GridPrincipal.Children.Clear();
                        //GridPrincipal.Children.Add(new Edit_person_user_control());
                        Scrol.PageUp();
                        break;
                    case 4:
                        GridPrincipal.Children.Clear();
                        //GridPrincipal.Children.Add(new Update_Test_user_control());
                        Scrol.PageUp();
                        break;
                    case 5:
                        GridPrincipal.Children.Clear();
                       // GridPrincipal.Children.Add(new testers_user_control());
                        Scrol.PageUp();
                        break;
                    case 6:
                        GridPrincipal.Children.Clear();
                        //GridPrincipal.Children.Add(new trainees_user_control());
                        Scrol.PageUp();
                        break;

                    case 7:
                        GridPrincipal.Children.Clear();
                        //Tests_user_control.if_toogle_future = false;
                        //GridPrincipal.Children.Add(new Tests_user_control());

                        Scrol.PageUp();
                        break;
                    case 8:
                        GridPrincipal.Children.Clear();
                       // GridPrincipal.Children.Add(new Calender_user_control());
                        Scrol.PageUp();
                        break;
                    default:
                        break;
                }
            }
        }

        private void MoveCursorMenu(int index)
        {
            //TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void min_and_max_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                //min_and_max_kind.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowRestore;
                //this.WindowState = WindowState.Maximized;
                //BE.Configuration.Height = this.Height;
                //BE.Configuration.Width = this.Width;
            }
            else
            {
                //min_and_max_kind.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
                //this.WindowState = WindowState.Normal;
                //BE.Configuration.Height = this.Height;
                //BE.Configuration.Width = this.Width;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
