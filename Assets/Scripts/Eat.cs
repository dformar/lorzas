using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Collider))]
[RequireComponent (typeof(Weight))]
[DisallowMultipleComponent]
public class Eat : MonoBehaviour
{
    [SerializeField]
    private float RiceWeight = 0.3f;
    [SerializeField]
    private float BananaWeight = 0.2f;
    [SerializeField]
    private float BobaWeight = 0.5f;
    [SerializeField]
    private float BottleWeight = 0.1f;
    [SerializeField]
    private float CerealWeight = 0.2f;
    [SerializeField]
    private float MushroomWeight = 0.1f;
    [SerializeField]
    private float ChocolateWeight = 0.3f;
    [SerializeField]
    private float ChickenLegWeight = 0.4f;
    [SerializeField]
    private float CoffeeWeight = 0.1f;
    [SerializeField]
    private float CookieWeight = 0.2f;
    [SerializeField]
    private float DonutWeight = 0.3f;
    [SerializeField]
    private float StrawberryWeight = 0.1f;
    [SerializeField]
    private float GelatinWeight = 0.1f;
    [SerializeField]
    private float HamburguerWeight = 0.3f;
    [SerializeField]
    private float AppleWeight = 0.1f;
    [SerializeField]
    private float PearWeight = 0.1f;
    [SerializeField]
    private float HotDogWeight = 0.2f;
    [SerializeField]
    private float DogFoodWeight = 0.5f;
    [SerializeField]
    private float PizzaWeight = 0.3f;
    [SerializeField]
    private float CheeseWeight = 0.3f;
    [SerializeField]
    private float CakeWeight = 0.4f;
    [SerializeField]
    private float TomatoeWeight = 0.2f;
    [SerializeField]
    private float GrapeWeight = 0.2f;
    [SerializeField]
    private float CarrotWeight = 0.1f;

    [SerializeField]
    private float RiceEnergy = 2f;
    [SerializeField]
    private float BananaEnergy = 2f;
    [SerializeField]
    private float BobaEnergy = -1f;
    [SerializeField]
    private float BottleEnergy = 1f;
    [SerializeField]
    private float CerealEnergy = 1f;
    [SerializeField]
    private float MushroomEnergy = -1f;
    [SerializeField]
    private float ChocolateEnergy = -2f;
    [SerializeField]
    private float ChickenLegEnergy = 2f;
    [SerializeField]
    private float CoffeeEnergy = -1f;
    [SerializeField]
    private float CookieEnergy = -1f;
    [SerializeField]
    private float DonutEnergy = 1f;
    [SerializeField]
    private float StrawberryEnergy = 3f;
    [SerializeField]
    private float GelatinEnergy = -1f;
    [SerializeField]
    private float HamburguerEnergy = 2f;
    [SerializeField]
    private float AppleEnergy = 2f;
    [SerializeField]
    private float PearEnergy = 2f;
    [SerializeField]
    private float HotDogEnergy = 2f;
    [SerializeField]
    private float DogFoodEnergy = 4f;
    [SerializeField]
    private float PizzaEnergy = 1f;
    [SerializeField]
    private float CheeseEnergy = 2f;
    [SerializeField]
    private float CakeEnergy = -2f;
    [SerializeField]
    private float TomatoeEnergy = 2f;
    [SerializeField]
    private float GrapeEnergy = 2f;
    [SerializeField]
    private float CarrotEnergy = 2f;

    [SerializeField]
    private float ChocolateStun = 3f;


    private Weight Weight;
    private Stamina Stamina;
    private Stun Stun;


    // Start is called before the first frame update
    void Start()
    {
        this.Weight = this.GetComponent<Weight>();
        this.Stamina = this.GetComponent<Stamina>();
        this.Stun = this.GetComponent<Stun>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Food food = other.GetComponent<Food>();
        if (food != null)
        {
            this.Devour(food);
        }
    }

