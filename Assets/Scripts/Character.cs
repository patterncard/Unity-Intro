using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health = 10;

    // Start is called before the first frame update
    void Start()
    {
        print(reduceHealth(2));
        print(reduceHealth(5));

    }

    public int reduceHealth(int amountOfReduce)
    {

        return health -= amountOfReduce;
    }
}
