using System;

namespace CSharp_Net_module1_2_1_lab
{

    public class LibraryUser
    {
        private string[] bookList;
        public string this[int i]
        {
            get
            {
                if (i < bookList.Length && i >= 0)
                {
                    return bookList[i];
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException();
                };
            }
            set
            {
                if (i < bookList.Length)
                {
                    bookList[i] = value;
                }
            }
        }
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; set; }
        public int BookLimit { get; private set; }
        public int BookCount { get; private set; }

        public LibraryUser(int id = 0, string firstname = "",
            string lastname = "", string phone = "", int booklimit = 10)
        {
            bookList = new string[booklimit];
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            BookLimit = booklimit;
        }
    }
}