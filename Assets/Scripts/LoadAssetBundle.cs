using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    AssetBundle Loadassetbundle;
    public string Url;
    private void Start()
    {

        LoadAsset(Url);
        //Spawn_Asset(Name);
    }

    public void LoadAsset(string Url)
    {
        Loadassetbundle = AssetBundle.LoadFromFile(Url);
        Debug.Log(Loadassetbundle == null ? "true: Falied to load" : "flase: Successfully Loaded");
    }

    public void Spawn_Asset(string Name)
    {
        var prefab =Loadassetbundle.LoadAsset(Name);
        Instantiate(prefab);
    }
}
