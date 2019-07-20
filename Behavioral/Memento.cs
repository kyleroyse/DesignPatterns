using System;
using System.Collections;

namespace MementoDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            void InitializeComponent();
        }
        Person objP = new Person();
        private void Update_Click(object sender, EventArgs e)
        {
            objP.Update(this.txtName.Text, this.txtSurname.Text);
        }
        public void DisplayCustomer()
        {
            this.txtName.Text = objP.Name;
            this.txtSurname.Text = objP.Surname;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            objP.Revert();
            DisplayCustomer();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCustomer();
        }
    }
    public class Person
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        MomentoPerson objMPerson = null;
        public Person()
        {
            Name = "Matthew";
            Surname = "Matheson";
            objMPerson = new MomentoPerson(Name, Surname);
        }
        public void Update(String name, string Surname)
        {
            this.Name = name;
            this.Surname = Surname;
        }
        public void Revert()
        {
            Name = objMPerson.Name;
            Surname = objMPerson.Surname;
        }
    }
    public class MomentoPerson
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public MomentoPerson(String Name, String Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
    }
}