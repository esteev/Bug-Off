using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Mono.Data.SqliteClient;
using System.Data;

public class DatabaseConnect : MonoBehaviour
{
    private static DatabaseConnect instance;
    public static DatabaseConnect Instance { get { return instance; } }
    // Use this for initialization

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
		KaChow.Instance.allRegions = ReadDatabase();
    }

	Hashtable ReadDatabase()
    {
        string conn = "URI=file:" + Application.dataPath + "/localStorage.db"; //Path to database.
        Debug.Log("Path is : " + conn);
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * " + "FROM TitleData";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        while (reader.Read())
        {
        /*    Place tempPlace = new Place(
                (int)reader["Number"],
                (string)reader["Name"],
                (PlaceColor)reader["Color"],
                (int)reader["CostBasic"],
                (int)reader["CostHouse"],
                (int)reader["CostHotel"],
                (int)reader["MortgageValue"],
                (int)reader["RentBasic"],
                (int)reader["Rent1House"],
                (int)reader["Rent2House"],
                (int)reader["Rent3House"],
                (int)reader["RentHotel"]
                );
            placeList.Add(tempPlace);
          */  
        }
 //       Debug.Log("Total no of places registered are: " + placeList.Count);

        //Just testing here
        /*
         * Debug.Log(placeList[10].placeName);
        */
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
        return null;
    }
    
    
}
