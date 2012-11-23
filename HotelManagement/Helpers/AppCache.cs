﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelManagement.Services;
using HotelManagement.Controllers;
using HotelManagement.Models;
using System.Collections;

namespace HotelManagement.Helpers
{
    public static class AppCache
    {
        public static DateTime lastRefresh = new DateTime();

        public static class AppSettings
        {
            public static string HeaderText
            { 
                get 
                {
                    HttpContext.Current.Application["AppCache.AppSettings.HeaderText"] = AllSettings.FirstOrDefault(s => s.Name == "HeaderText").Value;
                    
                    return (string)HttpContext.Current.Application["AppCache.AppSettings.HeaderText"];
                }

                set
                {
                    HttpContext.Current.Application["AppCache.AppSettings.HeaderText"] = value;
                }
            }

            public static int AppCacheValidity
            {
                get
                {
                    if (HttpContext.Current.Application["AppCache.AppSettings.AppCacheValidity"] == null)
                    {
                        SettingService service = new SettingService();
                        HttpContext.Current.Application["AppCache.AppSettings.AppCacheValidity"] = service.Get<Setting>("AppCacheValidity").Value;
                    }

                    return int.Parse(HttpContext.Current.Application["AppCache.AppSettings.AppCacheValidity"].ToString());
                }

                set
                {
                    HttpContext.Current.Application["AppCache.AppSettings.AppCacheValidity"] = value;
                }
            }

            public static IEnumerable<Setting> AllSettings
            {
                get
                {
                    if (DateTime.Now > lastRefresh.AddMinutes(AppCacheValidity))
                    {
                        HttpContext.Current.Application["AppCache.AppSettings.AllSettings"] = null;
                        lastRefresh = DateTime.Now;
                    }

                    if (HttpContext.Current.Application["AppCache.AppSettings.AllSettings"] == null)
                    {
                        SettingService service = new SettingService();
                        HttpContext.Current.Application["AppCache.AppSettings.AllSettings"] = service.Get<Setting>();
                    }

                    return (IEnumerable<Setting>)HttpContext.Current.Application["AppCache.AppSettings.AllSettings"];
                }

                set
                {
                    HttpContext.Current.Application["AppCache.AppSettings.HeaderText"] = value;
                }
            }
        }

        public static class WebConfigSettings
        { 
        
        }
    }
}