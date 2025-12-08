using UnityEngine;

public class ConfigBotao : MonoBehaviour
{

    public string nomeDoFilho = "Configurations";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;

        Transform filho = transform.Find(nomeDoFilho);
		filho.gameObject.SetActive(false);
    }

    public void MostrarConfig(){
        Transform filho = transform.Find(nomeDoFilho);
		filho.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void VoltarProJogo(){
        Transform filho = transform.Find(nomeDoFilho);
		filho.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
