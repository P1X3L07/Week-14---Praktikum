using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Week_14___Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTeam = new DataTable();
        DataTable dtWorseDiscipline = new DataTable();
        DataTable dtDataGrid = new DataTable();
        int Position = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (', n.nation, ')'), concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ')'), concat(p.player_name, ' ', max(j.Jumlah_Goal), ' (', a.Goal_penalty, ')') from team t, manager m, nationality n, player p, player p2, dmatch d, (select p.player_id, p.player_name, count(d.`type`) as 'Jumlah_Goal' from dmatch d, player p where p.player_id = d.player_id and(d.`type` = 'GO' or 'GP') group by player_id) as j, (select p.player_id, p.player_name, count(d.`type`) as 'Goal_Penalty' from player p left join dmatch d on p.player_id = d.player_id and(d.`type` = 'GP') group by player_id) as a where n.nationality_id = m.nationality_id and m.manager_id = t.manager_id and p.player_id = d.player_id and j.player_name = p.player_name and(d.`type` = 'GO' or 'GP') and t.team_id = d.team_id and a.player_id = p.player_id group by t.team_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            IsiDataPlayer(0);
        }

        public void IsiDataPlayer(int Posisi)
        {
            lblTN.Text = dtTeam.Rows[Posisi][0].ToString();
            lblMgr.Text = dtTeam.Rows[Posisi][1].ToString();
            lblStd.Text = dtTeam.Rows[Posisi][2].ToString();
            lblTS.Text = dtTeam.Rows[Posisi][3].ToString();


            Position = Posisi;
        }

        private void btnLeftEnd_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            if (Position > 0)
            {
                Position--;
                IsiDataPlayer(Position);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (Position < dtTeam.Rows.Count - 1)
            {
                Position++;
                IsiDataPlayer(Position);
            }
            else
            {
                MessageBox.Show("The Last Data");
            }
        }

        private void btnRightEnd_Click(object sender, EventArgs e)
        {
            IsiDataPlayer(dtTeam.Rows.Count - 1);
        }
    }
}
