using UnityEditor.SceneManagement;
using UnityEngine;

public class SceneOpnenerOnCollision : SceneOpener
{
    public string NextLevelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OpenScene(NextLevelName);
    }
}
