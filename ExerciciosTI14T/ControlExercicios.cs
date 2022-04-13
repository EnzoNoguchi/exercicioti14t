using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double bas;
        public double altura;
        public int dias;
        public int ano;
        public int meses;
        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03" +
                             "\n4. Exercício 04" +
                             "\n5. Exercício 05");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;



                case 2:
                    Console.WriteLine("Informe um numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de " + num + " é: " + model.Exercicio02(num));
                    break;




                case 3:
                    do
                    {
                        Console.WriteLine("Digite a base do triangulo");
                        bas = Convert.ToDouble(Console.ReadLine());
                        if (bas <= 0)
                        {
                            Console.WriteLine("Essa base digitada não é valida, digite novamente");
                        }
                    } while (bas <= 0);

                    do
                    {
                        Console.WriteLine("Digite a altura do triangulo");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        if (altura <= 0)
                        {
                            Console.WriteLine("Essa altura digitada não é valida, digite novamente");
                        }
                    } while (altura <= 0);

                    Console.WriteLine("A area do triangulo é: " + model.Exercicio03(bas, altura));
                    break;




                case 4:
                    do
                    {
                        Console.WriteLine("Dias");
                        dias = Convert.ToInt32(Console.ReadLine());
                        if (dias < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (dias < 0);


                    do
                    {
                        Console.WriteLine("Meses");
                        meses = Convert.ToInt32(Console.ReadLine());
                        if (meses < 0)
                        {
                            Console.WriteLine("Valor invalido, tente novamente");
                        }
                    } while (meses < 0);

                    do
                    {
                        Console.WriteLine("Anos");
                        ano = Convert.ToInt32(Console.ReadLine());
                        if (ano < 0)
                        {
                            Console.Write("Valor invalido, tente novamente");
                        }
                    } while (ano < 0);
                    
                    Console.WriteLine("A sua idade em dias é de " + model.Exercicio04(ano, meses, dias ));
                    break;

                

                



                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;
            }//fim do switch
        }//fim do executar
    }//fim da classe
}//fim do projeto
