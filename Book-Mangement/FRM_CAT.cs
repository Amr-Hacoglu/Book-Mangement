using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Mangement
{
    public partial class FRM_CAT : Form
    {
        // varabile for sql connection
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public FRM_CAT()
        {
            InitializeComponent();
        }

        private void FRM_CAT_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e) //insert for cat name
        {
            // make connection
            if(TXT_CAT.Text != ""){ 
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
            con.Open();
                cmd.Connection= con;
                cmd.CommandText = "INSERT INTO CategoryTable (Category) VALUES (@Category)";
                cmd.Parameters.AddWithValue("@Category", TXT_CAT.Text);   
                cmd.ExecuteNonQuery();  //apply the operation on the query 
            con.Close();
            //show
                Form frm_add = new FRM_DI_ADD();
                frm_add.Show();
                this.Close();
            }
            else{
                MessageBox.Show("Enter name of category !!");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
