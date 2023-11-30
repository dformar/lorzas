using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Food : MonoBehaviour
{
    public enum FoodVariety { 
        Rice,
        Banana,
        BobaTea,
        Bottle,
        Cereal,
        Mushroom,
        Chocolate,
        ChickenLeg,
        Coffee,
        Cookie,
        Donut,
        Strawberry,
        Gelatin,
        Hamburguer,
        Apple,
        Pear,
        HotDog,
        DogFood,
        Pizza,
        Cheese,
        Cake,
        Tomatoe,
        Grape,
        Carrot
    }

    [SerializeField]
    private FoodVariety Variety;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Consume()
    {
        Destroy(this.gameObject);
    }

    public FoodVariety GetFoodVariety()
    {
        return this.Variety;
    }

}
