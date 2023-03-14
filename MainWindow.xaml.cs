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
using System.Xml.Linq;

namespace rppg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private statsheet chara = new statsheet();
        public MainWindow()
        {
            InitializeComponent();
            statsheet stats = new statsheet();
            //updatestats();
            statsheet pal = new statsheet() { name = "hi" };
            statsheet pal2 = new statsheet() { name = "hi 2" };
            //chara.Partymembers.Add(pal);
            //MessageBox.Show($"strenght: {stats.strength}");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            chara.name = textBoxName.Text;
            chara.roll();
            // MessageBox.Show(chara.name);
            foreach (ItemsControl item in partylist.Items)
            {
                statsheet r = new statsheet()
                { name = item.Content.ToString() };

                chara.PartyMembers.Add(r);
            }
            updatestats();
            foreach(statsheet r in chara.Partymembers)
            {
                ListBoxItem
            }
        }

        private void updatestats()
        {
            strengthnumber.Text = chara.strength.ToString();
            charizzmanumber.Text = chara.charizzma.ToString();
            intelligencenumber.Text = chara.intelligence.ToString();
            wisdomnumber.Text = chara.wisdom.ToString();
            lucknumber.Text = chara.luck.ToString();
            dexeritynumber.Text = chara.dexerity.ToString();
        }
    }
}
