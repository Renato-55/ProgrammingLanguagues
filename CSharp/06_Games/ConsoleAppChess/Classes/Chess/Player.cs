using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    public class Player : IPlayer
    {
        public string NickName { get; set; }
        public int? Rating { get; set; }
        public string? Title { get; set; }

        public Player() { }
        public string getNickName()
        {
            return NickName;
        }

        public void setNickName(string _nickName)
        {
            NickName = _nickName;
        }

        public void setRating(int _rating)
        {
            if (_rating > 0)
            {
                Rating = _rating;
            }
        }

        public int getRating()
        {
            return Rating != null ? (int)Rating : 0;
        }

        public void setTitle(string _title)
        {
            Title = _title;
        }

        public string getTitle()
        {
            return Title != null ? Title : string.Empty;
        }
    }
}
