using System.Collections;
using System.Collections.Generic;

public class Bank {

	// Test Comment
	Dictionary<string, int> Vault = new Dictionary<string, int>();

	public void Deposit(string currency, int amount)
	{
		if(Vault.ContainsKey(currency))
		{
			Vault[currency] += amount;
		}
		else
		{
			Vault.Add(currency, amount);
		}
	}

	public void Withdraw(string currency, int amount)
	{
		if(Vault.ContainsKey(currency))
		{
			Vault[currency] -= amount;
		}
		else
		{
			Vault.Add(currency, -amount);
		}
	}

	public int GetAmount(string currency)
	{
		if(!Vault.ContainsKey(currency))
		{
			Vault.Add(currency, 0);
			return 0;
		}

		return Vault[currency];
	}

	public List< KeyValuePair<string,int> > GetBankInList()
	{
		List< KeyValuePair<string,int> > result = new List< KeyValuePair<string,int> >();

		foreach(var val in Vault)
		{
			result.Add( new KeyValuePair<string,int>(val.Key, val.Value) );
		}

		return result;	
	}

	public void FillBankWithList( KeyValuePair<string,int> list)
	{
		foreach(var val in Vault)
		{
			Deposit( val.Key, val.Value );
		}
	}
}