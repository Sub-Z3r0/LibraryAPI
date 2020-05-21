﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public bool InRent { get; set; }
        public Users CurrentUser { get; set; }
        public DateTime Released { get; set; }
        public DateTime RentedDate { get; set; }
    }
}