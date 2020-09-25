using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirst
{
    public partial class Form1 : Form
    {
         List<Student> stu = Student.getAll();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs s)
        {
            this.Text = "Students";
        }

        private void tabPage2_Click(object sender, EventArgs s)
        {
           

        }



        private void textBox3_TextChanged(object sender, EventArgs s)
        {
            //Salary
        }

        private void button1_Click_1(object sender, EventArgs s)
        {
            // THIS IS THE ADD BUTTON
            try
            {
                using (var db = new CodeFirstContext())
                {
                    Student objStudent = new Student();
                    objStudent.Name = textBox2.Text;
                    objStudent.tuition = int.Parse(textBox3.Text);
                    objStudent.Major = textBox4.Text;
                    db.Students.Add(objStudent);
                    db.SaveChanges();
                }
                MessageBox.Show("New student has been added to the database.", "Success!");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops - Something went wrong.");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs s)
        {
            //Name
        }

        private void textBox4_TextChanged(object sender, EventArgs s)
        {
            //Job Title
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs s)
        {

        }

        private void button2_Click(object sender, EventArgs s)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int delete = listBox1.SelectedIndex;
                    var employee = stu[delete];
                    using (var db = new CodeFirstContext())
                    {
                        db.Students.Attach(employee);
                        db.Students.Remove(employee);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to Delete - Contact your administrator");
                }
            }
            listBox1.DataSource = Student.displayStudents();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Student.displayStudents();
            label13.Text = "$" + Student.totalTuition() + ".00";
            label14.Text = Student.total();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int expenses = int.Parse(textBox1.Text);
                int tuition = int.Parse(Student.totalTuition());
                string total = (tuition - expenses).ToString();
                if (expenses > tuition)
                {
                    label12.Text = "$" + total + ".00";
                }
                else
                {
                    MessageBox.Show("You may want to consider adding more staff and upgrading your facilities.", "Surplus");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please try again.");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs s)
        {

        }

        private void label12_Click(object sender, EventArgs s)
        {

        }
    }
}
