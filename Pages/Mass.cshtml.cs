using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_converter.Pages
{
    public class MassModel : PageModel
    {
        [BindProperty]
        public double Input { get; set; }
        public double Output { get; set; }
        public string Units { get; set; }
        public string Error { get; set; }


        public void OnGet()
        {

        }
        public void OnPost(string convertlist, string massinput)
        {
            try
                //to catch incompatible inputs from being converted
            {
                Input = Convert.ToDouble(massinput);


                if (convertlist == "P2O")
                {
                    //pounds to ounces
                    Output = Input * 16.0;
                    Units = "ounces";
                    //shows correct conversion unit at result
                }
                else if (convertlist == "O2P")
                {
                    //ounces to pounds
                    Output = Input / 16.0;
                    Units = "pounds";
                }
                else if (convertlist == "G2P")
                {
                    //grams to pounds
                    Output = Input / 454.0;
                    Units = "pounds";
                }
                else if (convertlist == "M2P")
                {
                    //milligrams to pounds
                    Output = Input / 453592.0;
                    Units = "pounds";
                }
            }
            catch
            {
                Output = 0;
                //error box with this message if anything but a number is entered
                Error = "Error: enter a number to be converted!";
            }

        }
    }
}
