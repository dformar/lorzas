using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeightOSD : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private float CorgiWeightOffset = 4.0f;

    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        this.text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        this.text.text = (this.Player.GetComponent<Weight>().GetWeight() + this.CorgiWeightOffset).ToString();
    }
}
