﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
//////CODIGO ATT 0101
public class responder : MonoBehaviour
{
    public GameObject btnAvancar;
    // Use this for initialization
    
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoResposta;
    public Text txtFase;
    public Text textX1;
    public Text textX2;
    //números escondidos que precisam ser adivinhados.

   
    //alternativas 
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;

    ///////////

    public string[] corretaN1;
    public string[] corretaN2;
    private int idFase;

    private bool txt1; //serve para verificar se o textX1 está vazio
    private bool txt2; //serve para verificar se o textX2 está vazio;
    private bool correta1;
    private bool correta2;

    private bool posicaoE;

    void Start()
    {
      
        idFase = 0;
        txtFase.text = "Fase " + (idFase+1);

       btnAvancar.SetActive(false); //Button avanças está invísivel no inicio 

        correta1 = false; 
        correta2 = false;
        posicaoE = false;
        txt1 = false;
        txt2 = false;

        

        respostaA.text = alternativaA[idFase];
        respostaB.text = alternativaB[idFase];
        respostaC.text = alternativaC[idFase];
        respostaD.text = alternativaD[idFase];
    }





    public void clique(string alternativa)
    {
    	//Esse método foi feito pensando o seguinte: O Usuário pode clicar na alternativa A por exemplo, 
    	//para tentar adivinhar o primeiro número escondido. Ou pode clicar na alternativa A para adivinhar
    	//o segundo número escondido, assim foi feito com todas as alternativas, pensando nessas duas possibilidades.

        if (alternativa == "A") //alternativa clicada foi a 'A'
        {
            if (txt1 == false) //textx1 está vazio
            {

                textX1.text = alternativaA[idFase]; // preenche textX1 com o numero da alternativa A
                txt1 = true; //txt1 recebe true pois o textX1 não está mais vazio
                if (alternativaA[idFase] == corretaN1[idFase]) //compara a alternativa A com o primeiro número escondido
                {


                    correta1 = true; //alternativaA é igual ao primeiro número escondido


                }
               if (alternativaA[idFase] == corretaN2[idFase]) //alternativaA é igual ao segundo número escondido
                {  //sendo assim a posição está incorreta


                    posicaoE = true; //posição errada recebe true
                }
            }


            else if (txt2 == false)
            { //preenche o textX2 com a alternativa A

                textX2.text = alternativaA[idFase]; //text2 recebe a alternativaA
                txt2 = true; //text2 não está vazio
                if (alternativaA[idFase] == corretaN2[idFase]) //compara a alternativa A com o número2 escondido
                {


                    correta2 = true; 

                    if (correta1 == true)  //correta2 já recebeu true no if acima. Então este if compara se o primeiro número a ser adivinhado                   
                    {//já foi acertado.

                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true); //button avançar fica vísivel
                    }
                    else if (posicaoE == true) //se o número n1 não foi acertado antes de dar 
                    {                         //a resposta como errada ele compara se a posição errada recebeu true, se sim, quer dizer
                    	                      //que o usuário acertou um número, porém na posição errada.
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaA[idFase] == corretaN1[idFase]) //se Alternativa A = corretaN1 -> posição errada recebe true
                {                                                   //pois o número1 já foi preenchido(tendo a possibilidade de estar errado ou não)
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }

                else if (alternativaA[idFase] != corretaN2[idFase])  //se alternativa A não for igual ao segundo número escondido
                {

                    if (correta1 == true) //se o usuário acertou pelo menos o primeiro número escondido 
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if (posicaoE == true) // se o usuário acertou qualquer um dos dois, porém na posição errada
                    {
                        infoResposta.text = "Meio certo";
                    }

                }

            }


        }/////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        else if (alternativa == "B")
        {
            if (txt1 == false)
            {

                textX1.text = alternativaB[idFase]; // preenche textX1 com o numero da alternativa B
                txt1 = true;
                if (alternativaB[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //primeiro número selecionado correto recebe true


                }
                else if (alternativaB[idFase] == corretaN2[idFase])
                {

                    posicaoE = true;
                }
            }


            else if (txt2 == false)
            { //preenche o textX2 com a alternativa B

                textX2.text = alternativaB[idFase];
                txt2 = true;
                if (alternativaB[idFase] == corretaN2[idFase])
                {


                    correta2 = true;
                    if (correta1 == true)
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaB[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }

                else if (alternativaB[idFase] != corretaN2[idFase])
                {

                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }


                }





            }
        }/////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////
        else if (alternativa == "C")
        {
            if (txt1 == false)
            {

                textX1.text = alternativaC[idFase]; // preenche textX1 com o numero da alternativa C
                txt1 = true;
                if (alternativaC[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //primeiro número selecionado correto recebe true


                }
                else if (alternativaC[idFase] == corretaN2[idFase])
                {

                    posicaoE = true;
                }
            }




            else if (txt2 == false)
            { //preenche o textX2 com a alternativa C

                textX2.text = alternativaC[idFase];
                txt2 = true;
                if (alternativaC[idFase] == corretaN2[idFase])
                {


                    correta2 = true;
                    if (correta1 == true)
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaC[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }
                else if (alternativaC[idFase] != corretaN2[idFase])
                {
                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if(posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                }


            }
        }/////////////////////////////////////////////////////////////////////////////
         //////////////////////////////////////////////////////////////////////////////
         /////////////////////////////////////////////////////////////////////////////
        else if (alternativa == "D")
        {
            if (txt1 == false)
            {

                textX1.text = alternativaD[idFase]; // preenche textX1 com o numero da alternativa C
                txt1 = true;
                if (alternativaD[idFase] == corretaN1[idFase]) //compara a alternativa A com o número escondido
                {


                    correta1 = true; //primeiro número selecionado correto recebe true


                }
                else if (alternativaD[idFase] == corretaN2[idFase])
                {

                    posicaoE = true;
                }
            }




            else if (txt2 == false)
            { //preenche o textX2 com a alternativa C

                textX2.text = alternativaD[idFase];
                txt2 = true;
                if (alternativaD[idFase] == corretaN2[idFase])
                {


                    correta2 = true;
                    if (correta1 == true)
                    {
                        infoResposta.text = "Você acertou";
                        btnAvancar.SetActive(true);
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }





                }
                else if (alternativaD[idFase] == corretaN1[idFase])
                {
                    posicaoE = true;
                    infoResposta.text = "Meio certo";

                }
                else if (alternativaD[idFase] != corretaN2[idFase])
                {
                    if (correta1 == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                    else if (posicaoE == true)
                    {
                        infoResposta.text = "Meio certo";
                    }
                }


            }
        }


    }

    

    public void proximaFase()
        {
        btnAvancar.SetActive(false);
        idFase++;
        txtFase.text = "Fase: " + (idFase + 1);

        correta1 = false;
        correta2 = false;

        txt1 = false;
        txt2 = false;
        posicaoE = false;
        

        respostaA.text = alternativaA[idFase];
        respostaB.text = alternativaB[idFase];
        respostaC.text = alternativaC[idFase];
        respostaD.text = alternativaD[idFase];

        textX1.text = " ";
        textX2.text = " ";
        infoResposta.text = " ";

    }
    
    public void reiniciar()
    {
        

        correta1 = false;
        correta2 = false;

        txt1 = false;
        txt2 = false;
        posicaoE = false;
       

        respostaA.text = alternativaA[idFase];
        respostaB.text = alternativaB[idFase];
        respostaC.text = alternativaC[idFase];
        respostaD.text = alternativaD[idFase];

        textX1.text = " ";
        textX2.text = " ";
        infoResposta.text = " ";
    }

    
}

    


