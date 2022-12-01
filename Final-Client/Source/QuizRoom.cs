using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project
{
    internal class QuizRoom
    {
        // Properties
        public int RoomID { get; set; }
        public int QuantityMember { get; set; }
        public string CategoryRoom { get; set; }
        public int CountMember { get; set; }

        //Contrustor
        public QuizRoom()
        {

        }
        public QuizRoom(int roomID, int quantityMember, string categoryRoom)
        {
            RoomID = roomID;
            QuantityMember = quantityMember;
            CategoryRoom = categoryRoom;
            CountMember = 0;
        }
        public QuizRoom(byte[]data)
        {
            RoomID = BitConverter.ToInt32(data, 0);
            QuantityMember = BitConverter.ToInt32(data, 4);
            CategoryRoom = Encoding.UTF8.GetString(data,8,40);
            CountMember = BitConverter.ToInt32(data, 48);
        }

        // Method
        public byte[] ToByteArray()
        {
            List<byte> listByte = new List<byte>();
            listByte.AddRange(BitConverter.GetBytes(RoomID));
            listByte.AddRange(BitConverter.GetBytes(QuantityMember));
            listByte.AddRange(Encoding.UTF8.GetBytes(CategoryRoom));
            listByte.AddRange(BitConverter.GetBytes(CountMember));
            return listByte.ToArray();
        }
    }
}
