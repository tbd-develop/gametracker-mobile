﻿using Microsoft.AspNetCore.SignalR;

namespace api.Models
{
    public class GameModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}