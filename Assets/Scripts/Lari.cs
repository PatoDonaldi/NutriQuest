using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lari : MonoBehaviour
{
    [Header("Fofinho")]
    [SerializeField] private GameObject telaVitoria;
    [SerializeField] private GameObject telaDerrota;
    [SerializeField] private TextMeshProUGUI textoTimer;
    private float tempoTotal = 90f;
    private bool jogoAtivo = true;


    void Start()
    {
        telaVitoria.SetActive(false);
        telaDerrota.SetActive(false);

    }

    void Update()
    {
        if (!jogoAtivo) return;

        tempoTotal -= Time.deltaTime;
        int minutos = Mathf.FloorToInt(tempoTotal / 60);
        int segundos = Mathf.FloorToInt(tempoTotal % 60);
        textoTimer.text = $"Tempo: {minutos:00}:{segundos:00}";

        if (tempoTotal <= 0f)
        {
            Derrota();
        }
    }
    public void verificaPrato()
    {
            
    }

    private void Derrota()
    {
        jogoAtivo = false;
        telaDerrota.SetActive(true);
    }
    private void Vitoria()
    {
        jogoAtivo = false;
        telaVitoria.SetActive(true);
    }
}