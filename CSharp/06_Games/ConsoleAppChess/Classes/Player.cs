using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class Player : IPlayer
    {
        public string NickName { get; set; }
        public int? Rating { get; set; }
        public string? Title { get; set; }

        public Player() { }
        public string getNickName()
        {
            return this.NickName;
        }

        public void setNickName(string _nickName)
        {
            this.NickName = _nickName;
        }

        public void setRating(int _rating)
        {
            if (_rating > 0)
            {
                this.Rating = _rating;
            }
        }

        public int getRating()
        {
            return this.Rating != null ? (int)this.Rating : 0;
        }

        public void setTitle(string _title)
        {
            this.Title = _title;
        }

        public string getTitle()
        {
            return this.Title != null ? this.Title : string.Empty;
        }
    }
}
