using System;

namespace JoãoGabrielFortesProjeto3
{
    class Program
    {
        static void Main(string[] args)
        { 
        
              
              {
                  
                  Console.WriteLine ("Boas Vindas a Calculadora Top! Aperte qualquer botão para continuar!");
                  Console.ReadKey();
                  Console.Clear();
                  int opcao;
                  do
                  { Console.ForegroundColor = ConsoleColor.White;
                  Console.WriteLine ("------------------------------------------------------------------");
                  Console.WriteLine ("Usuário: Aluno");
                  Console.WriteLine ("-------------------------MENU-------------------------------------");
                  Console.WriteLine ("[1] Soma");
                  Console.WriteLine ("[2] Subtração");
                  Console.WriteLine ("[3] Multiplicação");
                  Console.WriteLine ("[4] Divisão");
                  Console.WriteLine ("[5] Sair");
                  Console.WriteLine ("------------------------------------------------------------------");
                  opcao = Convert.ToInt32(Console.ReadLine());
                  decimal valor1;
                  decimal valor2;
                  int escolha;
                  if (opcao == 1)
                  {  

                     
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------SOMA-------------------------------------");
                     Console.WriteLine ("[1] Fazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());

                     if (escolha > 2 || escolha <1)
                    {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();
                       
                     }
                    
                     
                     else if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine ("Retornando ao Menu Inicial, aperte qualquer botão para continuar");
                       Console.ReadKey();
                       Console.Clear();
                     }
                     else

                     do
                     {
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------SOMA-------------------------------------");
                     Console.WriteLine ("Insira o primeiro valor: ");
                     valor1 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine ("Insira o segundo valor: ");
                     valor2 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine("Resultado="+ (valor1 + valor2));
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------SOMA-------------------------------------");
                     Console.WriteLine ("[1] Refazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("Retornando ao Menu Inicial");
                       Console.ReadKey();
                       Console.Clear();
                     }
                     else if (escolha < 1 || escolha > 2){
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();

                     }}

                     while (escolha == 1);
                     }

                  if (opcao == 2)
                  {  

                     
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------SUBTRAÇÃO--------------------------------");
                     Console.WriteLine ("[1] Fazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     
                      if (escolha > 2 || escolha <1)
                    {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();
                       
                     }
                    
                     
                     else if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine ("Retornando ao Menu Inicial, aperte qualquer botão para continuar");
                       Console.ReadKey();
                       Console.Clear();
                     }
                     else

                     do
                     {
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------SUBTRAÇÃO--------------------------------");
                     Console.WriteLine ("Insira o primeiro valor: ");
                     valor1 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine ("Insira o segundo valor: ");
                     valor2 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine("Resultado="+ (valor1 - valor2));
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------SUBTRAÇÃO--------------------------------");
                     Console.WriteLine ("[1] Refazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("Retornando ao Menu Inicial");
                       Console.ReadKey();
                       Console.Clear();
                     }
                      else if (escolha < 1 || escolha > 2){
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();

                     }}

                     while (escolha == 1);
                     }

                  if (opcao == 3)
                  {  

                     
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------MULTIPLICAÇÃO----------------------------");
                     Console.WriteLine ("[1] Fazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     
                      if (escolha > 2 || escolha <1)
                    {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();
                       
                     }
                    
                     
                     else if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine ("Retornando ao Menu Inicial, aperte qualquer botão para continuar");
                       Console.ReadKey();
                       Console.Clear();
                     }
                     else

                     do
                     {
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------MULTIPLICAÇÃO----------------------------");
                     Console.WriteLine ("Insira o primeiro valor: ");
                     valor1 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine ("Insira o segundo valor: ");
                     valor2 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine("Resultado="+ (valor1 * valor2));
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------MULTIPLICAÇÃO----------------------------");
                     Console.WriteLine ("[1] Refazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("Retornando ao Menu Inicial");
                       Console.ReadKey();
                       Console.Clear();
                     }
                      else if (escolha < 1 || escolha > 2){
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();

                     }}

                     while (escolha == 1);
                     }

                  if (opcao == 4)
                   {  

                     
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------DIVISÃO----------------------------------");
                     Console.WriteLine ("[1] Fazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     
                      if (escolha > 2 || escolha <1)
                    {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();
                       
                     }
                    
                     
                     else if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine ("Retornando ao Menu Inicial, aperte qualquer botão para continuar");
                       Console.ReadKey();
                       Console.Clear();
                     }
                     else

                     do
                     {
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------DIVISÃO----------------------------------");
                     Console.WriteLine ("Insira o primeiro valor: ");
                     valor1 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine ("Insira o segundo valor: ");
                     valor2 = Convert.ToDecimal(Console.ReadLine());
                     Console.WriteLine("Resultado="+ (valor1 / valor2));
                     Console.WriteLine ("------------------------------------------------------------------");
                     Console.WriteLine ("Usuário: Aluno");
                     Console.WriteLine ("-------------------------DIVISÃO----------------------------------");
                     Console.WriteLine ("[1] Refazer a Operação");
                     Console.WriteLine ("[2] Retornar ao Menu Inicial");
                     escolha = Convert.ToInt32(Console.ReadLine ());
                     if (escolha == 2)
                     {
                       Console.ForegroundColor = ConsoleColor.Green;
                       Console.WriteLine("Retornando ao Menu Inicial");
                       Console.ReadKey();
                       Console.Clear();
                     }
                      else if (escolha < 1 || escolha > 2){
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine ("Comando Inválido! Você retornará ao menu inicial.");
                       Console.ReadKey();
                       Console.Clear();

                     }}

                     while (escolha == 1);
                     }
                  
               if (opcao == 5){
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine ("Obrigado por utilizar a Calculadora Top! Até a próxima!");
                
               }
               if (opcao < 1 || opcao > 5){
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine ("Comando Inválido");
               }

              } while (opcao != 5);
                  
                }
            }
        }
    }

                 


                  

                
                  
                  


              
              
            
             

            
       


               

               
            

        
    

