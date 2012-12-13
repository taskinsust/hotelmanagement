﻿/***************************************************************************\
Module Name:    SessionCache
Author:         Viral Christian
Description:    

\***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelManagement.Models;

namespace HotelManagement.Helpers.CacheHelpers
{
    public static class SessionCache
    {
        public static void CreateSession(int userId,
            string userEmail,
            List<Menu> userMenus,            
            UserType userType)
        {
            UserId = userId;
            UserEmail = userEmail;
            LoginFailCount = 0;
            UserMenus = userMenus;            
            UserType = userType;
        }

        public static void DestroySession()
        {
            UserId = null;
            UserEmail = null;
            LoginFailCount = 0;            
            UserType = null;
        }

        public static int? UserId
        {
            get
            {
                return (int?)HttpContext.Current.Session["SessionCache.UserId"];
            }

            set
            {
                HttpContext.Current.Session["SessionCache.UserId"] = value;
            }
        }

        public static string UserEmail
        {
            get
            {
                return (string)HttpContext.Current.Session["SessionCache.UserEmail"];
            }

            set
            {
                HttpContext.Current.Session["SessionCache.UserEmail"] = value;
            }
        }

        public static int LoginFailCount
        {
            get
            {
                if (HttpContext.Current.Session["SessionCache.LoginFailCount"] == null)
                {
                    HttpContext.Current.Session["SessionCache.LoginFailCount"] = 0;
                }

                return (int)HttpContext.Current.Session["SessionCache.LoginFailCount"];
            }

            set
            {
                HttpContext.Current.Session["SessionCache.LoginFailCount"] = value;
            }
        }

        public static List<Menu> UserMenus
        {
            get
            {
                return (List<Menu>)HttpContext.Current.Session["SessionCache.UserMenus"];               
            }

            set
            {
                HttpContext.Current.Session["SessionCache.UserMenus"] = value;
            }
        }        

        public static UserType UserType
        {
            get
            {
                return (UserType)HttpContext.Current.Session["SessionCache.UserType"];
            }

            set
            {
                HttpContext.Current.Session["SessionCache.UserType"] = value;
            }
        }
    }
}