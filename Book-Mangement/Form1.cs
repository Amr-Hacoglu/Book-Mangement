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
using System.IO;

namespace Book_Mangement
{
    public partial class Form1 : Form
    {
        // varaible for move form without border
        int move;
        int movx; // for x coordinates
        int movy; // for y coordinates

        // varaivle for sql connection
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
            // this function will close the application
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            // here we hava to optional if it's already big so we make it normal , and if it's normal we make it big
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            // this function will make the minimized for the application
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            FRM_INFO frm_info = new FRM_INFO();
            //frm_add.BTBInsertIntoInsert.ButtonText = "Update the book";
            //frm_add.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_info);

            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Title,Auther,Price,Category,Date,Rate FROM BOOKS WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader(); // make varabile sqlDataReader for read the data
                while (rd.Read())
                {
                    // note : varabile rd read an object, so we must convert it to read a string values
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));

                }
                frm_info.TXT_name.Text = List[0];
                frm_info.TXT_AUTHER.Text = List[1];
                frm_info.TXT_PRICE.Text = List[2];
                frm_info.TXT_CAT.Text = List[3];
                frm_info.TXT_DATE.Text = List[4];
                //frm_add.TXT_DATE.Value = Convert.ToDateTime(List[4]);
                frm_info.TXT_RATE.Value = Convert.ToInt16(List[5]);
                con.Close();
                // Read Image from database
                con.Open();
                cmd.CommandText = "SELECT Cover FROM BOOKS WHERE Id = @IdImage";
                cmd.Parameters.AddWithValue("@IdImage", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frm_info.IMAGE_COVER.Image = Image.FromStream(ma);
                //con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM BOOKS WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            FRM_DI_DELETE frmd = new FRM_DI_DELETE();
            frmd.Show();
            cmd.Parameters.Clear();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // just trying i will delete it later
            FRM_ADD frm_add = new FRM_ADD();
            frm_add.BTBInsertIntoInsert.ButtonText = "Insert the book";
            frm_add.state = 0;
            bunifuTransition1.ShowSync(frm_add);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // first we make 3 varaible in up (move,movx,movy)
            move = 1;
            movx = e.X;
            movy = e.Y;
            // mouse clicked
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
            // mouse not clicked
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
            // mouse position - where the mouse is putten like x=150 , y=280 
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); // if we put it up it will repeat the values om database each time you do operation 
            // connect to sql 
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
            var sql = "SELECT Id, Title , Auther , Price , Category FROM Books";
            da = new SqlDataAdapter(sql,con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            // change name of columns
            dataGridView1.Columns[0].HeaderText = "Number"; // id
            dataGridView1.Columns[1].HeaderText = "TitleName"; // title



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            FRM_ADD frm_add = new FRM_ADD();
            frm_add.BTBInsertIntoInsert.ButtonText = "Update the book";
            frm_add.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_add);

            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Desktop\C#\C# Book-Man\Book-Mangement\Book-Mangement\Database1.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT Title,Auther,Price,Category,Date,Rate FROM BOOKS WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader(); // make varabile sqlDataReader for read the data
                while (rd.Read())
                {
                    // note : varabile rd read an object, so we must convert it to read a string values
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));

                }
                frm_add.TXT_name.Text = List[0];
                frm_add.TXT_AUTHER.Text = List[1];
                frm_add.TXT_PRICE.Text = List[2];
                frm_add.TXT_CAT.Text = List[3]; 
                frm_add.TXT_DATE.Text = List[4];
                //frm_add.TXT_DATE.Value = Convert.ToDateTime(List[4]);
                frm_add.TXT_RATE.Text = List[5];
                con.Close();
                // Read Image from database
                con.Open();
                cmd.CommandText = "SELECT Cover FROM BOOKS WHERE Id = @IdImage";
                cmd.Parameters.AddWithValue("@IdImage", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img = (byte[]) cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img,0,img.Length);
                frm_add.IMAGE_COVER.Image = Image.FromStream(ma);
                //con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }
    }
}
