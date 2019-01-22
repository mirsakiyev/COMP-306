﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookServiceApiClient
{
    public class BookChapter
    {
        public Guid Id { get; set; }
        public int Number { get; set;}
        public string Title { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"{Id}\t {Number}\t {Title} \t {Pages} \n";
        }
    }
}
