﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropDown.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
    }

    

}