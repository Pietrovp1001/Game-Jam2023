using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class JsonSaveLoadSystem : MonoBehaviour
{
    private const string FileName = "jsonPlayerData.data";
    public event Action DataLoaded;
    [SerializeField]
    private JsonPlayerInfo jsonPlayerInfo;
    public JsonPlayerInfo JsonPlayerInfo => jsonPlayerInfo;
    public static JsonSaveLoadSystem Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    [ContextMenu("Save")]
    public void Save()
    {
        string playerInfoJson = JsonUtility.ToJson(jsonPlayerInfo);
        string path = Path.Combine(Application.persistentDataPath, FileName);
        File.WriteAllText(path, playerInfoJson);

        Debug.Log(path);
    }
    [ContextMenu("Load")]
    public void Load()
    {
        string path = Path.Combine(Application.persistentDataPath, FileName);
        string playerInfoJson = File.ReadAllText(path);
        JsonPlayerInfo jsonPlayerInfoLoaded = JsonUtility.FromJson<JsonPlayerInfo>(playerInfoJson);
        
        jsonPlayerInfo.firstTime = jsonPlayerInfoLoaded.firstTime;
        jsonPlayerInfo.fpsFrameRate = jsonPlayerInfoLoaded.fpsFrameRate;
        jsonPlayerInfo.ddvFrames = jsonPlayerInfoLoaded.ddvFrames;
        DataLoaded?.Invoke();
    }
}
