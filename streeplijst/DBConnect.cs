using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using streeplijst_library;

namespace streeplijst
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;
        public Lijst lijst = new Lijst();
        public Lijst lijst2 = new Lijst();
        public Lijst teams_bier = new Lijst();
        public Lijst Names = new Lijst();
        public PriceList price = new PriceList();
        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            port = "3306";
            database = "parabool";
            uid = "root";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" +
                "DATABASE=" + database + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();

                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void SearchDB(string name)
        {
            string query;
            if (name != "")
            {
                query = $"SELECT * FROM {database}.nameslist INNER JOIN {database}.streeplijst ON {database}.nameslist.id = {database}.streeplijst.id" +
                               $" INNER JOIN {database}.streeplijst_total ON {database}.nameslist.id = {database}.streeplijst_total.id" +
                               $" INNER JOIN {database}.teams_has_nameslist ON {database}.nameslist.id = {database}.teams_has_nameslist.nameslist_id"+
                               $" INNER JOIN {database}.maandelijks ON {database}.nameslist.id = {database}.maandelijks.ID"+
                               $" WHERE FirstName = '{name.Substring(0, name.IndexOf('\t'))}' AND LastName = '{name.Substring(name.IndexOf('\t') + 1)}'";
            }
            else
            {
                query = $"SELECT * FROM {database}.nameslist INNER JOIN {database}.streeplijst ON {database}.nameslist.id = {database}.streeplijst.id" +
                            $" INNER JOIN {database}.streeplijst_total ON {database}.nameslist.id = {database}.streeplijst_total.id" +
                            $" INNER JOIN {database}.teams_has_nameslist ON {database}.nameslist.id = {database}.teams_has_nameslist.nameslist_id"+
                            $" INNER JOIN {database}.maandelijks ON {database}.nameslist.id = {database}.maandelijks.ID;";
            }
            lijst.Leden.Clear();
            lijst.Items.Clear();
            int i = 0;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    //Console.WriteLine(dataReader.GetName(1));
                    var id = Int32.Parse(dataReader["id"] + "");
                    var Firstname = dataReader["firstname"] + "";
                    var Lastname = dataReader["lastname"] + "";
                    var Item1 = Int32.Parse(dataReader["Item1"] + "");
                    var Item2 = Int32.Parse(dataReader["Item2"] + "");
                    var Item3 = Int32.Parse(dataReader["Item3"] + "");
                    var Item4 = Int32.Parse(dataReader["Item4"] + "");
                    var Item5 = Int32.Parse(dataReader["Item5"] + "");
                    var Item6 = Int32.Parse(dataReader["Item6"] + "");
                    var Item7 = Int32.Parse(dataReader["Item7"] + "");
                    var Item8 = Int32.Parse(dataReader["Item8"] + "");
                    var Item9 = Int32.Parse(dataReader["Item9"] + "");
                    var Item10 = Int32.Parse(dataReader["Item10"] + "");

                    var Item12 = Int32.Parse(dataReader["Item12"] + "");
                    var Item22 = Int32.Parse(dataReader["Item22"] + "");
                    var Item32 = Int32.Parse(dataReader["Item32"] + "");
                    var Item42 = Int32.Parse(dataReader["Item42"] + "");
                    var Item52 = Int32.Parse(dataReader["Item52"] + "");
                    var Item62 = Int32.Parse(dataReader["Item62"] + "");
                    var Item72 = Int32.Parse(dataReader["Item72"] + "");
                    var Item82 = Int32.Parse(dataReader["Item82"] + "");
                    var Item92 = Int32.Parse(dataReader["Item92"] + "");
                    var Item102 = Int32.Parse(dataReader["Item102"] + "");

                    var maandelijks = Int32.Parse(dataReader["Item111"] + "");
                    var commissie = dataReader["commisie_id"] + "";
                    var team = dataReader["teams_idteams"] + "";


                    lijst.Items.Add(new Item
                    {
                        ItemCountTotal = new int[] { Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10 },
                        Id = id,
                        ItemCountTotal2 = new int[] { Item12, Item22, Item32, Item42, Item52, Item62, Item72, Item82, Item92, Item102 },
                        ItemCountMaandelijks = maandelijks
                    });
                    lijst.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Number = id, Items = lijst.Items[i], Commissies = commissie, Team = team});
                    i++;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
                //lijst.Leden.Sort((x, y) => y.Items.ItemCountTotal[0].CompareTo(x.Items.ItemCountTotal[0]));
                //lijst.Leden.Sort((x, y) => y.Items.ItemCountTotal2[0].CompareTo(x.Items.ItemCountTotal2[0]));
            }
        }

        public void Nameslist(String name)
        {
            string query = $"SELECT * FROM {database}.nameslist WHERE FirstName LIKE '{name}%';";
            Names.Leden.Clear();


            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    var Firstname = dataReader["firstname"] + "";
                    var Lastname = dataReader["lastname"] + "";
                    var id = dataReader["id"] + "";

                    Names.Leden.Add(new Lid { Firstname = Firstname + "", Lastname = Lastname, Number = Convert.ToInt16(id) });
                    


                }

                //close Data Reader
                dataReader.Close();
                Names.Leden.Sort((x, y) => x.Firstname.CompareTo(y.Firstname));
                //close Connection
                this.CloseConnection();
            }
        }

        public void Update_maandelijks(int Item, int id)
        {
            string query = $"UPDATE {database}.maandelijks SET Item111= Item111 + {Item} WHERE id={id}";
            MySqlCommand cmd = new MySqlCommand();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string tabel, int Item1, int Item2, int Item3, int Item4, int Item5, int Item6, int Item7, int Item8, int Item9, int Item10, int id)
        {
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            if (tabel == "streeplijst")
            {
                string query = $"UPDATE {database}.{tabel} SET Item1={Item1}, Item2={Item2}, Item3={Item3}, Item4={Item4}, Item5={Item5}, Item6={Item6}, Item7={Item7}, Item8={Item8}, Item9={Item9}, Item10={Item10} WHERE id={id}";
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            else if (tabel == "streeplijst_total")
            {
                var query = $"UPDATE {database}.{tabel} SET Item12={Item1}, Item22={Item2}, Item32={Item3}, Item42={Item4}, Item52={Item5}, Item62={Item6}, Item72={Item7}, Item82={Item8}, Item92={Item9}, Item102={Item10} WHERE id={id}";
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
        }

        public void UpdateTeamAndCommissie(string teamID, string CommissieID, int Bier)
        {
            MySqlCommand cmd = new MySqlCommand();
            var query = $"UPDATE parabool.teams SET Bier_count = Bier_count + {Bier} where idteams = {teamID}";

            if (this.OpenConnection() == true)
            {
                //Create Command

                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"UPDATE parabool.commissies SET Bier_count = Bier_count + {Bier} where idcommisies = {CommissieID}";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                //close Connection
                this.CloseConnection();

            }
        }

        public void Update(string tabel, int id, int team, int Commissie)
        {
            MySqlCommand cmd = new MySqlCommand();

            var query = $"UPDATE {database}.{tabel} SET teams_idteams = {team}, commisie_id = {Commissie}  WHERE nameslist_id={id}";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                //MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }

        }

        public void Update(String item, int id, int count, string tabel)
        {
            MySqlCommand cmd = new MySqlCommand();

            var query = $"UPDATE {database}.{tabel} SET {item} = {count} WHERE id={id}";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                //MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void AddPerson(string firstName, string lastName)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = $"INSERT INTO {database}.nameslist (FirstName, LastName) values ('{firstName}', '{lastName}'); ;";

            if (this.OpenConnection() == true)
            {
                //Create Command

                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public void AddStreeplijstData(string firstName, string LastName, string Team, string Commissie)
        {
            string query = $"select id FROM {database}.nameslist WHERE FirstName = '{firstName}' AND LastName = '{LastName}' ;";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                var id = "";
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    id = dataReader["id"] + "";
                }
                //close Data Reader
                dataReader.Close();

                query = $"INSERT INTO {database}.streeplijst (Item1, Item2, Item3, Item4, Item5,Item6, Item7, Item8, Item9, Item10, id) values (0,0,0,0,0,0,0,0,0,0,{id});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO {database}.streeplijst_total (Item12, Item22, Item32, Item42, Item52, Item62, Item72, Item82, Item92, Item102, id) values (0,0,0,0,0,0,0,0,0,0,{id});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO {database}.maandelijks (Item111, ID) values (0,{id});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO {database}.teams_has_nameslist (teams_idteams, nameslist_id, commisie_id) values ({Team},{id}, {Commissie});";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }

        }

        public void PriceList()
        {
            string query = $"SELECT * FROM {database}.price INNER JOIN {database}.items ON {database}.price.id = {database}.items.id; ";
            int i = 0;
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var Item_price = dataReader["Item_price"] + "";
                    var item = dataReader["item"] + "";
                    //var Team = dataReader["teams_name" + ""];
                    price.Item_prices[i] = Convert.ToDouble(Item_price);
                    price.Items[i] = item;
                    i++;

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
        }

        public void UpdatePriceList(String item, Decimal price)
        {
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            string query = $"UPDATE {database}.price SET Item_price = {price} WHERE id = {item}";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void UpdateItemList(String Item, int id, String price)
        {
                        
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            string query = $"UPDATE {database}.items SET item='{Item}' WHERE id={id};";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                query = $"UPDATE {database}.price SET Item_price={price} WHERE id={id}";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void DeletPerson(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = $"DELETE FROM nameslist WHERE id = {id} ;";
            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM {database}.streeplijst WHERE id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM {database}.streeplijst_total WHERE id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM {database}.nameslist WHERE id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM {database}.teams_has_nameslist WHERE nameslist_id = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                query = $"DELETE FROM {database}.maandelijks WHERE ID = {id};";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();


                //close Connection
                this.CloseConnection();

            }

        }

        public void AddBietToTeams(int bier_total, int Team, String tabel, String Collum)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand();
            string query = $"Update {tabel} SET Bier_count = {bier_total} WHERE {Collum} = {Team};";

            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public void TopTeams()
        {
            string query = $"select * FROM {database}.teams;";
            teams_bier.Teams.Clear();
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var teams_name = dataReader["teams_name"] + "";
                    var bier_count = Int32.Parse(dataReader["Bier_count"] + "");
                    teams_bier.Teams.Add(new Teams { Team = teams_name, Bier_count = bier_count });
                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

                teams_bier.Teams.Sort((x, y) => y.Bier_count.CompareTo(x.Bier_count));

            }
        }

        public void TopCommissies()
        {
            string query = $"select * FROM {database}.commissies;";
            teams_bier.Teams.Clear();
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var Commissie = dataReader["commisieName"] + "";
                    var bier_count = Int32.Parse(dataReader["Bier_count"] + "");
                    teams_bier.Teams.Add(new Teams { Commissie = Commissie, Bier_count = bier_count });
                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

                teams_bier.Teams.Sort((x, y) => y.Bier_count.CompareTo(x.Bier_count));

            }
        }

        public void UpdateStock(int Item1, int Item2, int Item3, int Item4, int Item5, int Item6, int Item7, int Item8, int Item9, int Item10)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand();
            string query = $"UPDATE {database}.stock SET Item1_Sold = Item1_Sold +{Item1}, Item2_Sold = Item2_Sold+{Item2}, Item3_Sold = Item3_Sold +{Item3}, Item4_Sold = Item4_Sold+{Item4}, Item5_Sold = Item5_Sold+{Item5}," +
                           $"Item6_Sold = Item6_Sold +{Item6}, Item7_Sold = Item7_Sold+{Item7}, Item8_Sold = Item8_Sold +{Item8}, Item9_Sold = Item9_Sold+{Item9}, Item10_Sold = Item10_Sold+{Item10};";

            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public String[] PersonData(String name)
        {
            String firstName = name.Substring(0, name.IndexOf(" "));
            String lastName = name.Substring(name.IndexOf(" ") + 1);
            String[] data = new String[9];
            string query = $"SELECT * FROM {database}.nameslist INNER JOIN {database}.streeplijst ON {database}.nameslist.id = {database}.streeplijst.id " +
                           $"INNER JOIN {database}.streeplijst_total ON {database}.nameslist.id = {database}.streeplijst_total.id " +
                           $"WHERE FirstName = '{firstName}' AND LastName = '{lastName}'; ";
            teams_bier.Teams.Clear();
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var firstname = dataReader["FirstName"] + "";
                    var lasttname = dataReader["LastName"] + "";
                    var Item1 = dataReader["Item1"] + "";
                    var Item2 = dataReader["Item2"] + "";
                    var Item3 = dataReader["Item3"] + "";
                    var Item4 = dataReader["Item4"] + "";
                    var Item5 = dataReader["Item5"] + "";
                    var Item6 = dataReader["Item6"] + "";
                    var Item7 = dataReader["Item7"] + "";
                    var Item8 = dataReader["Item8"] + "";
                    var Item9 = dataReader["Item9"] + "";
                    var Item10 = dataReader["Item10"] + "";
                    var Id = dataReader["id"] + "";
                    var Item12 = dataReader["Item12"] + "";
                    var Item22 = dataReader["Item22"] + "";
                    var Item32 = dataReader["Item42"] + "";
                    var Item42 = dataReader["Item32"] + "";
                    var Item52 = dataReader["Item52"] + "";
                    var Item62 = dataReader["Item62"] + "";
                    var Item72 = dataReader["Item72"] + "";
                    var Item82 = dataReader["Item82"] + "";
                    var Item92 = dataReader["Item92"] + "";
                    var Item102 = dataReader["Item102"] + "";


                    data = new String[] {firstname, lasttname, Id, Item1, Item2, Item3, Item4, Item5, Item6, Item7, Item8, Item9, Item10,
                                        Item12, Item22, Item32, Item42, Item52,  Item62, Item72, Item82, Item92, Item102};

                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

            }
            return data;
        }

        public String[] Total_Sold()
        {
            String[] x = new String[10];
            if (this.OpenConnection() == true)
            {
                string query = "SELECT * FROM {database}.stock";
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    var Bier_Sold = dataReader["Bier_Sold"] + "";
                    var Wijn_Sold = dataReader["Wijn_Sold"] + "";
                    var Snoep_Sold = dataReader["Snoep_Sold"] + "";
                    var AA_Sold = dataReader["AA_Sold"] + "";
                    var Fris_Sold = dataReader["Fris_Sold"] + "";
                    var Bier = dataReader["Item1"] + "";
                    var Fris = dataReader["Item2"] + "";
                    var Wijn = dataReader["Item3"] + "";
                    var Snoep = dataReader["Item4"] + "";
                    var AA = dataReader["Item5"] + "";

                    x = new String[] { Bier_Sold, Fris_Sold, Wijn_Sold, Snoep_Sold, AA_Sold, Bier, Fris, Wijn, Snoep, AA };
                }


                //close Data Reader
                dataReader.Close();
                //close Connection
                this.CloseConnection();

            }
            return x;
        }

        //public void Update_oldCount(int Bier, int Fris, int Wijn, int Snoep, int AA)
        //{
        //    //Create Command
        //    MySqlCommand cmd = new MySqlCommand();
        //    if (this.OpenConnection() == true)
        //    {
        //        string query = $"UPDATE stock SET Item1 = {Bier}, Item2 = {Fris}, Item4 = {Snoep}, Item3 = {Wijn}, Item5 = {AA};";

        //        cmd.CommandText = query;
        //        cmd.Connection = connection;
        //        cmd.ExecuteNonQuery();

        //        query = $"UPDATE stock SET Bier_Sold = 0, Fris_Sold = 0, Snoep_Sold = 0, Wijn_Sold = 0, AA_Sold = 0;";
        //        cmd.CommandText = query;
        //        cmd.Connection = connection;
        //        cmd.ExecuteNonQuery();

        //        //close Connection
        //        this.CloseConnection();
        //    }

        //}

        public void InsertRegister(String ID, String name, String LastName, String Item1, String Item2, String Item3, String Item4, String Item5, String Item6, String Item7, String Item8, String Item9, String Item10, String Totaal, String Date)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = $"insert INTO {database}.register(`id`,`Firstname`,`LastName`,`Item1`,`Item2`,`Item3`,`Item4`,`Item5`,`Item6`,`Item7`,`Item8`,`Item9`,`Item10`,`Totaal`,`Date`) " +
                $"values('{ID}', '{name}', '{LastName}', '{Item1}', '{Item2}', '{Item3}', '{Item4}', '{Item5}', '{Item6}', '{Item7}', '{Item8}', '{Item9}', '{Item10}', '{Totaal}', '{Date}');";

            if (this.OpenConnection() == true)
            {
                //Create Command

                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public void TotalLijst_to_CSV()
        {
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            String date = DateTime.Now.ToString("dd-MM-yyyy_Hmm");
            TextWriter writeFile = new StreamWriter($@"{strPath}\streeplijst data\streeplijst-{date}.csv", false);

            writeFile.WriteLine("ID;" + "FirstName;" + "LastName;" + price.Items[0] + ";" + price.Items[1] + ";" + price.Items[2] + ";" + price.Items[3] + ";" + price.Items[4] + ";" +
                               price.Items[5] + ";" + price.Items[6] + ";" + price.Items[7] + ";" + price.Items[8] + ";" + price.Items[9]);
            writeFile.WriteLine(";" + ";" + ";" + price.Item_prices[0] + ";" + price.Item_prices[1] + ";" + price.Item_prices[2] + ";" + price.Item_prices[3] + ";" + price.Item_prices[4] + ";" +
                   price.Item_prices[5] + ";" + price.Item_prices[6] + ";" + price.Item_prices[7] + ";" + price.Item_prices[8] + ";" + price.Item_prices[9]);

            string query = $"SELECT* FROM parabool.streeplijst INNER JOIN parabool.nameslist ON parabool.streeplijst.id = parabool.nameslist.id";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    writeFile.WriteLine(dataReader["id"] + ";" + dataReader["FirstName"] + ";" + dataReader["LastName"] + ";" +
                                        dataReader["Item1"] + ";" + dataReader["Item2"] + ";" +
                                        dataReader["Item3"] + ";" + dataReader["Item4"] + ";" +
                                        dataReader["Item5"] + ";" + dataReader["Item6"] + ";" +
                                        dataReader["Item7"] + ";" + dataReader["Item8"] + ";" +
                                        dataReader["Item9"] + ";" + dataReader["Item10"]);
                }
                //close Data Reader
                dataReader.Close();

                //query = $"truncate {database}.register";
                //cmd.CommandText = query;
                //cmd.Connection = connection;
                //cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();
            }

            writeFile.Flush();
            writeFile.Close();
            writeFile = null;
        }

        public void Register_to_CSV()
        {
            string strPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            String date = DateTime.Now.ToString("dd-MM-yyyy_Hmm");
            TextWriter writeFile = new StreamWriter($@"{strPath}\streeplijst data\register-{date}.csv", false);
            
            writeFile.WriteLine("ID;" + "FirstName;" + "LastName;" + price.Items[0] + ";" + price.Items[1] + ";" + price.Items[2] + ";" + price.Items[3] + ";" + price.Items[4] + ";" +
                               price.Items[5] + ";" + price.Items[6] + ";" + price.Items[7] + ";" + price.Items[8] + ";" + price.Items[9] + ";" + "totaal;" + "date");
            writeFile.WriteLine(";" + ";" + ";" + price.Item_prices[0] + ";" + price.Item_prices[1] + ";" + price.Item_prices[2] + ";" + price.Item_prices[3] + ";" + price.Item_prices[4] + ";" +
                   price.Item_prices[5] + ";" + price.Item_prices[6] + ";" + price.Item_prices[7] + ";" + price.Item_prices[8] + ";" + price.Item_prices[9] + ";" + ";" + "");

            string query = $"SELECT * from {database}.register";
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    writeFile.WriteLine(dataReader["id"] + ";" + dataReader["FirstName"] + ";" + dataReader["LastName"] + ";" +
                                        dataReader["Item1"] + ";" + dataReader["Item2"] + ";" +
                                        dataReader["Item3"] + ";" + dataReader["Item4"] + ";" +
                                        dataReader["Item5"] + ";" + dataReader["Item6"] + ";" +
                                        dataReader["Item7"] + ";" + dataReader["Item8"] + ";" +
                                        dataReader["Item9"] + ";" + dataReader["Item10"] + ";" +
                                        dataReader["Totaal"] + ";" + dataReader["Date"]);

                }
                //close Data Reader
                dataReader.Close();

                query = $"truncate {database}.register";
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();
            }

            writeFile.Flush();
            writeFile.Close();
            writeFile = null;

        }
        public void ResetDATA(string table)
        {
            MySqlCommand cmd = new MySqlCommand();
            string query =  $"DELETE FROM {database}.{table}";

            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }


        public void ResetDATA(string table, string item1, string item2, string item3, string item4, string item5, string item6, string item7,
            string item8, string item9, string item10)
        {
            MySqlCommand cmd = new MySqlCommand();

            string query = $"UPDATE {database}.{table} SET {item1} = 0,{item2} = 0,{item3} = 0,{item4} = 0,{item5} = 0,{item6} = 0,{item7} = 0,{item8} = 0," +
                    $"{item9} = 0,{item10} = 0;";
         

            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        public void ResetDATA(string table, string item)
        {
            MySqlCommand cmd = new MySqlCommand();

            string query = $"UPDATE {database}.{table} SET {item} = 0;";


            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }

        }

        public void ResetMontly()
        {
            MySqlCommand cmd = new MySqlCommand();
            string query = $"UPDATE {database}.maandelijks SET Item111 = 0;";

            if (this.OpenConnection() == true)
            {
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }

        }
    }
}
