using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project
{
    internal class Player
    {
        // Fields
        //private string username;
        //private string password;
        //private string fullname;
        //private string email;
        //private int score;
        //private int rank;
        //private bool isManager;

        // Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
        public int Rank { get; set; }
        public bool IsManager { get; set; }

        // Constructor
        public Player()
        {

        }
        public Player(string username, string password, string fullname, string email, int score, int rank, bool isManager)
        {
            this.Username = username;
            this.Password = password;
            this.Fullname = fullname;
            this.Email = email;
            this.Score = score;
            this.Rank = rank;
            this.IsManager = isManager;
        }
        public Player(byte[]player)
        {
            Username = Encoding.UTF8.GetString(player, 0, 10);
            Password = Encoding.UTF8.GetString(player, 11, 21);
            Fullname = Encoding.UTF8.GetString(player, 22, 62);
            Email = Encoding.UTF8.GetString(player, 63, 73);
            Score = BitConverter.ToInt32(player,74);
            Rank = BitConverter.ToInt32(player,78);
            IsManager = BitConverter.ToBoolean(player, 79);
        }
        public byte[] ToByteArray()
        {
            List<byte> listByte = new List<byte>();
            listByte.AddRange(Encoding.UTF8.GetBytes(Username));
            listByte.AddRange(Encoding.UTF8.GetBytes(Password));
            listByte.AddRange(Encoding.UTF8.GetBytes(Fullname));
            listByte.AddRange(Encoding.UTF8.GetBytes(Email));
            listByte.AddRange(BitConverter.GetBytes(Score));
            listByte.AddRange(BitConverter.GetBytes(Rank));
            listByte.AddRange(BitConverter.GetBytes(IsManager));
            return listByte.ToArray();
        }
    }
}
