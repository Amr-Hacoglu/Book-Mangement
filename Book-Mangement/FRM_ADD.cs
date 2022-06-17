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
using System.IO; // like convert a photo into binary to keep it into sql data

namespace Book_Mangement
{
    public partial class FRM_ADD : Form
    {
        // varaible for sql connection
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>(); // make list for string values


        public FRM_ADD()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Upload photo
            var dia = new OpenFileDialog();
            //dia.Filter = "png|*.png"; // if we wanna a specific type of photo
            var result = dia.ShowDialog();
            if(result == DialogResult.OK)
            {
                IMAGE_COVER.Image = Image.FromFile(dia.FileName);
            }

            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Category FROM CategoryTable";
                var rd = cmd.ExecuteReader(); // make varabile sqlDataReader for read the data
                while (rd.Read())
                {
                    // note : varabile rd read an object, so we must convert it to read a string values
                    List.Add(Convert.ToString(rd[0])); // rd[0] mean first column 
                }
                int i = 0;
                while (i < List.LongCount())
                {
                    TXT_CAT.Items.Add(List[i]);
                    i++;
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox8_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(TXT_AUTHER.Text=="")
            {
                MessageBox.Show("Please write the name of the auther");
            }
            else if (TXT_CAT.Text == "Please write the kind of the category")
            {
                MessageBox.Show("");
            }
            else if (TXT_name.Text == "")
            {
                MessageBox.Show("Please write the name of the book");
            }
            else if (TXT_PRICE.Text == "")
            {
                MessageBox.Show("Please write the price of the book");
            }
      
            else
            {
            MemoryStream ma = new MemoryStream(); // we will use this varaible to convert a photo into binary
            IMAGE_COVER.Image.Save(ma,System.Drawing.Imaging.ImageFormat.Jpeg); // save the photo as ....
            var _cover = ma.ToArray();


                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO BOOKS (Title,Auther,Price,Category,Date,Rate,Cover) VALUES (@Title,@Auther,@Price,@Category,@Date,@Rate,@Cover)";
                cmd.Parameters.AddWithValue("@Title", TXT_name.Text);   //TXT_name -> the name of the attribute on the design
                cmd.Parameters.AddWithValue("@Auther", TXT_AUTHER.Text);
                cmd.Parameters.AddWithValue("@Price", TXT_PRICE.Text);
                cmd.Parameters.AddWithValue("@Category", TXT_CAT.Text);
                cmd.Parameters.AddWithValue("@Date", TXT_DATE.Value);
                cmd.Parameters.AddWithValue("@Rate", TXT_RATE.Value);
                cmd.Parameters.AddWithValue("@Cover", _cover); // 183,184,185 instead of this statment, because be wanna to convert the photo to binary to keep it into sql data
                
                cmd.ExecuteNonQuery();  //apply the operation on the query 
                con.Close();
                //show
                Form frm_add = new FRM_DI_ADD();
                frm_add.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm_cat = new FRM_CAT();
            bunifuTransition1.ShowSync(frm_cat);
        }

    }
}
