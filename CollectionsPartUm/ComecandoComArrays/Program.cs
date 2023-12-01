using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComecandoComArrays
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

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-----------Operações com Arrays------------");
            Console.WriteLine("-------------------------------------------");
            //Procurar um elemento no array, usando um método estático "IndexOf" da classe Array que buscará a primeira ocorrência de uma string,
            //retornando o índice onde foi encontrado:
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));//IndexOf(nome do array, nome da variável)

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));//Procurando a ultima ocorrencia do array
            Console.WriteLine("-------------------------------------------");
            Array.Reverse(aulas);// comando para inverter a ordem do array, o primeiro vira o último e por ai vai...o método Reverse() funciona
                                 // como um método idempotente, ou seja, se ele for rodado duas vezes, volta-se ao estado original.
            Imprimir(aulas);
            Console.WriteLine("-------------------------------------------");

            Array.Resize(ref aulas, 2); //o método Resize() redimensiona o array por referencia a sua declaração fica (ref nomeDoArray, tamanho)
            Imprimir(aulas);            //Internamente ele cria outro array do tamanho desejado e muda as referencias dos elementos do antigo para o novo.

            Console.WriteLine(" V V V V V --- Retornando para Size 3 --- V V V V V ");
            Array.Resize(ref aulas, 3); // o ultimo elemento estará nullo, porque foi perdido a referencia.
            Imprimir(aulas);

            Console.WriteLine(" V V V V V --- Preenchendo o último elemento do array --- V V V V V ");
            aulas[aulas.Length - 1] = "Conclusão"; // Para garantir de pegar o ultimo array podemos escrever dessa forma
            Imprimir(aulas);

            Console.WriteLine(" V V V V V --- Colocando em orgem alfabetica elemento do array --- V V V V V ");
            Array.Sort(aulas); //Uma vez usado não conseguimos voltar ao normal como no método Reverse()
            Imprimir(aulas);

            Console.WriteLine(" V V V V V --- Copiando um Array --- V V V V V ");
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2); // (array de origem (aulas), o índice inicial a partir do qual copiaremos
                                               // o array de aulas (1, que equivale à segunda posição), o nome do array de destino,
                                               // a posição inicial (índice 0), e a quantidade de elementos que iremos copiar (2)
            Imprimir(copia);

            Console.WriteLine(" V V V V V --- Clonando um Array --- V V V V V ");
            string[] clone = aulas.Clone() as string[]; // aulas.Clone(); Dessa forma a IDE irá reclamar que não consegue converter o tipo,
                                                        // então temos que fazer um cast
            Imprimir(copia);

            Console.WriteLine(" V V V V V --- Limpando um Array --- V V V V V ");
            Array.Clear(clone, 1, 2);   // Clear é um metodo estático da classe array,
                                        // ele é montado da seguinte forma (nomeDoArray, o índice da posição que queremos começar a limpar (1)
                                        // e o número de elementos que queremos limpar (2),
            Imprimir(clone);

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

        //C# suporta vários tipos de arrays:

        //array unidimensional
        //array multidimensional(array retangular)
        //array de arrays(arrays "denteados" ou "serrilhados")
        //Saiba mais sobre declaração e uso de arrays neste tutorial:

        //https://cursos.alura.com.br/course/csharp-collections/task/29649#:~:text=C%23%20suporta%20v%C3%A1rios,Trabalhando%20com%20Arrays


        //O que aprendemos?

        //Declarando um array
        //A sintaxe de um array em C#
        //Declarando e inicializando um array
        //Inicializando um array vazio com uma dimensão
        //Imprimindo elementos de um array
        //Índices
        //Procurando índices de um elemento
        //Encontrando a primeira ocorrência
        //Encontrando a última ocorrência
        //Revertendo arrays
        //Redimensionando arrays
        //Acessando elementos pelo índices
        //Ordenando arrays
        //Copiando arrays
        //Clonando arrays
        //Limpando elementos de um array
    }
}
