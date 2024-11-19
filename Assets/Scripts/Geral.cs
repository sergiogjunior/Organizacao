using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{

    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public GameObject gameOver, personagemPrincipal, ferramenta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        recordeNum = 0;
    }

    public void MarcarPonto()
    {
        placarJogadorNum += 1;

        if (recordeNum < placarJogadorNum) 
            recordeNum += 1;

        AtualizarTextoPlacar();

        GetComponent<AudioSource>().Play();
    }

    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados:" + placarJogadorNum;
        recordeTexto.text = "Recorde atual:" + recordeNum;
    }

    public void IniciarPartida()
    {
        placarJogadorNum = 0;
        AtualizarTextoPlacar();
        
        // Sumir com game-over
        gameOver.SetActive(false);

        // Reposicionar luva
        personagemPrincipal.transform.position = new Vector3(875, 250, 0);

        // Reposicionarr ferramenta
        ferramenta.GetComponent<ControladorFerramenta>().posicaoFerramenta = new Vector3(0, 0, 0);

        // Voltar a velocidade para o "padrão"
        ferramenta.GetComponent<ControladorFerramenta>().deslocamentoferramenta =
            ferramenta.GetComponent<ControladorFerramenta>().deslocamentoInicial;
    }
}
