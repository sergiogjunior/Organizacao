
using UnityEngine;
using UnityEngine.Animations;

public class ControladorJogador : MonoBehaviour
{

    public float velocidadeMaozinha;
    public Geral JuizDoJogo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Este código é para fazer a mãozinha subir
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 475)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position += novaPos;
        }
        //Este código é para fazer a mãozinha descer
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= 25)
        {
            Vector3 novaPos = new Vector3(0, velocidadeMaozinha * Time.deltaTime, 0);
            transform.position -= novaPos;
        }
        //Este código é para fazer a mãozinha subir
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 novaPos = new Vector3(velocidadeMaozinha * Time.deltaTime, 0,0);
            transform.position -= novaPos;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 novaPos = new Vector3(velocidadeMaozinha * Time.deltaTime, 0,0);
            transform.position += novaPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("Ferramenta"))
        {
            float posicaoY = Random.value * 465;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.x = 0;
            collision.GetComponent<ControladorFerramenta>().posicaoFerramenta.y = posicaoY ;

            JuizDoJogo.MarcarPonto();
        }
    }
}