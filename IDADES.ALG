Algoritmo "idades"

Var
         idade1, idade2  : inteiro
         nome1, nome2 : caractere
          media : real
          
Inicio
       escreval("Dados da primeira pessoa: ")
       escreva("Nome: ")
       leia(nome1)
       escreva("Idade: ")
       leia(idade1)
       
       escreval("Dados da segunda pessoa: ")
       escreva("Nome: ")
       leia(nome2)
       escreva("Idade: ")
       leia(idade2)
       media <- (idade1 + idade2) / 2
       
       escreval("A idade média de ", nome1, " e ", nome2,  " é de ", media, " anos")

Fimalgoritmo