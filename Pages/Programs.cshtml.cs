using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithBrandt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FunWithBrandt
{
    public class ProgramsModel : PageModel
    {
        public void OnGet()
        {

        }

        public List<ProgramPost> programPosts = new List<ProgramPost>
        {
            new ProgramPost{
                Title = "Coloy-Coordinate Finder",
                Language = "Python",
                Description = @"Use this to find the (X,Y) coordinates or RGB code for a particular location on your monitor. Just run it and
                                hover your mouse over the area in question. This script runs continuously until interrupted with the control + c keyboard command.
                                You may have issued with dual monitors as I have it crash on me before.",

                Code = @"
                            import pyautogui
                            import time

                            try:
                                while True:
                                    x, y = pyautogui.position()
                                    positionStr = 'X: ' + str(x).rjust(4) + ' Y: ' + str(y).rjust(4)
                                    pixelColor = pyautogui.screenshot().getpixel((x, y))
                                    positionStr += ' RGB: (' + str(pixelColor[0]).rjust(3)
                                    positionStr += ', ' + str(pixelColor[1]).rjust(3)
                                    positionStr += ', ' + str(pixelColor[2]).rjust(3) + ')'
                                    print(positionStr)
                                    time.sleep(3)
                            except KeyboardInterrupt:
                                print('\nDone.')"
            },

            new ProgramPost{
                Title = "Outlook Email",
                Language = "VBA",
                Description = @"Basic sub to create an outlook email without sending it.",

                Code = @"
                        Sub OutlookMail()

                            Dim outlookApp As Object, outlookMail As Object, signature As String

                                Set outlookApp = CreateObject('outlook.application')
                                Set outlookMail = outlookApp.CreateItem(0)

                                With outlookMail
                                    .Display
                                     signature = outlookMail.htmlbody 
                                    .To = 'bgreen3@stategiccomp.com'
                                    .Subject = 'Whatver your Subject is'
                                    .htmlbody = vbNewLine & signature
                                End With


                                outlookMail.Close 1

                                Set outlookApp = Nothing
                                Set outlookMail = Nothing

                        End Sub"
            },

        };

    }


}