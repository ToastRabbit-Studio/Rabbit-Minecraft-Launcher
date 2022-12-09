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

namespace Rabbit_Minecraft_Launcher
{
    /// <summary>
    /// DashboardPage.xaml 的交互逻辑
    /// </summary>
    public partial class DashboardPage : Page
    {
        public DashboardPage()
        {
            InitializeComponent();
        }
        private void TaskbarStateComboBox_OnSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (sender is not System.Windows.Controls.ComboBox comboBox)
                return;

            var parentWindow = System.Windows.Window.GetWindow(this);

            if (parentWindow == null)
                return;

            var selectedIndex = comboBox.SelectedIndex;

            switch (selectedIndex)
            {
                case 1:
                    Wpf.Ui.TaskBar.TaskBarProgress.SetValue(
                        parentWindow,
                        Wpf.Ui.TaskBar.TaskBarProgressState.Normal,
                        80);
                    break;

                case 2:
                    Wpf.Ui.TaskBar.TaskBarProgress.SetValue(
                        parentWindow,
                        Wpf.Ui.TaskBar.TaskBarProgressState.Error,
                        80);
                    break;

                case 3:
                    Wpf.Ui.TaskBar.TaskBarProgress.SetValue(
                        parentWindow,
                        Wpf.Ui.TaskBar.TaskBarProgressState.Paused,
                        80);
                    break;

                case 4:
                    Wpf.Ui.TaskBar.TaskBarProgress.SetValue(
                        parentWindow,
                        Wpf.Ui.TaskBar.TaskBarProgressState.Indeterminate,
                        80);
                    break;

                default:
                    Wpf.Ui.TaskBar.TaskBarProgress.SetState(parentWindow, Wpf.Ui.TaskBar.TaskBarProgressState.None);
                    break;
            }
        }
    }
}

