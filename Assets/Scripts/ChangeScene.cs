using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string nomeDaCena;
    //Nome da Cena que escolhera no aplicativo unity e fara com que o botão puxe tal Cena
    public void ChangeS()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
    //Método que fara puxar a próxima tela do aplicativo.
    public void Sair()
    {
        Application.Quit();
    }
    //Método que faz aplicativo fechar e finalizar no android.

}
