namespace The_Employee_Payroll_System
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
          
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Sadam ";
            emp1.HourlyRate = 100;
            emp1.HoursWorked = 8;


            Employee emp2 = new Employee();
            emp2.Name = "Jane Juliet ";
            emp2.HourlyRate = 200;
            emp2.HoursWorked = 7;

            lblResult.Text = emp1.Name + " Pay: " + emp1.GetGrossPay() +
                "\n" +
                emp2.Name + " Pay: " + emp2.GetGrossPay();
        }

    }

}
