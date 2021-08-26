using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly Student[] _students;

        public Form1()
        {
            InitializeComponent();

            _students = new Student[]
            {
                new UsualStudent("Ivan", "Padalka", "Andreevich", 12),
                new UsualStudent("Ivan1", "Padalka1", "Andreevich1", 5),
                new UsualStudent("Ivan2", "Padalka2", "Andreevich2", 20),
                new UsualStudent("Ivan3", "Padalka3", "Andreevich3", 15),
                new UsualStudent("Ivan4", "Padalka4", "Andreevich4", 3),
                new CleverS("Tony", "BonD", "Byason", 12),
                new CleverS("Tony", "BonD", "Byason", 5),
                new CleverS("Tony", "BonD", "Byason", 20),
                new CleverS("Tony", "BonD", "Byason", 14),
                new GeniusStudent("Anton", "Vanko", "Аndreevich", 1)
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var student in _students)
            {
                if (student.PassExam())
                    textBox1.Text += student + ", Student passed exam" + Environment.NewLine;
                else
                    textBox1.Text += student + ", Student doesn't pass exam" + Environment.NewLine;
            }
        }
    }
}