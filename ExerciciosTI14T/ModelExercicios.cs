using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ModelExercicios
    {
        
        
        
      //--------------------------------------------------------EXERCICIOS VARIAVEIS---------------------------------------------------------------------  
        
        
        //Declaração de variáveis
        private int A;
        private int B;
        private int C;
        private int dois;
        private int tres;
        private double tres2;
        

        //---------------------------------------------------------------------------------------------------------------------------------------



        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 20;
            ConsultarC = 0;
        }//fim do construtor

        public int ConsultarA
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do consultarA

        public int ConsultarB
        {
            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }
        }//fim do consultarB

        public int ConsultarC
        {
            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }
        }//fim do consultarC



        //-------------------------------------------------------------EXERCICIOS------------------------------------------------------------------------






        //Método Exercício01
        public string Exercicio01()
        {
            ConsultarC = ConsultarA;
            ConsultarA = ConsultarB;
            ConsultarB = ConsultarC;
            return "A: " + ConsultarA + "\nB: " + ConsultarB;
        }//fim do métodoExercicio01




        //Método Exercicio02
        public int Exercicio02(int num)
        {
            return num - 1;
        }//fim do métodoExercicio02


        //Método Exercicio03
        public double Exercicio03(double bas, double altura)
        {
            return bas * altura;
        }//fim do métodoExercicio02



        //Método Exercicio04
        public int Exercicio04(int ano, int meses, int dias)
        {
            return (ano * 365) + (meses * 30) + dias;
        }//fim do métodoExercicio02

        

       



    }//fim da classe
}//fim do projeto
