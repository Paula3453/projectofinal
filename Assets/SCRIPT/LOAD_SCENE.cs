using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOAD_SCENE : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(1);
    }
    public void Equipo()
    {
        SceneManager.LoadScene(2);
    }
    public void Club()
    {
        SceneManager.LoadScene(3);
    }
    public void Plantilla()
    {
        SceneManager.LoadScene(4);
    }
    public void Partido()
    {
        SceneManager.LoadScene(5);
    }
    public void Clasificación()
    {
        SceneManager.LoadScene(6);
    }
    public void Entrenamiento()
    {
        SceneManager.LoadScene(7);
    }
    /*
    public void Atrás()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    */
}
