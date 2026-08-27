using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeCenas : MonoBehaviour
{
    public void CarregarMenuPrincipal()
    {
        SceneManager.LoadScene("SCN_Menu"); 
    }
}