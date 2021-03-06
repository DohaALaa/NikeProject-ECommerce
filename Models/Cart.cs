﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nike_Project_Core.Models
{
    public class Cart
    {
        private string _model;
        private string _features;
        private string _url;
        private double _price;
        private string _mobileName;
        private string _color;          

        public string MobileName
        {
            get => _mobileName;
            set => _mobileName = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public string Url
        {
            get => _url;
            set => _url = value;
        }
        public string Features
        {
            get => _features;
            set => _features = value;
        }
        public string model
        {
            get => _model;
            set => _model = value;
        }
        public string color
        {
            get => _color;
            set => _color = value;
        }
        
    }
}
