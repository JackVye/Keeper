using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keeper.Models;
using Newtonsoft.Json;

namespace Keeper.DatabadeModels
{
    public class SQL
    {
        private string connectionString = "Server=(localdb)\\mssqllocaldb; Database=Keeper; Integrated Security=True;";

        public List<Unit> GetAllUnassignedUnits()
        {
            DataTable allUnits = new DataTable();
            List<Unit> unitList = new List<Unit>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Keeper].[dbo].[UnassignedUnits];";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(allUnits);

                    foreach (DataRow row in allUnits.Rows)
                    {
                        Unit u = new Unit();

                        u.name = Convert.ToString(row["name"]);
                        u.race = Convert.ToString(row["race"]);
                        u.Proficiencies = Newtonsoft.Json.JsonConvert.DeserializeObject<Proficiencies>(Convert.ToString(row["Proficiencies"]));
                        u.Attributes = Newtonsoft.Json.JsonConvert.DeserializeObject<Attributes>(Convert.ToString(row["Attributes"]));

                        unitList.Add(u);
                    }

                    return unitList;
                }
            }
        }

        public List<Unit> GetAllUnitsForRegion(string regionName)
        {
            DataTable allUnits = new DataTable();
            List<Unit> unitList = new List<Unit>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Keeper].[dbo].[AssignedUnits] WHERE RegionName = @regionName;";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))

                {
                    cmd.Parameters.AddWithValue("@regionName", regionName);

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(allUnits);

                    foreach (DataRow row in allUnits.Rows)
                    {
                        Unit u = new Unit();

                        u.name = Convert.ToString(row["name"]);
                        u.race = Convert.ToString(row["race"]);
                        u.Proficiencies = Newtonsoft.Json.JsonConvert.DeserializeObject<Proficiencies>(Convert.ToString(row["Proficiencies"]));
                        u.Attributes = Newtonsoft.Json.JsonConvert.DeserializeObject<Attributes>(Convert.ToString(row["Attributes"]));

                        unitList.Add(u);
                    }

                    return unitList;
                }
            }
        }

        public List<Accesory> GetAllUnassignedAccessories()
        {
            //includes all items, a sword is an accessory that gives a damage and has type: mainhand,offhand
            DataTable allAccessories = new DataTable();
            List<Accesory> accesoryList = new List<Accesory>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [Keeper].[dbo].[UnassignedAccerories];";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(allAccessories);

                    foreach (DataRow row in allAccessories.Rows)
                    {
                        Accesory a = new Accesory();

                        a.name = Convert.ToString(row["name"]);
                        a.effect = Convert.ToString(row["race"]);
                        a.attunement = Convert.ToBoolean(row["attunement"]);
                        a.type = Convert.ToString(row["type"]);

                        accesoryList.Add(a);
                    }

                    return accesoryList;
                }
            }
        }


    }
}