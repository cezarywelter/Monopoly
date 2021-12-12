using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Buying : MonoBehaviour
{
    // public int property_id; //This is the position/id of the property
    public string property_name;//This is the name of the property
    public string property_group; //This is the group the property is in
    public int property_value; //This is how much it costs to buy the property
    public int? property_cost; //This is how much it costs to buy a house/hotel
    public int? property_rent; //This is the rent if the player that doesn't land on it has to pay
    public int? property_house1; //This is the rent if it has 1 house
    public int? property_house2; //This is the rent if it has 2 houses
    public int? property_house3; //This is the rent if it has 3 houses
    public int? property_house4; //This is the rent if it has 4 houses
    public int? property_hotel; //This is the rent if it has a hotel
    public int houses; //How many houses it has. (Can have up to 4)
    public bool hotel; //Whether it has a hotel or not. (Can only have 1)
                       // public bool mortgage; //Whether the property has been mortgaged.

    public int playerProperty = 0;

    //roboczo
    

    void Start()
    {
        GetComponent<Collider>().enabled = false;
        GameManager.Instance.listofstones.Add(GetComponent<Buying>());
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider collider)
    {
        // zamiast tego to poprzez gamemanagier odwolujesz sie do pionka ktory jak juz stanie na swoim miejscu to 
        Debug.Log("TriggerEnter");
        if (collider.gameObject.name == "Cylinder") /* GameManager.instance.player.isInPosition /) 
        
            // gamemanadzier zrobisz
            //sent message do popupa

            / collider.gameObject sprawdzic czy jest zajety 
             jesli nie to czy chce kupic


    
             */
        {

        }
    }
}