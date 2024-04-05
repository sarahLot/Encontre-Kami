using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class passarMenu : MonoBehaviour
{
    [SerializeField] float tempoIrProximaFase = 10f;
    private void Start()
    {
        StartCoroutine(IrFase());

    }

    IEnumerator IrFase()
    {
        yield return new WaitForSeconds(tempoIrProximaFase);
        SceneManager.LoadScene("SampleScene");
    }
}
