using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomControl : MonoBehaviour
{
    public float[] probs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            Debug.LogError(Choose());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Choose()
    {

        float total = 0;

        foreach (float elem in probs)
        {
            total += elem;
        }

        float randomPoint = Random.value * total;

        for (int i = 0; i < probs.Length; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Length - 1;
    }
}
