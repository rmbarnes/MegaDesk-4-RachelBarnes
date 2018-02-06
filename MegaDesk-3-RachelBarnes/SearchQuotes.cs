using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_RachelBarnes
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            var materials = new List<Desk.SurfaceType>();
            materials = Enum.GetValues(typeof(Desk.SurfaceType))
                        .Cast<Desk.SurfaceType>()
                        .ToList();
            searchQuotesBox.DataSource = materials;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string path = "quote.txt";

            viewQuoteGrid.Rows.Clear();

            try
            {
                using (StreamReader myStream = new StreamReader(path))
                {
                    while (!myStream.EndOfStream)
                    {
                        String[] quotes = myStream.ReadLine().Split(',');
                        if (quotes.Contains(searchQuotesBox.Text))
                        {
                            viewQuoteGrid.Rows.Add(quotes[0], quotes[1], quotes[2], quotes[3], quotes[4], quotes[5], quotes[6], quotes[7]);

                        }

                    }
                }
            }
            catch
            {
                displayError.Visible = true;
                displayError.Text = "No matches";
            }
        }
    }
}
