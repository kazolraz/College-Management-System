using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    class queryClass
    {
        static private SqlConnection con = new SqlConnection(@"Data Source=mahmud-PC;Initial Catalog=CollegeManagement;User ID=sa;Password=031750045");
        static public void login_func(string userID, DataGridView _dataGridViewLogin)
        {


            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from login where login_id like('" + userID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dataGridViewLogin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static public void loginTeacher(string userID, DataGridView _dataGridViewLogin)
        {


            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from teacher where tId like('" + userID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dataGridViewLogin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Login" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }



        static public void loginAccountant(string userID, DataGridView _dataGridViewLogin)
        {


            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from accountant where aId like ('" + userID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _dataGridViewLogin.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        static public void addStudent(string _stdName, string _stdId, string _stdRoll, string _stdYear, string _stdDept, string _stdDob, string _stdGender, string _stdBlood, string _stdGardian, string _stdContact, string _stdAddress, string _stdFee)
        {



            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO [student] VALUES ('" + _stdName + "','" + _stdId + "','" + _stdRoll + "','" + _stdYear + "','" + _stdDept + "','" + _stdDob + "','" + _stdGender + "','" + _stdBlood + "','" + _stdGardian + "','" + _stdContact + "','" + _stdAddress + "','" + _stdFee + "') ", con);
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("INSERT INTO [marks] (stuM_id,stuM_roll,stuM_year) VALUES ('" + _stdId + "','" + _stdRoll + "','" + _stdYear + "') ", con);
                cmd2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        static public void addTeacher(string _TName, string _TId, string _TPass, string _TPos, string _TSub, string _TDept, string _TSalary, string _TBlood, string _Tdob, string _TGender, string _TContact, string _TAddress)
        {
            string T_type = "Teacher";
            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO [teacher] VALUES ('" + _TName + "','" + _TId + "','" + _TPass + "','" + _TPos + "','" + _TSub + "','" + _TDept + "','" + _TSalary + "','" + _TBlood + "','" + _Tdob + "','" + _TGender + "','" + _TContact + "','" + _TAddress + "') ", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmlog = new SqlCommand("INSERT INTO [login] VALUES ('" + _TId + "','" + _TPass + "','" + T_type + "') ", con);

                cmlog.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        static public void addAccountant(string _aName, string _aId, string _aPass, string _aPos, string _aDob, string _aGender, string _aBlood, string _aSalary, string _aContact, string _aAddress)
        {


            string aType = "Accountant";

            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO [accountant] VALUES ('" + _aName + "','" + _aId + "','" + _aPass + "','" + _aPos + "','" + _aDob + "','" + _aGender + "','" + _aBlood + "','" + _aSalary + "','" + _aContact + "','" + _aAddress + "') ", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmlog = new SqlCommand("INSERT INTO [login] VALUES ('" + _aId + "','" + _aPass + "','" + aType + "') ", con);
                cmlog.ExecuteNonQuery();
                MessageBox.Show("Accountant Added Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }




        }


        static public void searchStu(string _stuID, DataGridView _DataGridView_AllStu)
        {
            string stuId = _stuID;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where stdId like('" + stuId + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void updateStudent(string _stdName, string _stdId, string _stdRoll, string _stdYear, string _stdDepartment, string _stdDob, string _stdGender, string _stdBlood, string _stdGuardian, string _stdContact, string _stdAddress, string _stdFee)
        {


            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand(" UPDATE [student] Set stdName = '" + _stdName + "' , stdId='" + _stdId + "' ,stdRoll='" + _stdRoll + "'  ,stdYear='" + _stdYear + "' , stdDept='" + _stdDepartment + "', stdDob='" + _stdDob + "', stdGender='" + _stdGender + "', stdBlood='" + _stdBlood + "',stdGuardian='" + _stdGuardian + "',stdContact='" + _stdContact + "' ,stdAddress='" + _stdAddress + "' , stdFee='" + _stdFee + "'    where stdId like('" + _stdId + "%') ", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Updated SuccessFully");



            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void updateTeacher(string _TName, string _TId, string _TPos, string _TSub, string _TDept, string _TSalary, string _TBlood, string _Tdob, string _TGender, string _TContact, string _TAddress)
        {


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [teacher] Set tName = '" + _TName + "', tId = '" + _TId + "' ,tPos ='" + _TPos + "' , tSub = '" + _TSub + "' , tDept = '" + _TDept + "', tSalary='" + _TSalary + "', tBlood = '" + _TBlood + "', tDob = '" + _Tdob + "', tGender = '" + _TGender + "', tContact = '" + _TContact + "' , tAddress ='" + _TAddress + "'   where  tId like('" + _TId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Updated SuccessFully");
            }


            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }


            finally
            {
                con.Close();
            }

        }

        static public void searchTeacher(string _Tid, DataGridView DataGridView_AT)
        {
            string Teacherid = _Tid;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from teacher where tId like('" + Teacherid + "%')";
                cmd.ExecuteNonQuery();
                DataTable dataT = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dataT);
                DataGridView_AT.DataSource = dataT;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void TeacherDel(string _TeacherID, DataGridView _DataGridView_AT)
        {
            string tId = _TeacherID;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from teacher where tId like('" + _TeacherID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void stuDel(string _stuID, DataGridView DataGrid_AllStu)
        {
            string stdId = _stuID;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from student where stdId like('" + _stuID + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataGrid_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void searchAcc(string _Aid, DataGridView DataGridView_AT)
        {
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from accountant where aId like('" + _Aid + "%')";
                cmd.ExecuteNonQuery();
                DataTable dataT = new DataTable();
                SqlDataAdapter dta = new SqlDataAdapter(cmd);
                dta.Fill(dataT);
                DataGridView_AT.DataSource = dataT;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }



        }

        static public void UpdateAcc(string _aName, string _aId,string _aPass, string _aPos, string _aDob, string _aGender, string _aBlood, string _aSalary, string _aContact, string _aAddress)
        {

            string aName = _aName;
           
            string aId = _aId;
            string aPass = _aPass;
            string aPos = _aPos;
            string ADob = _aDob;
            string aGender = _aGender;
            string aBlood = _aBlood;
            string aSalary = _aSalary;
            string aContact = _aContact;
            string aAddress = _aAddress;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  [accountant] Set aName ='" + aName + "',aId='" + aId + "', aPass='"+_aPass+"', aPos='" + aPos + "',aDob='" + _aDob + "',aGender='" + aGender + "',aBlood='" + aBlood + "',aSalary='" + aSalary + "',aContact='" + aContact + "',aAddress='" + aAddress + "' where aId like('" + aId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Accountant Updated Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void AccountantDel(string _accID, DataGridView DataGridView_AT)
        {


            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from accountant where aId like('" + _accID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataGridView_AT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void addMarks(string _stdBangla, string _stdEnglish, string _stdMath, string _stdPhy, string _stuId)
        {
            

            double total = double.Parse(_stdBangla) + double.Parse(_stdEnglish) + double.Parse(_stdMath) + double.Parse(_stdPhy);
            string gpa = (total / 4).ToString();


            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("UPDATE  [marks]  SET stuM_bangla='" + _stdBangla + "',stuM_english='" + _stdEnglish + "',stuM_math='" + _stdMath + "',stuM_phy='" + _stdPhy + "',stuM_gpa='" + gpa + "'  where stuM_id like('" + _stuId + "%') ", con);
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Insert" + ex.ToString());
            }
            finally
            {
                con.Close();
            }


        }

        static public void searchStuMarks(string _stuID, DataGridView _DataGridView_AllStu)
        {
            string stuID = _stuID;
            try
            {
                con.Open();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from marks where stuM_id like('" + stuID + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                _DataGridView_AllStu.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        static public void stuDelMarks(string _stuID)
        {
            string stuID = _stuID;

            try
            {
                con.Open();



                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  from marks where stuM_id like('" + stuID + "%')";
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Inset" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }




        static public void add_fee(string _stdId, string _oldfee, string _addFee)
        {

            double old = double.Parse(_oldfee);
            double addfee = double.Parse(_addFee);
            string stdFee = (old + addfee).ToString();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [student] Set stdFee='" + stdFee + "'  where stdId like('" + _stdId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Updated SuccessFully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }

            finally
            {
                con.Close();
            }

        }

        static public void add_salary(string _TtdId, string _oldsalary, string _addSalary)
        {

            double old = double.Parse(_oldsalary);
            double addSalary = double.Parse(_addSalary);
            string TeacherSalary = (old + addSalary).ToString();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" UPDATE [teacher] Set tSalary='" + TeacherSalary + "'  where tId like('" + _TtdId + "%') ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Salary Updated SuccessFully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Problem in Update" + ex.ToString());
            }

            finally
            {
                con.Close();
            }


        }
    }
}
