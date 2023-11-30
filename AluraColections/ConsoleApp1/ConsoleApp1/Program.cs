using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            // Declarando um Array quando já sabemos quais elementos que ele vai conter
            //  (O tamanho é implicito pela quantidade de elementos que estamos declarando)

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //---------------------------------------------------

            // Declarando um array de tamanho fixo (explicita).
            string[] aulas = new string[3];
            // Rodando a app até aqui, veremos que em aulas estão armazenadas três posições,
            //  Cada uma com valor null (nulo), e estes elementos ainda são desconhecidos, porém já temos o array declarado.

            //---------------------------------------------------

            // Agora vamos preencher os elementos.
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;
            // Agora temos o array "aulas" possui os 3 elementos preenchidos

            //Atalho para o comando abaixo: "cw + Tab + Tab"
            Console.WriteLine(aulas + " -> Dessa forma tentamos imprimir o array, aulas, e não os elementos dele");   //se rodarmos desse jeito, vemos o resultado "System.String[]",
            Console.WriteLine("-------------------------------------------");                                                                                                        //  para imprimir os elementos do array precisamos varrer a coleção (aulas) e imprimir item a item.

            //---------------------------------------------------
            //  Uma das maneiras de se fazer isso é utilizar a instrução foreach para informar que,
            //  para cada aula em aulas, se faça algo no caso imprimir

            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula + " -> Estamos varrendo os elemenos de aulas e imprimindo item a item na variavel aula");
            //}

            //---------------------------------------------------

            // Vamos pegar esta instrução e a jogaremos a outro método para a reutilização.
            // Utilizando "Ctrl + . (ponto)" extrairemos o método denominado Imprimir(). Nele, teremos nosso laço foreach.
            // Conforme abaixo, 


            Imprimir(aulas);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(aulas[0] + " -> Imprimindo apenas o primeiro elemento");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(aulas[aulas.Length - 1] + " -> Imprimindo apenas o último elemento");
            Console.WriteLine("-------------------------------------------");

            //---------------------------------------------------

            // E se quisermos modificar um elemento?
            aulaIntro = "Trabalhando com Arrays"; // não teremos nenhuma mudança! Isso ocorre pois aulaIntro não está sendo armazenado
                                                  // no nosso array de aulas. O que armazenamos aqui foi o valor copiado de aulaIntro,
                                                  // portanto não adianta mudarmos seu valor.
            Imprimir(aulas);
            Console.WriteLine("Forma errada de tentar modificar um elemento.");
            Console.WriteLine("-------------------------------------------");

            aulas[0] = "Trabalhando com Arrays"; // Dessa forma estamos modificando diretamenta a primeira posição do array
            Imprimir(aulas);
            Console.WriteLine("Forma correta de modificar um elemento.");

        }   // Colocar um Breakpoint aqui para analisarmos o preenchimento se necessário

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas) // Essa solução apenas precisamos do nome do array.
            //{
            //    Console.WriteLine(aula + " -> Estamos varrendo os elemenos de aulas e imprimindo item a item na variavel aula");
            //}

            for (int i = 0; i < aulas.Length; i++) //Outra forma de imprimir os elementos é com o laço for, dessa forma conseguimos
                                                   //   controlar o avanço do índice. Neste caso, é necessário sabermos seu comprimento
                                                   //   e o índice que está sendo impresso.
            {
                Console.WriteLine(aulas[i] + " -> Estamos varrendo os elemenos de aulas e imprimindo item a item na variavel aula");
            }
        }
    } 
}
