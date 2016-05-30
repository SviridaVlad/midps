using UnityEngine;
using System.Collections;

public class LoadingScreen : MonoBehaviour {

    IEnumerator Start()
    {
        AsyncOperation async = Application.LoadLevelAsync("night_city");
        yield return async;
    }
}