    private void Devour(Food food)
    {
        switch (food.GetFoodVariety())
        {
            case Food.FoodVariety.Rice:
                this.Weight.IncreaseBy(this.RiceWeight);
                this.Stamina.VaryBy(this.RiceEnergy);
                break;
            case Food.FoodVariety.Banana:
                this.Weight.IncreaseBy(this.BananaWeight);
                this.Stamina.VaryBy(this.BananaEnergy);
                break;
            case Food.FoodVariety.BobaTea:
                this.Weight.IncreaseBy(this.BobaWeight);
                this.Stamina.VaryBy(this.BobaEnergy);
                break;
            case Food.FoodVariety.Bottle:
                this.Weight.IncreaseBy(this.BottleWeight);
                this.Stamina.VaryBy(this.BottleEnergy);
                break;
            case Food.FoodVariety.Cereal:
                this.Weight.IncreaseBy(this.CerealWeight);
                this.Stamina.VaryBy(this.CerealEnergy);
                break;
            case Food.FoodVariety.Mushroom:
                this.Weight.IncreaseBy(this.MushroomWeight);
                this.Stamina.VaryBy(this.MushroomEnergy);
                break;
            case Food.FoodVariety.Chocolate:
                this.Weight.IncreaseBy(this.ChocolateWeight);
                this.Stamina.VaryBy(this.ChocolateEnergy);
                this.Stun.StunFor(this.ChocolateStun);
                break;
            case Food.FoodVariety.ChickenLeg:
                this.Weight.IncreaseBy(this.ChickenLegWeight);
                this.Stamina.VaryBy(this.ChickenLegEnergy);
                break;
            case Food.FoodVariety.Coffee:
                this.Weight.IncreaseBy(this.CoffeeWeight);
                this.Stamina.VaryBy(this.CoffeeEnergy);
                break;
            case Food.FoodVariety.Cookie:
                this.Weight.IncreaseBy(this.CookieWeight);
                this.Stamina.VaryBy(this.CookieEnergy);
                break;
            case Food.FoodVariety.Donut:
                this.Weight.IncreaseBy(this.DonutWeight);
                this.Stamina.VaryBy(this.DonutEnergy);
                break;
            case Food.FoodVariety.Strawberry:
                this.Weight.IncreaseBy(this.StrawberryWeight);
                this.Stamina.VaryBy(this.StrawberryEnergy);
                break;
            case Food.FoodVariety.Gelatin:
                this.Weight.IncreaseBy(this.GelatinWeight);
                this.Stamina.VaryBy(this.GelatinEnergy);
                break;
            case Food.FoodVariety.Hamburguer:
                this.Weight.IncreaseBy(this.HamburguerWeight);
                this.Stamina.VaryBy(this.HamburguerEnergy);
                break;
            case Food.FoodVariety.Apple:
                this.Weight.IncreaseBy(this.AppleWeight);
                this.Stamina.VaryBy(this.AppleEnergy);
                break;
            case Food.FoodVariety.Pear:
                this.Weight.IncreaseBy(this.PearWeight);
                this.Stamina.VaryBy(this.PearEnergy);
                break;
            case Food.FoodVariety.HotDog:
                this.Weight.IncreaseBy(this.HotDogWeight);
                this.Stamina.VaryBy(this.HotDogEnergy);
                break;
            case Food.FoodVariety.DogFood:
                this.Weight.IncreaseBy(this.DogFoodWeight);
                this.Stamina.VaryBy(this.DogFoodEnergy);
                break;
            case Food.FoodVariety.Pizza:
                this.Weight.IncreaseBy(this.PizzaWeight);
                this.Stamina.VaryBy(this.PizzaEnergy);
                break;
            case Food.FoodVariety.Cheese:
                this.Weight.IncreaseBy(this.CheeseWeight);
                this.Stamina.VaryBy(this.CheeseEnergy);
                break;
            case Food.FoodVariety.Cake:
                this.Weight.IncreaseBy(this.CakeWeight);
                this.Stamina.VaryBy(this.CakeEnergy);
                break;
            case Food.FoodVariety.Tomatoe:
                this.Weight.IncreaseBy(this.TomatoeWeight);
                this.Stamina.VaryBy(this.TomatoeEnergy);
                break;
            case Food.FoodVariety.Grape:
                this.Weight.IncreaseBy(this.GrapeWeight);
                this.Stamina.VaryBy(this.GrapeEnergy);
                break;
            case Food.FoodVariety.Carrot:
                this.Weight.IncreaseBy(this.CarrotWeight);
                this.Stamina.VaryBy(this.CarrotEnergy);
                break;
            default:
                break;
        }
        food.Consume();
    }
}
