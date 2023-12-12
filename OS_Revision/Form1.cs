using System.IO;
namespace OS_Revision
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("formdata.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writeData = new StreamWriter(fs);
            writeData.WriteLine("Name:   "+txtname.Text);
            writeData.WriteLine("Age:   "+txtage.Text);
            // to determine the gender
            string gender;
            if (rdfemale.Checked == true)
            {
                gender = rdfemale.Text;
            }
            else
            {
                gender = rdmale.Text;
            }
            writeData.WriteLine("Gender:   " +gender);
            // to determine the city
            string selectedItem = cmbcity.SelectedItem.ToString();
            writeData.WriteLine("City:   " + selectedItem);
            // to determine selected courses 
            string courses = "";
            foreach(var item in chlcourses.CheckedItems)
            {
                courses += chlcourses.GetItemText(item)+" ";
            }
            writeData.WriteLine("Courses:   " + courses);
           
            
            writeData.Flush();
            writeData.Close();
            fs.Close();
            Form2 secondform = new Form2();
            Form2.lblwelcom.Text = "Welcom " + txtname.Text+ "..!";
            secondform.ShowDialog();
           
            
        }
    }
}