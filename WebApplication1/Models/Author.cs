﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Author
    {
        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Author()
        {
        }

        public int Id { get; set; }
        public String Name { get; set; }
    }
}