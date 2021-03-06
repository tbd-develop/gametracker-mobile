﻿using System;

namespace GameTrove.Application.ViewModels
{
    public class SearchResultViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public bool IsFavorite { get; set; }
    }
}