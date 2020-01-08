using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using OpenCVForUnity;

public class sku {

	//Data Class to store parameters
	public bool sPurchased;
	public string sItemID;
	public string sDisplayName;
	public string sDescription;
	public uint sAmount;


	//Constructors
	public sku (bool purchased, string itemID, string displayName, string description, uint amount){
		sPurchased = purchased;
		sItemID = itemID;
		sDisplayName = displayName;
		sDescription = description;
		sAmount = amount;
	} 
}
