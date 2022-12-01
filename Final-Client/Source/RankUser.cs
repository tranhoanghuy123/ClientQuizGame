using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project
{
    public class RankUser
    {
        // Fields
        private string username;
        private string fullname;
        private int score;

        //Properties
        public string Username { get { return username; } set { username = value; } }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public int Score
        {
            get { return score; } set { score = value; } 
        }

        //Constructor
        public RankUser()
        {
            this.username = null;
            this.fullname = null;
            this.score = 0;
        }
        public RankUser(string username,string fullname,int score)
        {
            this.username = username;
            this.fullname = fullname;
            this.score = score;
        }
        //Methods
        public static RankUser getObjectFromBytes(byte[] data)
        {
            RankUser item = new RankUser();
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    item.Username = br.ReadString();
                    item.fullname = br.ReadString();
                    item.score = br.ReadInt32();
                }
            }
            return item;
        }
        public byte[]ToBytesArray(RankUser user)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                using(BinaryWriter bw = new BinaryWriter(ms))
                {
                    bw.Write(user.Username);
                    bw.Write(user.fullname);
                    bw.Write(user.score);
                    return ms.ToArray();
                }
            }
        }
    }
}
