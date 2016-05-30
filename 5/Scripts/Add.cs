using UnityEngine;
using System.Collections;
using AppodealAds.Unity.Api;

public class Add : MonoBehaviour
{
    public string appKey;
    public bool Ready;

    // Use this for initialization
    void Start()
    {
        Appodeal.initialize(appKey, Appodeal.REWARDED_VIDEO | Appodeal.INTERSTITIAL);
        if (Time.time > 15)
        {
            Ready = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*/if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {/*/
            if (Ready)
            {
                Appodeal.show(Appodeal.REWARDED_VIDEO);
                Ready = false;
            }
       // }
       /*/ else
        {
            if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
            {
                if (Ready)
                {
                    Appodeal.show(Appodeal.INTERSTITIAL);
                    Ready = false;
                }
            }
        }/*/
    }
}
