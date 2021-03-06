﻿using OpenQA.Selenium;

namespace WordpressAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get 
            { 
                // Refactor: Can we create a generalized IsAt for all pages?
                var h2s = Driver.Instance.FindElements(By.TagName("h2"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "Dashboard";
                return false;
            }
        }
    }
}
