using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuManager : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("SCN_Level01");
    }

    public void Sair()
    {
        Debug.Log("Sair do jogo!"); 
        Application.Quit(); 
    }
}