using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithBrandt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FunWithBrandt
{
    public class BlogModel : PageModel
    {
        public List<BlogPost> blogPosts;

        public void OnGet()
        {
            blogPosts = GetBlogData();

        }

        //Desperately want a better way to do this.

        public List<BlogPost> GetBlogData()
        {
            var allPosts = new List<BlogPost>();

            allPosts.Add(new BlogPost()
            {
                Date = "February 9, 2020",
                Title = "Manager Style",
                Content = @"Are small sized money managers preferred over big? Sector specific or broad?
                    Probably the commonsense view on this matter is that a sector specific fund
                    would be preferred to one that juggles a wide variety of investment opportunities.
                    This view follows straightforward from the idea that if they spend all their time
                    analyzing a narrow topic then the expertise they will develop in that area will be
                    extreme allowing them to generate alpha. Make sense obviously, but I do tend to lean
                    towards the views of the generalist than specialist.Being a generalist can usually
                    give you unique insight into specific areas because you are able to access a more
                    diverse set of mental models based on your eclectic knowledge base. I would also
                    think that being a specialist can make you a bit myopic to new points of view
                    and you may get bogged down in the details while losing focus on the broader perspective"
            });

            allPosts.Add(new BlogPost()
            {
                Date = "February 1, 2020",
                Title = "Investment Execution",
                Content = @"If you know with 100% certainty that a security is undervalued should you put all your money into it?
                            I think not. When you say “undervalued” you are saying that given this security’s cash flows and the
                            uncertainty of these cash flows its value should be X, but it currently trading for X – Y. Where Y is a
                            the dollar amount of the mispricing. At first past you may think that this is an arbitrage opportunity of
                            sorts and it typically is presented as such, but the only way this is arbitrage is if after buying at
                            (X-Y) you could immediately sell for X. Then you may think that since your valuation is correct with
                            100% accuracy that eventually the mispricing will be corrected and that you will make your profit.
                            This reasoning calls to mind Keynes famous quote “The market can remain irrational for longer than
                            you can remain solvent.” Or the familiar phrase that “Being too early is indistinguishable from
                            being wrong.” Both quotes make clear the possible complications of your investment. To try to be
                            a little more concrete it is helpful to think a little more specifically. Even if you valuation
                            at time T is correct if that mispricing does not occur by time T+1 and you must sell at T+1 then
                            you are screwed. Another possibility is that at time T+1 the valuation has changed just because
                            of the uncertainty of life. The security may now appropriately valued by you at X-Z where Z>Y. In
                            this case your valuation is now lower than the market value! To make it worse imagine the market
                            now realizes its mistake and values the security at the correct value of X-Z. In this case even
                            though you were 100% correct you were still screwed. Diversification is paramount to investment
                            success. The only way to assure your success would be if you can bet on hundreds of these mispricing’s
                            so that the variance washed out and your average profit is in fact (X-Y)."
            });

            allPosts.Add(new BlogPost()
            {
                Date = "September 29, 2019",
                Title = "Friends in WW I",
                Content = @"I think one of the most fascinating things is the tacit cooperation of enemies in trench warfare in WW1.
                            I am fuzzy on the details,
                            but I believe the gist of the encounters would involve some sort of signal
                            detectable by foot soldiers,
                            but not superior officers,
                            to alert troops of the opposing side that a
                            temporary truce was being proposed.An example would be if a French sharpshooter would unload a few well - aimed
                            shots on some object nearby to German soldiers to suggest that the sniper has the ability, but not the desire
                            to take their life. In return a German sharpshooter could return the favor by also firing off a few
                            well - placed shots on an object near the French position.Word would get around to foot soldiers that a
                            truce has been established and for a time after that all soldiers would fight on to prevent the wrath
                            of commanding officers, but shoot poorly aimed shots with no intent to kill."
            });



            return allPosts;
        }



    }
}