using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        
        IEnumerator loadScene(){
            AsyncOperation loading = SceneManager.LoadSceneAsync("game");
            while (!loading.isDone){
                yield return null;
            }
        }
    
        btn.onClick.AddListener(() => StartCoroutine(loadScene()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
