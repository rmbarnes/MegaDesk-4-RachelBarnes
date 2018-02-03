using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_RachelBarnes
{
    public class DeskQuote
    {
        public const decimal BASE_DESK_PRICE = 200;
        public const decimal OAK = 200;
        public const decimal LAMINATE = 100;
        public const decimal PINE = 50;
        public const decimal ROSEWOOD = 300;
        public const decimal VENEER = 125;

        public const decimal THREE_DAYS = 3;
        public const decimal FIVE_DAYS = 5;
        public const decimal SEVEN_DAYS = 7;

        public enum RushOrder
        {
            Three,
            Five,
            Seven
        }

        public string CustomerName { get; set; }
        public RushOrder RushOrderTime { get; set; }
        public Desk CustomerDesk { get; set; }
        public DateTime Date { get; set; }
        public decimal QuotePrice { get; set; }


        public decimal CalculateQuote(DeskQuote deskQuote)
        {
            decimal surfaceMaterialPrice = 0;
            decimal rushOrderDays = 0;

            //set the rush order selection to an actual number which
            //is stored in a constant variable
            switch (deskQuote.RushOrderTime)
            {
                case DeskQuote.RushOrder.Three:
                    rushOrderDays = THREE_DAYS;
                    break;
                case DeskQuote.RushOrder.Five:
                    rushOrderDays = FIVE_DAYS;
                    break;
                case DeskQuote.RushOrder.Seven:
                    rushOrderDays = SEVEN_DAYS;
                    break;
            } 


            switch (deskQuote.CustomerDesk.SurfaceMaterial)
            {
                case Desk.SurfaceType.Oak:
                    surfaceMaterialPrice = OAK;
                    break;

                case Desk.SurfaceType.Laminate:
                    surfaceMaterialPrice = LAMINATE;
                    break;

                case Desk.SurfaceType.Pine:
                    surfaceMaterialPrice = PINE;
                    break;

                case Desk.SurfaceType.Rosewood:
                    surfaceMaterialPrice = ROSEWOOD;
                    break;

                case Desk.SurfaceType.Veneer:
                    surfaceMaterialPrice = VENEER;
                    break;
            }

            decimal surfaceArea = deskQuote.CustomerDesk.Width * deskQuote.CustomerDesk.Depth;
            decimal rushOrderPrice = 0;
            if (surfaceArea < 1000 && rushOrderDays == 3) {
                 rushOrderPrice = 60;
            } else if (surfaceArea <= 2000 && rushOrderDays == 3)
            {
                rushOrderPrice = 70;
            } else if (surfaceArea > 2000 && rushOrderDays == 3)
            {
                rushOrderPrice = 80;
            } else if (surfaceArea < 1000 && rushOrderDays == 5)
            {
                rushOrderPrice = 40;
            } else if (surfaceArea <= 2000 && rushOrderDays == 5)
            {
                rushOrderPrice = 50;
            } else if (surfaceArea > 2000 && rushOrderDays == 5)
            {
                rushOrderPrice = 60;
            } else if (surfaceArea < 1000 && rushOrderDays == 7)
            {
                rushOrderPrice = 30;
            } else if (surfaceArea <= 2000 && rushOrderDays == 7)
            {
                rushOrderPrice = 35;
            } else if (surfaceArea > 2000 && rushOrderDays == 7)
            {
                rushOrderPrice = 40;
            } else
            {
                rushOrderPrice = 0;
            }

            decimal quotePrice = BASE_DESK_PRICE + 
                                surfaceArea + 
                                deskQuote.CustomerDesk.Drawers * 50 + 
                                surfaceMaterialPrice + 
                                rushOrderPrice;
            return quotePrice;
        }
       
       
    }
}
