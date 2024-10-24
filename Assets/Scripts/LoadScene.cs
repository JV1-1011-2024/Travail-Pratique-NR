using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChargementSalleAManger()
    {
         SceneManager.LoadScene("Salle à manger");
    }

    public void ChargementCuisine()
    {
         SceneManager.LoadScene("Cuisine");
    }

    public void ChargementChambre()
    {
         SceneManager.LoadScene("Chambre");
    }

}