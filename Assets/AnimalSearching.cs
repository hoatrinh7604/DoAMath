using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalSearching : MonoBehaviour
{
    [SerializeField] Sprite[] listAnimal;
    [SerializeField] Image target;
    [SerializeField] Image nextTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTarget(int id)
    {
        target.sprite = listAnimal[id];
    }

    public void SetNextTarget(int id)
    {
        nextTarget.sprite = listAnimal[id];
    }

    public int GetAmountAnimals()
    {
        return listAnimal.Length;
    }
}
