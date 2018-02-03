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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //create list from enum and set it to the dropdown
            var materials = new List<Desk.SurfaceType>();
            materials = Enum.GetValues(typeof(Desk.SurfaceType))
                        .Cast<Desk.SurfaceType>()
                        .ToList(); 
            surfaceBox.DataSource = materials;
            //do the same thing with rush order
            var rushOrder = new List<DeskQuote.RushOrder>();
            rushOrder = Enum.GetValues(typeof(DeskQuote.RushOrder))
                        .Cast<DeskQuote.RushOrder>()
                        .ToList();
            rushOrderBox.DataSource = rushOrder;
        }


        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //create desk object
            Desk newDesk = new Desk();
            newDesk.Depth = depthBox.Value;
            newDesk.Width = widthBox.Value;
            newDesk.Drawers = drawersBox.Value;
            newDesk.SurfaceMaterial = (Desk.SurfaceType)surfaceBox.SelectedValue;


            //create desk quote
            DeskQuote newQuote = new DeskQuote();
            newQuote.CustomerName = customerName.Text;

            //get desk object created from DeskQuote class
            newQuote.CustomerDesk = newDesk;

            //get rest of desk quote stuff
            newQuote.Date = DateTime.Now;
            newQuote.RushOrderTime = (DeskQuote.RushOrder)rushOrderBox.SelectedValue;
            newQuote.QuotePrice = newQuote.CalculateQuote(newQuote);

            //call the write to file function that accepts deskQuote
            //string quotes = quotes.Text;
            if (!File.Exists("quotes.txt")) {
                using (StreamWriter file = File.AppendText("quote.txt"))
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", 
                        newQuote.CustomerName, 
                        newQuote.Date,
                        newQuote.CustomerDesk.Width,
                        newQuote.CustomerDesk.Depth,
                        newQuote.CustomerDesk.Drawers,
                        newQuote.CustomerDesk.SurfaceMaterial,
                        newQuote.RushOrderTime,
                        newQuote.QuotePrice);
                    file.WriteLine(newLine);
                }
            } else
            {

            }
            
            /*StreamWriter writer = new StreamWriter("quotes.txt");
            writer.WriteLine(newQuote.CustomerName);
            writer.Close();
            */
            DisplayQuote displayQuoteForm = new DisplayQuote(newQuote);
            displayQuoteForm.Tag = (MainMenu)Tag; //this;
            displayQuoteForm.Show(this);
            Hide();
        }

        private void surfaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void widthBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
