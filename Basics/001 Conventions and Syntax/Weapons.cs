using System;
					
public class Program
{
	public Weapon ak47;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		ak47 = new Weapon();
		weaponPowerUp = new PowerUp();
		
		ak47.ammoCount++;
		ak47.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(ak47.weaponName + " has an ammo count of " + ak47.ammoCount + ".");
		Console.WriteLine("The fire power of is now " + ak47.firePower + ", it has increased.");
	}
}

public class Weapon { 
	public int ammoCount = 10;
	public string weaponName = "ak47";
	public float firePower = 11.5f;
}

public class PowerUp {
	public float powerLevel = 2.5f;	
}