using System;
using System.Collection;
using System.Globalization;

namespace PrototypeDesignPattern
{
    class InvitationCard
    {
        public String To;
        public String Title;
        public String Content;
        public String SendBy;
        public DateTime Date;

        public String p_To
        {
            get { return To; }
            set { To = value; }
        }

        public String p_Title
        {
            get { return Title; }
            set { Title = value; }
        }

        public String p_content
        {
            get { return Content; }
            set { Content = value; }
        }

        public String p_SendBy
        {
            get { return SendBy; }
            set { SendBy = value; }
        }

        public DateTime p_Date
        {
            get { return Date; }
            set { Date = value; }
        }

        public InvitationCard CloneMe(InvitationCard obj)
        {
            return (InvitationCard)this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InvitationCard obj1 = new InvitationCard();
            obj1.p_To = "Ram";
            obj1.p_Title = "My birthday invitation";
            obj1.p_content = "Hey guys !! I'm throwing a Seinfeld watch party at my house";
            obj1.SendBy = "Kyle";
            obj1.p_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            // Here, our first object is created
            InvitationCard[] objList = new InvitationCard[5];
            String[] nameList = { "Roman", "Lisa", "Harrison", "John", "Kelsey"};
            int i = 0;
            foreach (String name in nameList)
            {
                // objList[i] = new InvitationCard();
                objList[i] = obj.CloneMe(obj1);
                objList[i].p_To = nameList[i];
                i++;
            }
            // Print all invitation cards
            foreach (InvitationCard obj in objList)
            {
                Console.WriteLine("To : " + obj.p_To);
                Console.WriteLine("Title : " + obj.p_Title);
                Console.WriteLine("Content : " + obj.p_content);
                Console.WriteLine("Send By : " + obj.p_SendBy);
                Console.WriteLine("Date : " + obj.Date);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}