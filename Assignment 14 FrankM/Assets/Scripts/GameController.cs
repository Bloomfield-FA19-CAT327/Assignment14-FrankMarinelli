using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("If you are seeing this, then everything is working correctly. Hopefully.");
        Analytics.CustomEvent("startingLevel");
        
    }


    public void BigButtonPressed()
    {
        Analytics.CustomEvent("primaryUI", new Dictionary<string, object>
        {
            { "buttonPressed", "mainButton" },
            { "aValue", "timesPressed" }
        });

        
    }

    public void SecretButtonPressed()
    {
        Analytics.CustomEvent("locatedSecretButton");
    }

    public void BeautifulButtonPressed()
    {
        Analytics.CustomEvent("secondaryUI", new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), Random.Range(0f, 10f))); 
    }
}
