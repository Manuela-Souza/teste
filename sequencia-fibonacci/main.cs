/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/


using System;

class Program {
  public static void Main (string[] args) {
   int cont=0;
    Console.WriteLine("Digite um num");
    int num = int.Parse(Console.ReadLine());
    int [] vetor = new int [num+1];
    vetor[0]= 0;
    vetor[1]=1;
    for(int i=2; i<vetor.Length; i++){
        vetor[i]=vetor[i-1]+ vetor[i-2]; 
    }
    
    for(int i=0; i<vetor.Length; i++){
        if(num==vetor[i])
        cont ++;
    }
    if(cont==1)
    Console.WriteLine("O numero pertence a sequencia Fibonacci");
    else
    Console.WriteLine("O numero nao pertence a sequencia Fibonacci");
  }
}

