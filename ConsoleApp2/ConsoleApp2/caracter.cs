using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //classe define uma entidade do sistema, definindo propriedades e ações que podem ser realizadas(metodos)
    class caracter
    {

       public byte Posicao { set; get; }
        public String Aparencia { set; get; }
        public String Virado_Esquerda { set; get; }
        public String Virado_Direita { set; get; }
        public Boolean Pulando { set; get; }

        //public byte Posicao
       // { 
      //  get(return Posicao);
      //  set(Posicao = value);
       // }


       /* public void confPosicao(Byte valor) { Posicao = valor; }
        public Byte retornaPosicao() { return Posicao; }

        public void confAparencia(String valor) { Aparencia = valor; }
        public String retornaAparencia() { return Aparencia; }

        public void confVirado_Esquerda(String valor) { Virado_Esquerda = valor; }
        public String retornaVirado_Esquerda() { return Virado_Esquerda; }

        public void confVirado_Direita(String valor) { Virado_Direita = valor; }
        public String retornaVirado_Direita() { return Virado_Direita; }

        public void confPulando(Boolean valor) { Pulando = valor; }
        public Boolean retornaPulando() { return Pulando; }*/

        public caracter(String esquerda, String direita)
        {
            Virado_Esquerda = esquerda;
            Virado_Direita = direita;
            Aparencia = Virado_Direita;
            Posicao = 0;
            Pulando = false;
        }
            
          
      //  public void pula()()
      //  {
          
     //   }

      //  public void anda()()
     //   {

      //  }
    }
}
