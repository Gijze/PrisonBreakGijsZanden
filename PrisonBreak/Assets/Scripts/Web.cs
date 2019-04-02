using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using TMPro;
public class Web : MonoBehaviour
{
    public GameObject Text;
    
    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log( ":\nReceived: " + webRequest.downloadHandler.text);
                
                 JSONNode data = JSON.Parse(webRequest.downloadHandler.text);
                 string joke = data["value"]["joke"].Value;
                 Debug.Log(joke);
                  API[0].text = joke;
                
            }
        }
    }
    public TextMeshPro[] API = new TextMeshPro[0];
    

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetRequest("http://api.icndb.com/jokes/random?limitTo=%5Bnerdy%5D"));
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
