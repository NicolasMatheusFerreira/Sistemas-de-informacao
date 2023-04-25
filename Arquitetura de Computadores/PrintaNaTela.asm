.data
	idade: .word 56 # Valor 56 atribuido a minha variável do tipo (.word) equivalente ao um int (integer) <- Vindo a memória RAM.
	nome: .ascii "Nicolas"
.text	
	lw $a0, idade
	li $v0, 1
	syscall	
	
	li $v0, 10 # Código para interromper o programa		
					
	la $a0, nome # Carrega conteúdo vindo da variável nome para o registrador $a1					
	li $v0, 4 # Carrega para o registrador $v1 o código de impressao para printar na tela
	syscall
	
	li $v0, 10 # Código para interromper o programa
.main:	
