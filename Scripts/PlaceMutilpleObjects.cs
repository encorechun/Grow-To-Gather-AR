using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMutilpleObjects : MonoBehaviour
{
    private PlaceIndicator placeIndicator;

    public GameObject objectFirst;
    public GameObject objectSecond;
    public GameObject objectThird;
    public GameObject objectFourth;
    public GameObject objectFifth;
    public GameObject objectSixth;
    public GameObject objectSeventh;
    public GameObject objectEighth;

    private GameObject objectToPlace;
    
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator>();
    }

    public void InstantiateObject()
    {
        Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation); 
    }
    public void ClickToPlaceFirst()
    {
        objectToPlace = objectFirst;
        InstantiateObject();
    }
    public void ClickToPlaceSecond()
    {
        objectToPlace = objectSecond;
        InstantiateObject();
    }
    public void ClickToPlaceThird()
    {
        objectToPlace = objectThird;
        InstantiateObject();
    }
    public void ClickToPlaceFourth()
    {
        objectToPlace = objectFourth;
        InstantiateObject();
    }
    public void ClickToPlaceFifth()
    {
        objectToPlace = objectFifth;
        InstantiateObject();
    }
    public void ClickToPlaceSixth()
    {
        objectToPlace = objectSixth;
        InstantiateObject();
    }
    public void ClickToPlaceSeventh()
    {
        objectToPlace = objectSeventh;
        InstantiateObject();
    }
    public void ClickToPlaceEighth()
    {
        objectToPlace = objectEighth;
        InstantiateObject();
    }
}
