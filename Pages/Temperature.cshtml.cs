using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_converter.Pages
{
    public class TempModel : PageModel
    {
        [BindProperty]
        public double Input { get; set; }
        public double Output { get; set; }
        public string Error { get; set; }


        public void OnGet()
        {
           
        }
        public void OnPost(string convertlist, string tempinput)
        {
            try
                //to catch incompatible inputs from being converted
            {
                Input = Convert.ToDouble(tempinput);

                if (convertlist == "F2C")
                {
                    //farenheit to celsius
                    Output = (Input - 32) * (5.0 / 9.0);
                    //either way, the output is still called degrees so no Units string needed
                }
                else if (convertlist == "C2F")
                {
                    //celsius to farenheit
                    Output = (Input * (9.0 / 5.0)) + 32;
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
