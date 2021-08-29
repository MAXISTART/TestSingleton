using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GenericSingleton<GameManager>
{

    public int i = 0;
    public int j = 1;

    public override void Clone(GameManager oldCp, GameManager newCp)
    {
        newCp.i = oldCp.i;
        newCp.j = oldCp.j;
    }


    public void Dosth() {
        Debug.Log($"do sth:{i}, {j}");
    }

    public void RestartGame() {
        Debug.Log("game restarting");
        SceneManager.LoadScene(0);
    }

}
