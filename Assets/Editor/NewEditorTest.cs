using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class NewEditorTest {
  
    [MenuItem("Utils/Add CubeSpawner To Selection")]
    void AddTheComponentYouWantToAddToSelection()
    {
        foreach (GameObject go in Selection.gameObjects)
        {
            go.AddComponent<CubeSpawner>();
        }
    }
   }

