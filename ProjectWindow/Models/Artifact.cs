﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Artifact : AModel
    {
        public Artifact(string id, Uri location, string name, string description, Image icon) : base(id)
        {
            Location = location;
            Name = name;
            Description = description;
            Icon = icon;
        }

        public Uri Location { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Image Icon { get; private set; }
    }
}
