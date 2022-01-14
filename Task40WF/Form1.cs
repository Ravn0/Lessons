﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task40WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person() { FirstName = "Мартин", MiddleName="Игоревич", SecondName="Дугин"},
                new Person() { FirstName = "Кей", SecondName="Альтос"},
                new Person() { FirstName = "Мэг", SecondName="Ранш"},
                new Person() { FirstName = "unknown"}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var persons = GetPersons();
            foreach (var person in persons)
            {
                listBox1.Items.Add(person.GetFullName());
            }
        }
    }
}
