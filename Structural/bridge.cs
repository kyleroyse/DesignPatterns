using System;
using System.Collections;

namespace BridgeDesign
{
    public interface Inode
    {
        void Reach();
    }
    class Node_A : Inode
    {
        public void Reach()
        {
            Console.WriteLine("Reached node B");
        }
    }
    class Node_B : Inode
    {
        public void Reach()
        {
            Console.WriteLine("Reached node B");
        }
    }
    class Bridge
    {
        public void ReachTo(Inode obj)
        {
            obj.Reach();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bridge br = new Bridge();
            Node_A a = new Node_A();
            br.ReachTo(a); // Reach to Node_A
            br.ReachTo(b); // Reach to Node_B
            Console.WriteLine();
        }
    }

    // Real World Example

    public interface Imessage
    {
        void Send();
    }
    class CSharp_Mail : Imessage
    {
        public void Send()
        {
            Console.WriteLine("Mail sent from C# code");
        }
    }
    class VB_Mail : Imessage
    {
        public void Send()
        {
            Console.WriteLine("Mail sent from Visual BASIC");
        }
    }
    class Database_Mail : Imessage
    {
        public void Send()
        {
            Console.WriteLine("Mail sent from database");
        }
    }
    class MailSendBridge : Imessage
    {
        public void SendFrom(IMessage obj)
        {
            obj.Send();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MailSendBridge mb = new MailSendBridge();
            CSharp_Mail objCS = new CSharp_Mail();
            VB_Mail objVB = new VB_Mail();
            mb.SendFrom(objCS);
            mb.SendFrom(objVB);
            Console.ReadLine();
        }
    }
}
