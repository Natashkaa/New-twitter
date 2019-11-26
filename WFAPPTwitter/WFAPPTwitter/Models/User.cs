﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPPTwitter.Models
{
    public class User
    {
        public Bitmap Image { get; set; }
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;

        public User()
        {
            //Image = new Bitmap("img/unknown.png");
        }
    }
}
