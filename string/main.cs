/******************************************************************************

Welcome to GDB Online.
  GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
  C#, OCaml, VB, Perl, Swift, Prolog, Javascript, Pascal, COBOL, HTML, CSS, JS
  Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program {
  public static void Main (string[] args) {
    int SOMA = 0; 
    Console.WriteLine("Digite uma palavra");
    string palavra = Console.ReadLine();
    for(int i=0; i<palavra.Length; i++){
        if(palavra[i] == 'a' || palavra[i] == 'A')
        SOMA++;
    }
    
  Console.WriteLine(SOMA);

    
  }
}