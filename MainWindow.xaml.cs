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
        private Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
            updatestats();
            int d1 = statsheet.Rolldice(2, 20);
            int d2 = statsheet.Rolldice(1000, 8);
            MessageBox.Show(d1.ToString());
            MessageBox.Show(d2.ToString());

        }

        private void buttonUpdateName_Click(object sender, RoutedEventArgs e)
        {
            chara.name = textBoxName.Text;
        }

        private void buttonReroll_Click(object sender, RoutedEventArgs e)
        {
            chara.roll();
            updatestats();
            double odds = .5;

            chara.Partymembers.Clear();
            foreach (ListBoxItem i in listPotentialMembers.Items)
            {
                if (rng.NextDouble() > odds)
                {
                    statsheet r = new statsheet()
                    { name = i.Content.ToString() };

                    chara.Partymembers.Add(r);
                }
            }

            listPartyMembers.Items.Clear();
            foreach (statsheet r in chara.Partymembers)
            {
                ListBoxItem i = new ListBoxItem();
                i.Content = $"{r.name} STR: {r.strength} INT: {r.intelligence}";
                listPartyMembers.Items.Add(i);
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
