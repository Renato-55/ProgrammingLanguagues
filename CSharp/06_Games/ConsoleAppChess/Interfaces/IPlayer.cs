﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Interfaces
{
    internal interface IPlayer
    {
        void setNickName(string _nickName);
        string getNickName();

        void setRating(int _rating);
        int getRating();
        void setTitle(string _title);
        string getTitle();
    }
}
