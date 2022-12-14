using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game_mini
{
    
    public partial class sharedForm : Form
    {
        DataTable dt = new DataTable();
        DataTable dt_Fruit = new DataTable();
        DataTable dt_Animal = new DataTable();
        DataTable dt_Vehicle = new DataTable();
        DataTable dt_Occupation = new DataTable();

        DataTable dt_Rank = new DataTable();
        Int32 currID = 0;
        Int32 num_right = 0;
        public int _score = 0;

        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
            }
        }

        
        public sharedForm(string category, string username)
        {
            InitializeComponent();

            this.category = category;
            this.username = username;

            // ----> Datatable for fruit <-----
            dt_Fruit.Columns.Add("ID", typeof(int));
            dt_Fruit.Columns.Add("En", typeof(string));


            dt_Fruit.Rows.Add(0, "apple");
            dt_Fruit.Rows.Add(1, "banana");
            dt_Fruit.Rows.Add(2, "cherry");
            dt_Fruit.Rows.Add(3, "coconut");
            dt_Fruit.Rows.Add(4, "grape");
            dt_Fruit.Rows.Add(5, "lemon");
            dt_Fruit.Rows.Add(6, "mango");
            dt_Fruit.Rows.Add(7, "orange");
            dt_Fruit.Rows.Add(8, "papaya");
            dt_Fruit.Rows.Add(9, "pear");

            // ----> Datatable for animal <-----
            dt_Animal.Columns.Add("ID", typeof(int));
            dt_Animal.Columns.Add("En", typeof(string));

            dt_Animal.Rows.Add(0, "cat");
            dt_Animal.Rows.Add(1, "chicken");
            dt_Animal.Rows.Add(2, "cow");
            dt_Animal.Rows.Add(3, "dog");
            dt_Animal.Rows.Add(4, "duck");
            dt_Animal.Rows.Add(5, "frog");
            dt_Animal.Rows.Add(6, "horse");
            dt_Animal.Rows.Add(7, "pig");
            dt_Animal.Rows.Add(8, "rabbit");
            dt_Animal.Rows.Add(9, "sheep");

            // ----> Datatable for vehicle <-----

            dt_Vehicle.Columns.Add("ID", typeof(int));
            dt_Vehicle.Columns.Add("En", typeof(string));

            dt_Vehicle.Rows.Add(0, "bicycle");
            dt_Vehicle.Rows.Add(1, "bus");
            dt_Vehicle.Rows.Add(2, "car");
            dt_Vehicle.Rows.Add(3, "motorcycle");
            dt_Vehicle.Rows.Add(4, "scooter");
            dt_Vehicle.Rows.Add(5, "subway");
            dt_Vehicle.Rows.Add(6, "taxi");
            dt_Vehicle.Rows.Add(7, "train");
            dt_Vehicle.Rows.Add(8, "truck");
            dt_Vehicle.Rows.Add(9, "van");
            // ----> Datatable for occupation <-----

            dt_Occupation.Columns.Add("ID", typeof(int));
            dt_Occupation.Columns.Add("En", typeof(string));

            dt_Occupation.Rows.Add(0, "builder");
            dt_Occupation.Rows.Add(1, "carpenter");
            dt_Occupation.Rows.Add(2, "dentist");
            dt_Occupation.Rows.Add(3, "docter");
            dt_Occupation.Rows.Add(4, "farmer");
            dt_Occupation.Rows.Add(5, "policeman");
            dt_Occupation.Rows.Add(6, "singer");
            dt_Occupation.Rows.Add(7, "teacher");
            dt_Occupation.Rows.Add(8, "pilot");
            dt_Occupation.Rows.Add(9, "chef");

            if (category == "animal")
            {
                dt = dt_Animal;
            }
            else if(category == "fruit")
            {
                dt = dt_Fruit;
            }

            else if (category == "vehicle")
            {
                dt = dt_Vehicle;
            }
            else if(category == "occupation")
            {
                dt = dt_Occupation;
            }
        }

        public string category;
        public string username;
        private void pic_Close_Fruit(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                
            }

        }

        private void pic_Click_Home(object sender, EventArgs e)
        {
            this.Close();
            main f_main = new main();
            f_main.Show();
        }

        private void pic_Click_Back(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Form f_chooseTopic = System.Windows.Forms.Application.OpenForms["ChooseTopic"];
            f_chooseTopic.Show();
            WMPMusic.Ctlcontrols.stop();
        }

        public void pic_Volume_Click(object sender, EventArgs e)
        {
            pic_Volume.Visible = false;
            pic_Mute.Visible = true;
            WMPMusic.Ctlcontrols.stop();
        }

        private void pic_NoVolume_Click(object sender, EventArgs e)
        {
            pic_Volume.Visible = true;
            pic_Mute.Visible = false;
            WMPMusic.URL = "babyshark.mp3";
        }

        
        private void Fruit_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            WMPMusic.URL = "babyshark.mp3";

            if (this.category == "fruit")
            {
                pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.tao;
            }

            else if(this.category == "animal")
            {
                pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.cat;
            }
            
            else if(this.category == "vehicle")
            {
                pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.bicycle;
            }
            else if(this.category == "occupation")
            {
                pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.builder;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeImage(Int32 currID)
        {
            if(this.category == "fruit")
            {
                switch (currID)
                {
                    case 0:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.tao;
                        break;
                    case 1:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.chuoi;
                        break;
                    case 2:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.anhdao;
                        break;
                    case 3:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.dua;
                        break;
                    case 4:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.nho;
                        break;
                    case 5:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.chanh;
                        break;
                    case 6:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.xoai;
                        break;
                    case 7:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.cam;
                        break;
                    case 8:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.dudu;
                        break;
                    case 9:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.quale;
                        break;
                    default:
                        break;
                }
            }
            else if(this.category == "animal")
            {
                switch (currID)
                {
                    case 0:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.cat;
                        break;
                    case 1:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.chicken;
                        break;
                    case 2:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.cow;
                        break;
                    case 3:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.dog;
                        break;
                    case 4:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.duck;
                        break;
                    case 5:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.frog;
                        break;
                    case 6:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.horse;
                        break;
                    case 7:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.pig;
                        break;
                    case 8:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.rabbit;
                        break;
                    case 9:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.sheep;
                        break;
                    default:
                        break;
                }
            }

            else if(this.category == "vehicle")
            {
                switch (currID)
                {
                    case 0:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.bicycle;
                        break;
                    case 1:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.bus;
                        break;
                    case 2:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.car;
                        break;
                    case 3:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.motorcycle;
                        break;
                    case 4:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.scooter;
                        break;
                    case 5:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.subway;
                        break;
                    case 6:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.taxi;
                        break;
                    case 7:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.train;
                        break;
                    case 8:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.truck;
                        break;
                    case 9:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.van;
                        break;
                    default:
                        break;
                }
            }
            else if (this.category == "occupation")
            {
                switch (currID)
                {
                    case 0:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.builder;
                        break;
                    case 1:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.carpenter;
                        break;
                    case 2:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.dentist;
                        break;
                    case 3:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.doctor;
                        break;
                    case 4:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.farmer;
                        break;
                    case 5:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.policeman;
                        break;
                    case 6:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.singer;
                        break;
                    case 7:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.teacher;
                        break;
                    case 8:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.pilot;
                        break;
                    case 9:
                        pic_Fruit.BackgroundImage = global::Game_mini.Properties.Resources.chef;
                        break;
                    default:
                        break;
                }
            }

        }
        private void pic_Click_Next(object sender, EventArgs e)
        {
            if(currID < dt.Rows.Count - 1)
            {
                currID++;
                ChangeImage(currID);
            }
            else
            {
                string temp = "Chúc mừng bạn đã hoàn thành bài test với kết quả: " + txt_right.Text + "/ 10 và số điểm đạt được là: " + txt_Score.Text;
                DialogResult inform = MessageBox.Show(temp, "Result", MessageBoxButtons.OKCancel);

                if (inform == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {

                }
            }
        }
      
        public string getVocab(Int32 ID)
        {
            return Convert.ToString(dt.Rows[ID][1]);
        }
        private void txt_Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if (currID < dt.Rows.Count - 1)
                {
                    if (txt_Result.Text.Trim().ToLower() == getVocab(currID))
                    {
                        score += 2;
                        num_right += 1;
                        WMPRight.URL = "correct.mp3";
                    }
                    else if(txt_Result.Text.Trim().ToLower() != getVocab(currID))
                    {
                        WMPWrong.URL = "wrong.mp3";
                    }

                    currID++;
                    txt_Score.Text = Convert.ToString(score);
                    txt_right.Text = Convert.ToString(num_right);
                    txt_Result.Clear();
                    ChangeImage(currID);
                }
                else
                {
                    string temp = "Chúc mừng bạn đã hoàn thành bài test với kết quả: " + txt_right.Text + "/ 10 và số điểm đạt được là: " + txt_Score.Text;
                    switch (this.category)
                    {
                        case "fruit":
                            {
                                string s1_fruit = Properties.Settings.Default.fruit_1st;
                                string s2_fruit = Properties.Settings.Default.fruit_2nd;
                                string s3_fruit = Properties.Settings.Default.fruit_3rd;
                                int score1_fruit = 0;
                                int score2_fruit = 0;
                                int score3_fruit = 0;
                                if (s1_fruit.Length > 1)
                                {
                                    string[] strscore = s1_fruit.Split('_');
                                    score1_fruit = Convert.ToInt32(strscore[strscore.Length - 1]);
                                }
                                if (s2_fruit.Length > 1)
                                {
                                    string[] strscore = s2_fruit.Split('_');
                                    score2_fruit = Convert.ToInt32(strscore.Length - 1);
                                }
                                if (s3_fruit.Length > 1)
                                {
                                    string[] strscore = s3_fruit.Split('_');
                                    score3_fruit = Convert.ToInt32(strscore.Length - 1);
                                }
                                if (score >= score1_fruit)
                                {
                                    Properties.Settings.Default.fruit_3rd = Properties.Settings.Default.fruit_2nd;
                                    Properties.Settings.Default.fruit_2nd = Properties.Settings.Default.fruit_1st;
                                    Properties.Settings.Default.fruit_1st = username + "_" + score.ToString();

                                }
                                else if (score >= score2_fruit)
                                {
                                    Properties.Settings.Default.fruit_3rd = Properties.Settings.Default.fruit_2nd;
                                    if (username == "")
                                    {
                                        Properties.Settings.Default.fruit_2nd = "unnamed player_" + score.ToString();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.fruit_2nd = username + "_" + score.ToString();
                                    }

                                }
                                else if (score >= score3_fruit)
                                {
                                    if (username == "")
                                    {
                                        Properties.Settings.Default.fruit_3rd = "unnamed player_" + score.ToString();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.fruit_3rd = username + "_" + score.ToString();
                                    }
                                }
                                Properties.Settings.Default.Save();
                            }
                            break;
                        case "vehicle":
                            {
                                string s1_vehicle = Properties.Settings.Default.vehicle_1st;
                                string s2_vehicle = Properties.Settings.Default.vehicle_2nd;
                                string s3_vehicle = Properties.Settings.Default.vehicle_3rd;
                                int score1_vehicle = 0;
                                int score2_vehicle = 0;
                                int score3_vehicle = 0;
                                if (s1_vehicle.Length > 1)
                                {
                                    string[] strscore = s1_vehicle.Split('_');
                                    score1_vehicle = Convert.ToInt32(strscore[strscore.Length - 1]);
                                }
                                if (s2_vehicle.Length > 1)
                                {
                                    string[] strscore = s2_vehicle.Split('_');
                                    score2_vehicle = Convert.ToInt32(strscore.Length - 1);
                                }
                                if (s3_vehicle.Length > 1)
                                {
                                    string[] strscore = s3_vehicle.Split('_');
                                    score3_vehicle = Convert.ToInt32(strscore.Length - 1);
                                }
                                if (score >= score1_vehicle)
                                {
                                    Properties.Settings.Default.vehicle_3rd = Properties.Settings.Default.vehicle_2nd;
                                    Properties.Settings.Default.vehicle_2nd = Properties.Settings.Default.vehicle_1st;
                                    Properties.Settings.Default.vehicle_1st = username + "_" + score.ToString();
                                }
                                else if (score >= score2_vehicle)
                                {
                                    Properties.Settings.Default.vehicle_3rd = Properties.Settings.Default.vehicle_2nd;
                                    if (username == "")
                                    {
                                        Properties.Settings.Default.vehicle_2nd = "unnamed player_" + score.ToString();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.vehicle_2nd = username + "_" + score.ToString();
                                    }

                                }
                                else if (score >= score3_vehicle)
                                {
                                    if (username == "")
                                    {
                                        Properties.Settings.Default.vehicle_3rd = "unnamed player_" + score.ToString();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.vehicle_3rd = username + "_" + score.ToString();
                                    }
                                }
                                Properties.Settings.Default.Save();
                            }
                            
                            break;
                        case "animal":
                            {
                                string s1_animal = Properties.Settings.Default.animal_1st;
                                string s2_animal = Properties.Settings.Default.animal_2nd;
                                string s3_animal = Properties.Settings.Default.animal_3rd;
                                int score1_animal = 0;
                                int score2_animal = 0;
                                int score3_animal = 0;
                                if (s1_animal.Length > 1)
                                {
                                    string[] strscore = s1_animal.Split('_');
                                    score1_animal = Convert.ToInt32(strscore[strscore.Length - 1]);
                                }
                                if (s2_animal.Length > 1)
                                {
                                    string[] strscore = s2_animal.Split('_');
                                    score2_animal = Convert.ToInt32(strscore.Length - 1);
                                }
                                if (s3_animal.Length > 1)
                                {
                                    string[] strscore = s3_animal.Split('_');
                                    score3_animal = Convert.ToInt32(strscore.Length - 1);
                                }
                                if (score >= score1_animal)
                                {
                                    Properties.Settings.Default.animal_3rd = Properties.Settings.Default.animal_2nd;
                                    Properties.Settings.Default.animal_2nd = Properties.Settings.Default.animal_1st;
                                    Properties.Settings.Default.animal_1st = username + "_" + score.ToString();

                                }
                                else if (score >= score2_animal)
                                {
                                    Properties.Settings.Default.animal_3rd = Properties.Settings.Default.animal_2nd;
                                    if (username == "")
                                    {
                                        Properties.Settings.Default.animal_2nd = "unnamed player_" + score.ToString();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.animal_2nd = username + "_" + score.ToString();
                                    }

                                }
                                else if (score >= score3_animal)
                                {
                                    if (username == "")
                                    {
                                        Properties.Settings.Default.animal_3rd = "unnamed player_" + score.ToString();
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.animal_3rd = username + "_" + score.ToString();
                                    }
                                }
                                Properties.Settings.Default.Save();
                            }
                            break;
                        case "occupation":
                            string s1_occupation = Properties.Settings.Default.occupation_1st;
                            string s2_occupation = Properties.Settings.Default.occupation_2nd;
                            string s3_occupation = Properties.Settings.Default.occupation_3rd;
                            int score1_occupation = 0;
                            int score2_occupation = 0;
                            int score3_occupation = 0;
                            if (s1_occupation.Length > 1)
                            {
                                string[] strscore = s1_occupation.Split('_');
                                score1_occupation = Convert.ToInt32(strscore[strscore.Length - 1]);
                            }
                            if (s2_occupation.Length > 1)
                            {
                                string[] strscore = s2_occupation.Split('_');
                                score2_occupation = Convert.ToInt32(strscore.Length - 1);
                            }
                            if (s3_occupation.Length > 1)
                            {
                                string[] strscore = s3_occupation.Split('_');
                                score3_occupation = Convert.ToInt32(strscore.Length - 1);
                            }
                            if (score >= score1_occupation)
                            {
                                Properties.Settings.Default.occupation_3rd = Properties.Settings.Default.occupation_2nd;
                                Properties.Settings.Default.occupation_2nd = Properties.Settings.Default.occupation_1st;
                                Properties.Settings.Default.occupation_1st = username + "_" + score.ToString();

                            }
                            else if (score >= score2_occupation)
                            {
                                Properties.Settings.Default.occupation_3rd = Properties.Settings.Default.occupation_2nd;
                                if (username == "")
                                {
                                    Properties.Settings.Default.occupation_2nd = "unnamed player_" + score.ToString();
                                }
                                else
                                {
                                    Properties.Settings.Default.occupation_2nd = username + "_" + score.ToString();
                                }

                            }
                            else if (score >= score3_occupation)
                            {
                                if (username == "")
                                {
                                    Properties.Settings.Default.occupation_3rd = "unnamed player_" + score.ToString();
                                }
                                else
                                {
                                    Properties.Settings.Default.occupation_3rd = username + "_" + score.ToString();
                                }
                            }
                            Properties.Settings.Default.Save();
                            break;
                        default:
                            break;
                    }

                    DialogResult inform = MessageBox.Show(temp, "Result", MessageBoxButtons.OKCancel);
                    if(inform == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
