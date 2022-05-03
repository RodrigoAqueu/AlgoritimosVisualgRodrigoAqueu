Algoritmo "Duracao"

Var
      duracao, horas, resto, minutos, segundos : inteiro


Inicio
       escreva("Digite a duracao em segundos: ")
       leia(duracao)
       
      // escreva("Digite a medida B: ")
      // leia(B)

      // escreva("Digite a medida C: ")
      // leia(C)

       horas <- duracao \ 3600
       resto <- duracao % 3600
       minutos <- resto \ 60
       segundos <- resto % 60
       
      // escreval("AREA DO QUADRADO = ", medidaQuadrado:5:4)
     //  escreval("AREA DO TRIANGULO = ", medidaRetangulo:5:4)
       escreval(horas,":", minutos, ":", segundos)

Fimalgoritmo