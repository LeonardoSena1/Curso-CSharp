using CursoCsharp.Api;
using CursoCsharp.ClassesEMetodos;
using CursoCsharp.Colecoes;
using CursoCsharp.EstruturaDeControle;
using CursoCsharp.Excecoes;
using CursoCsharp.Fundamentos;
using CursoCsharp.MetodosEFuncoes;
using CursoCsharp.OO;
using CursoCsharp.TopicosAvancados;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar },
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar },
                {"LendoDados - Fundamentos", LendoDados.Executar },
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar },
                {"Conversoes - Fundamentos", Conversoes.Executar },
                {"OperadoresAritmeticos - Fundamentos", OperadoresAritmeticos.Execultar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Execultar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Execultar },
                {"Operadores de Atribuição - Fundamentos", OperadoresdeAtribuicao.Excultar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Execultar },


                //Estrutura de controle
                {"Estrutura If - Estrutura de controle", EstruturaIf.Execultar},
                {"Estrutura IF/ELSE - Estrutura de controle", EstruturaIFELSE.Execultar},   
                {"Estrutura IF/ELSE IF - Estrutura de controle", EstruturaIfElseIf.Execultar},   
                {"Estrutura SWITCH - Estrutura de controle", EstruturaSWITCH.Execultar},   
                {"Estrutura WHILE - Estrutura de controle", EstruturaWHILE.Execultar},   
                {"Estrutura Foreach - Estrutura de controle", EstruturaFOREACH.Executar},   
                {"Usando BREAK - Estrutura de controle", UsandoBREAK.Executar},   
                {"Usando CONTINUE - Estrutura de controle", UsandoCONTINUE.Executar},   


                //Classes e Métodos
                {"Membros - Classes e Metodos", Mebros.Executar},   
                {"Construtores - Classes e Metodos", Construtores.Executar},   
                {"Métodos Com Retorno  - Classes e Metodos", MetodosComRetorno.Executar},    
                {"Métodos Estáticos  - Classes e Metodos", MetodosEstaticos.Executar},    
                {"Atributos Estáticos  - Classes e Metodos", AtributosEstaticos.Executar},    
                {"Desafio Acessar Atributo  - Classes e Metodos", DesafioAcessarAtributo.Executar},    
                {"Params  - Classes e Metodos", Params.Executar},    
                {"Parâmetros Nomeados  - Classes e Metodos", ParametrosNomeados.Executar},    
                {"Get Set  - Classes e Metodos", GetSet.Executar},    
                {"Props  - Classes e Metodos", Props.Executar},    
                {"Atributos Readonly  - Classes e Metodos", AtributosReadonly.Executar},    
                {"Enum  - Classes e Metodos", EnumeracoesEnum.Executar},    
                {"Struct  - Classes e Metodos", Struct.Executar},    
                {"Class vs Struct  - Classes e Metodos", ClassvsStruct.Executar},    
                {"Valor vs Referência  - Classes e Metodos", ValorvsReferencia.Executar},    
                {"Parâmetros por Referência (Ref/Out)  - Classes e Metodos", ParametrosporReferencia_RefOut.Executar},    
                {"Parâmetro com Valor Padrão  - Classes e Metodos", ParametrocomValorPadrao.Executar},
                

                //Coleções
                {"Array - Coleções", CursoCsharp.Colecoes.Array.Executar},    
                {"List - Coleções", List.Executar},    
                {"Array List - Coleções", ColecoesArrayList.Executar},    
                {"Coleções Set - Coleções", ColecoesSet.Executar},    
                {"Queue - Coleções", ColecoesQueue.Executar},    
                {"Igualdade (Equals e GetHashCode) - Coleções", IgualdadeEqualseGetHashCode.Executar},    
                {"Stack - Coleções", ColecoesStack.Executar},    
                {"Dictionary - Coleções", ColecoesDictionary.Executar},     


                //Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},     
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},     
                {"Encapsulamento - Orientação a Objetos", CursoCsharp.OO.Encapsulamento.Executar},     
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},     
                {"Classe Abstrata - Orientação a Objetos", ClasseAbstrata.Executar},     
                {"Sealed - Orientação a Objetos", Sealed.Executar},     


                //Metodos e Funções
                {"Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar},     
                {"Delegate com Lambda - Metodos e Funções", DelegatecomLambda.Executar},     
                {"Usando Delegates - Metodos e Funções", DelegatesUsando.Executar},     
                {"Delegate com Funções Anônimas - Metodos e Funções", DelegatecomFuncoesAnonimas.Executar},     
                {"Métodos de Extensão - Metodos e Funções", MetodosdeExtensao.Executar},   
                

                //Tratamento de Erro Exeções
                {"Primeira Exceção - Exeções", PrimeiraExcecao.Executar},     
                {"Exceções Personalizadas - Exeções", ExcecoesPersonalizadas.Executar},     


                //Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},     
                {"Lendo Arquivo - Usando API", LendoArquivo.Executar},     
                {"Usando FileInfo - Usando API", UsandoFileInfo.Executar},     
                {"Diretorios - Usando API", Diretorios.Executar},     
                {"DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},     
                {"Usando Path - Usando API", UsandoPath.Executar},     
                {"Usando DateTime - Usando API", UsandoDateTime.Executar},     
                {"Usando TimeSpan - Usando API", UsandoTimeSpan.Executar},  
                

                //Topicos Avançados
                {"Linq #01 - Usando API", LINQ01.Executar},     
                {"Linq #02 - Usando API", Linq02.Executar},     
                {"Nullables - Usando API", Nullables.Executar},     
                {"Dynamic - Usando API", Dynamic.Executar},     
                {"Genericos - Usando API", Genericos.Executar},     
            });

            central.SelecionarEExecutar();
        }
    }
}