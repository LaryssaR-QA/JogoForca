using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace TI
{
    class Sorteio
    {
        static public string TemaSorteado { get; set; }
        static public string PalavraSorteada { get; set; }

        static public void Sortear(string ultima)
        {

            Random Aleatorio = new Random();

            string[] Tema = { "ANIMAL", "COR", "FRUTA/LEGUME/VERDURA", "OBJETO", "PAÍS" };
            string[] Palavras = new string[20];

            TemaSorteado = Tema[Aleatorio.Next(5)];

            if (TemaSorteado.Equals("ANIMAL"))
            {
                Palavras[0] = "MACACO";
                Palavras[1] = "ELEFANTE";                   
                Palavras[2] = "CACHORRO";
                Palavras[3] = "DINOSSAURO";
                Palavras[4] = "EMA";
                Palavras[5] = "AVESTRUZ";
                Palavras[6] = "RINOCERONTE";
                Palavras[7] = "BORBOLETA";
                Palavras[8] = "GATO";
                Palavras[9] = "LAGARTO";
                Palavras[10] = "CANGURU";
                Palavras[11] = "GIRAFA";
                Palavras[12] = "BALEIA";
                Palavras[13] = "GOLFINHO";
                Palavras[14] = "TARTARUGA";
                Palavras[15] = "VACA";
                Palavras[16] = "FLAMINGO";
                Palavras[17] = "CISNE";
                Palavras[18] = "CAVALO";
                Palavras[19] = "CACHALOTE";
            }
            else if (TemaSorteado.Equals("COR"))
            {
                Palavras[0] = "AMARELO";
                Palavras[1] = "VERMELHO";                   
                Palavras[2] = "OURO";
                Palavras[3] = "BRONZE";
                Palavras[4] = "COBRE";
                Palavras[5] = "VIOLETA";
                Palavras[6] = "CIANO";
                Palavras[7] = "MAGENTA";
                Palavras[8] = "DOURADO";
                Palavras[9] = "PRATA";
                Palavras[10] = "BEGE";
                Palavras[11] = "ROSA";
                Palavras[12] = "CINZA";
                Palavras[13] = "MARROM";
                Palavras[14] = "LARANJA";
                Palavras[15] = "BRANCO";
                Palavras[16] = "ROXO";
                Palavras[17] = "VERDE";
                Palavras[18] = "AZUL";
                Palavras[19] = "PRETO";
            }
            else if (TemaSorteado.Equals("FRUTA/LEGUME/VERDURA"))
            {
                Palavras[0] = "AMORA";
                Palavras[1] = "AMEIXA";                   
                Palavras[2] = "MANGA";
                Palavras[3] = "ABACATE";
                Palavras[4] = "CARAMBOLA";
                Palavras[5] = "ABOBRINHA";
                Palavras[6] = "QUIABO";
                Palavras[7] = "GOIABA";
                Palavras[8] = "MORANGO";
                Palavras[9] = "ABACAXI";
                Palavras[10] = "REPOLHO";
                Palavras[11] = "FRAMBOESA";
                Palavras[12] = "COUVE";
                Palavras[13] = "DAMASCO";
                Palavras[14] = "TOMATE";
                Palavras[15] = "BETERRABA";
                Palavras[16] = "CENOURA";
                Palavras[17] = "ALFACE";
                Palavras[18] = "MELANCIA";
                Palavras[19] = "BANANA";
            }
            else if (TemaSorteado.Equals("OBJETO"))
            {
                Palavras[0] = "BORRACHA";
                Palavras[1] = "COMPUTADOR";                   
                Palavras[2] = "LAPISEIRA";
                Palavras[3] = "CAMA";
                Palavras[4] = "LUSTRE";
                Palavras[5] = "JANELA";
                Palavras[6] = "MOEDA";
                Palavras[7] = "CARTEIRA";
                Palavras[8] = "BATOM";
                Palavras[9] = "APONTADOR";
                Palavras[10] = "LIVRO";
                Palavras[11] = "CALCULADORA";
                Palavras[12] = "TELEFONE";
                Palavras[13] = "CELULAR";
                Palavras[14] = "CHINELO";
                Palavras[15] = "MOCHILA";
                Palavras[16] = "PLACA";
                Palavras[17] = "SAPATO";
                Palavras[18] = "GARRAFA";
                Palavras[19] = "CADERNO";
            }
            else if (TemaSorteado.Equals("PAÍS"))
            {
                Palavras[0] = "DINAMARCA";
                Palavras[1] = "BRASIL";                   
                Palavras[2] = "ARGENTINA";
                Palavras[3] = "ANGOLA";
                Palavras[4] = "ALEMANHA";
                Palavras[5] = "PORTUGAL";
                Palavras[6] = "ESPANHA";
                Palavras[7] = "CHINA";
                Palavras[8] = "CHILE";
                Palavras[9] = "VENEZUELA";
                Palavras[10] = "PARAGUAI";
                Palavras[11] = "ALASCA";
                Palavras[12] = "BANGLADESH";
                Palavras[13] = "EGITO";
                Palavras[14] = "TURQUIA";
                Palavras[15] = "IRAQUE";
                Palavras[16] = "GANA";
                Palavras[17] = "MARROCOS";
                Palavras[18] = "SENEGAL";
                Palavras[19] = "PERU"; 
            }

            do
            {
                PalavraSorteada = Palavras[Aleatorio.Next(20)];
            } while (PalavraSorteada == ultima);       
        }
    }

    class Verificar
    {
        static private string[] CampoFantasma;
        static public string[] tentadas = new string[25];

        static public string povoarCampo(string palavra)
        {
            CampoFantasma = new string[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                CampoFantasma[i] = " _ ";
            }

            return MostrarCampos(palavra); //Função para colocar na label os tracinhos 
        }

        static private int Acerto(char letraDigitada, string palavraSorteada)
        {
            int ok = 1;

            for (int i = 0; i < palavraSorteada.Length; i++)
            {
                if (palavraSorteada[i] == letraDigitada)
                {
                    CampoFantasma[i] = Convert.ToString(letraDigitada);
                    ok++;                    
                }
            }

            return ok;
        }

        static private int Acerto(string palavraDigitada, string palavraSorteada)
        {
            int ok = 50;

            if (palavraDigitada.ToUpper().Equals(palavraSorteada))
                ok = 100;

            return ok;
        }

        static public int Testar(string digitada, string sorteada)
        {
            char letraDigitada;
            int Confirmacaoacerto = 0;

            if (digitada.Length == 1)
            {
                letraDigitada = Convert.ToChar(digitada.ToUpper());
                Confirmacaoacerto = Acerto(letraDigitada, sorteada);
            }
            else
                Confirmacaoacerto = Acerto(digitada, sorteada);

            return Confirmacaoacerto;
        }

        static public string MostrarCampos(string palavra)
        {
            string Campos = "";

            for (int i = 0; i < palavra.Length; i++)
            {
                Campos = Campos + CampoFantasma[i];
            }
            return Campos;
        }
        
        static int pos=0;
        static public bool Tentadas(string digitada)
        {
            bool resposta = false;

            for (int i = 0; i < tentadas.Length; i++)
            {
                if (tentadas[i] == digitada)
                {
                    resposta = true;
                }
                else
                    resposta = false;

                if (resposta)
                    break;
            }

            if(resposta==false)
            {
                tentadas[pos] = digitada.ToUpper();
                pos++;
            }
            
            return resposta;
        }

        static public string MostrarTentadas()
        {
            string Campos = "";

            for (int i = 0; i < tentadas.Length; i++)
            {
                Campos = Campos + tentadas[i] + "  ";
            }
            return Campos;
        }
       
    

        }
    }


