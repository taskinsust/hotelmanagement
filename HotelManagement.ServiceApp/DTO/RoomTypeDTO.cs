﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.ServiceApp.DTO
{
    public class RoomTypeDTO
    {        
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int MaxOccupants { get; set; }
    }
}