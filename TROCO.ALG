Algoritmo "TROCO"

Var
       preco, dinheiro, troco : real
       quantidade : inteiro


Inicio

      escreva ("Preço unitario do produto: ")
      leia(preco)
      escreva ("Quantidade compra: ")
      leia(quantidade)
      escreval("Dinheiro recebido: ")
      leia(dinheiro)

      troco <- dinheiro - preco * quantidade
      
      escreval("TROCO = ", troco:8:2)


Fimalgoritmo