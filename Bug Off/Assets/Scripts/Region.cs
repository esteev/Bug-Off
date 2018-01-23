struct connections
{
	float water;	//under sea cables
	float air;		// satellite, radio
	float land;		// WAN, Fibre, Cables

	public void init(float w, float a, float l)
	{
		water = w;
		air = a;
		land = l;
	}
}

struct divisions
{
	float civilian;		//generalized internet available to masses
	float government;	//high security private networks
	float community;	//organizational networks

	public void init(float ci, float g, float co)
	{
		civilian = ci;
		government = g;
		community = co;
	}
}

class networking
{
	connections conn;
	divisions div;
	public int devicePopulation;                      //Total Device Population

	public int healthyDevices;                        //Uninfected Devices

	public networking(int dP, float w, float a, float l, float ci, float g, float co)
	{
		conn.init (w, a, l);
		div.init (ci, g, co);
		devicePopulation = healthyDevices = dP;
	}

	public void infectDevice(int val)
	{
		healthyDevices -= val;
	}
}

public class Region{

	public bool infected;

    public int regionNo;
    public string regionIdentifier;

    public float techLevel;                           // LOW(0) MEDIUM(0.5) HIGH(1)
    public float literacy;                            //Literacy Rate of Region, (0f,1f)

	networking regionNetwork;						//holds all region network properties

	void init (int rgNo, string rgId, float tLvl, float lit, int dP, float w, float a, float l, float ci, float g, float co) 
	{
		infected = false;
		regionNetwork = new networking (dP, w, a, l, ci, g, co);
		regionNo = rgNo;
		regionIdentifier = rgId;
		techLevel = tLvl;
		literacy = lit;
	}

	void infect()
	{
		infected = true;
		regionNetwork.infectDevice (1);
	}
	
	void Update () 
	{
		
	}
}